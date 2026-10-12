using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DatasulCompileGen.Core
{
    public class ProgressSearchEngine
    {
        private class ScannedFileEntry
        {
            public string FilePath { get; set; }
            public string RelativePath { get; set; }
            public string FileName { get; set; }
            public string Extension { get; set; }
            public bool IsCompilable { get; set; }
            public List<LineMatch> DirectMatches { get; set; }
            public List<IncludeReference> OutgoingIncludes { get; set; }
        }

        private class ReverseIncludeEdge
        {
            public ScannedFileEntry ReferencingFile { get; set; }
            public IncludeReference ReferenceDetail { get; set; }
        }

        private class BfsNode
        {
            public ScannedFileEntry CurrentFile { get; set; }
            public string OriginIncludeRelativePath { get; set; }
            public List<string> PathChain { get; set; }
            public int Depth { get; set; }
        }

        public Task<SearchReport> ExecuteSearchAsync(
            SearchOptions options,
            IProgress<SearchProgressInfo> progress,
            CancellationToken cancellationToken)
        {
            return Task.Run(() => ExecuteSearch(options, progress, cancellationToken), cancellationToken);
        }

        public SearchReport ExecuteSearch(
            SearchOptions options,
            IProgress<SearchProgressInfo> progress,
            CancellationToken cancellationToken)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }
            if (string.IsNullOrWhiteSpace(options.RootDirectory) || !Directory.Exists(options.RootDirectory))
            {
                throw new DirectoryNotFoundException("Diretorio raiz invalido ou inexistente: " + options.RootDirectory);
            }
            if (string.IsNullOrWhiteSpace(options.SearchTerm))
            {
                throw new ArgumentException("O termo de busca nao pode ser vazio.");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            string rootFull = Path.GetFullPath(options.RootDirectory).TrimEnd('\\', '/');

            HashSet<string> allowedExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (options.Extensions != null)
            {
                foreach (string ext in options.Extensions)
                {
                    if (!string.IsNullOrWhiteSpace(ext))
                    {
                        string normalizedExt = ext.Trim();
                        if (!normalizedExt.StartsWith("."))
                        {
                            normalizedExt = "." + normalizedExt;
                        }
                        allowedExtensions.Add(normalizedExt);
                    }
                }
            }

            List<string> candidateFiles = EnumerateCandidateFiles(rootFull, allowedExtensions, cancellationToken);
            int totalFiles = candidateFiles.Count;

            List<ScannedFileEntry> scannedEntries = new List<ScannedFileEntry>(totalFiles);
            Dictionary<string, List<ScannedFileEntry>> includeFilesByName =
                new Dictionary<string, List<ScannedFileEntry>>(StringComparer.OrdinalIgnoreCase);

            StringComparison comparison = options.CaseSensitive
                ? StringComparison.Ordinal
                : StringComparison.OrdinalIgnoreCase;

            string searchTerm = options.SearchTerm;

            for (int i = 0; i < totalFiles; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                string filePath = candidateFiles[i];

                if (progress != null && (i % 25 == 0 || i == totalFiles - 1))
                {
                    SearchProgressInfo info = new SearchProgressInfo();
                    info.ProcessedFiles = i + 1;
                    info.TotalFiles = totalFiles;
                    info.CurrentFile = GetRelativePath(rootFull, filePath);
                    info.PhaseMessage = string.Format("Varrendo arquivos ({0}/{1})...", i + 1, totalFiles);
                    progress.Report(info);
                }

                string content;
                try
                {
                    content = ProgressCodeAnalyzer.ReadFileWithAutoEncoding(filePath);
                }
                catch (Exception)
                {
                    continue;
                }

                bool needStripped = options.IgnoreComments || options.TrackIncludes;
                string strippedContent = needStripped
                    ? ProgressCodeAnalyzer.StripCommentsPreservingLines(content)
                    : string.Empty;

                string searchTargetContent = options.IgnoreComments ? strippedContent : content;
                List<LineMatch> directMatches = FindMatchesInContent(
                    content,
                    searchTargetContent,
                    searchTerm,
                    comparison,
                    options.WholeWord);

                List<IncludeReference> outgoingIncludes = options.TrackIncludes
                    ? ProgressCodeAnalyzer.ExtractIncludeReferences(content, strippedContent)
                    : new List<IncludeReference>();

                string ext = Path.GetExtension(filePath) ?? string.Empty;
                string relPath = GetRelativePath(rootFull, filePath);

                ScannedFileEntry entry = new ScannedFileEntry();
                entry.FilePath = filePath;
                entry.RelativePath = relPath;
                entry.FileName = Path.GetFileName(filePath) ?? string.Empty;
                entry.Extension = ext;
                entry.IsCompilable = options.CompilableExtensions != null && options.CompilableExtensions.Contains(ext);
                entry.DirectMatches = directMatches;
                entry.OutgoingIncludes = outgoingIncludes;

                scannedEntries.Add(entry);

                if (ext.Equals(".i", StringComparison.OrdinalIgnoreCase))
                {
                    List<ScannedFileEntry> listByName;
                    if (!includeFilesByName.TryGetValue(entry.FileName, out listByName))
                    {
                        listByName = new List<ScannedFileEntry>();
                        includeFilesByName[entry.FileName] = listByName;
                    }
                    listByName.Add(entry);
                }
            }

            // Prepare result map keyed by full FilePath
            Dictionary<string, FileSearchResult> resultsByPath =
                new Dictionary<string, FileSearchResult>(StringComparer.OrdinalIgnoreCase);

            foreach (ScannedFileEntry entry in scannedEntries)
            {
                if (entry.DirectMatches.Count > 0)
                {
                    FileSearchResult result = GetOrCreateResult(resultsByPath, entry);
                    result.IsDirectMatch = true;
                    result.DirectMatches.AddRange(entry.DirectMatches);
                }
            }

            // Reverse include resolution (multilevel BFS with cycle protection)
            if (options.TrackIncludes)
            {
                if (progress != null)
                {
                    SearchProgressInfo info = new SearchProgressInfo();
                    info.ProcessedFiles = totalFiles;
                    info.TotalFiles = totalFiles;
                    info.PhaseMessage = "Rastreando dependencias de includes (.i)...";
                    progress.Report(info);
                }

                Dictionary<string, List<ReverseIncludeEdge>> reverseGraph =
                    BuildReverseIncludeGraph(scannedEntries, includeFilesByName);

                int maxDepth = options.MaxIncludeDepth > 0 ? options.MaxIncludeDepth : 10;

                foreach (ScannedFileEntry startInclude in scannedEntries)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (!startInclude.Extension.Equals(".i", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    if (startInclude.DirectMatches.Count == 0)
                    {
                        continue;
                    }

                    Queue<BfsNode> queue = new Queue<BfsNode>();
                    HashSet<string> visitedInChain = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    visitedInChain.Add(startInclude.FilePath);

                    BfsNode rootNode = new BfsNode();
                    rootNode.CurrentFile = startInclude;
                    rootNode.OriginIncludeRelativePath = startInclude.RelativePath;
                    rootNode.PathChain = new List<string> { startInclude.RelativePath };
                    rootNode.Depth = 0;
                    queue.Enqueue(rootNode);

                    while (queue.Count > 0)
                    {
                        BfsNode current = queue.Dequeue();
                        if (current.Depth >= maxDepth)
                        {
                            continue;
                        }

                        List<ReverseIncludeEdge> incomingEdges;
                        if (!reverseGraph.TryGetValue(current.CurrentFile.FilePath, out incomingEdges))
                        {
                            continue;
                        }

                        foreach (ReverseIncludeEdge edge in incomingEdges)
                        {
                            ScannedFileEntry caller = edge.ReferencingFile;

                            List<string> nextChain = new List<string>(current.PathChain);
                            nextChain.Add(caller.RelativePath);

                            FileSearchResult callerResult = GetOrCreateResult(resultsByPath, caller);
                            callerResult.IsIncludeMatch = true;

                            IncludeChainStep step = new IncludeChainStep();
                            step.SourceIncludeFile = current.OriginIncludeRelativePath;
                            step.TargetFile = caller.RelativePath;
                            step.LineNumber = edge.ReferenceDetail.LineNumber;
                            step.LineText = edge.ReferenceDetail.LineText;
                            step.ChainDescription = string.Join(" -> ", nextChain.ToArray());

                            bool alreadyRecorded = callerResult.IncludeMatches.Any(
                                existing => existing.LineNumber == step.LineNumber &&
                                            string.Equals(existing.ChainDescription, step.ChainDescription, StringComparison.OrdinalIgnoreCase));

                            if (!alreadyRecorded)
                            {
                                callerResult.IncludeMatches.Add(step);
                            }

                            if (!visitedInChain.Contains(caller.FilePath))
                            {
                                visitedInChain.Add(caller.FilePath);

                                if (caller.Extension.Equals(".i", StringComparison.OrdinalIgnoreCase))
                                {
                                    BfsNode nextNode = new BfsNode();
                                    nextNode.CurrentFile = caller;
                                    nextNode.OriginIncludeRelativePath = current.OriginIncludeRelativePath;
                                    nextNode.PathChain = nextChain;
                                    nextNode.Depth = current.Depth + 1;
                                    queue.Enqueue(nextNode);
                                }
                            }
                        }
                    }
                }
            }

            stopwatch.Stop();

            List<FileSearchResult> allResults = resultsByPath.Values
                .OrderByDescending(r => r.IsCompilable)
                .ThenBy(r => r.RelativePath, StringComparer.OrdinalIgnoreCase)
                .ToList();

            List<FileSearchResult> compilableResults = allResults
                .Where(r => r.IsCompilable)
                .OrderBy(r => r.RelativePath, StringComparer.OrdinalIgnoreCase)
                .ToList();

            SearchReport report = new SearchReport();
            report.Options = options;
            report.AllResults = allResults;
            report.CompilableResults = compilableResults;
            report.TotalFilesScanned = totalFiles;
            report.ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            return report;
        }

        private static Dictionary<string, List<ReverseIncludeEdge>> BuildReverseIncludeGraph(
            List<ScannedFileEntry> allEntries,
            Dictionary<string, List<ScannedFileEntry>> includeFilesByName)
        {
            Dictionary<string, List<ReverseIncludeEdge>> graph =
                new Dictionary<string, List<ReverseIncludeEdge>>(StringComparer.OrdinalIgnoreCase);

            foreach (ScannedFileEntry caller in allEntries)
            {
                if (caller.OutgoingIncludes == null || caller.OutgoingIncludes.Count == 0)
                {
                    continue;
                }

                foreach (IncludeReference incRef in caller.OutgoingIncludes)
                {
                    List<ScannedFileEntry> candidates;
                    if (!includeFilesByName.TryGetValue(incRef.IncludeFileName, out candidates))
                    {
                        continue;
                    }

                    bool refHasSubdir = incRef.NormalizedIncludePath.Contains("/");

                    foreach (ScannedFileEntry targetInclude in candidates)
                    {
                        if (string.Equals(caller.FilePath, targetInclude.FilePath, StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        bool matches = false;
                        if (!refHasSubdir)
                        {
                            matches = true;
                        }
                        else
                        {
                            if (targetInclude.RelativePath.Equals(incRef.NormalizedIncludePath, StringComparison.OrdinalIgnoreCase) ||
                                targetInclude.RelativePath.EndsWith("/" + incRef.NormalizedIncludePath, StringComparison.OrdinalIgnoreCase))
                            {
                                matches = true;
                            }
                            else if (candidates.Count == 1)
                            {
                                // In Datasul PROPATH, subdirectories like {include/es-def.i} might be rooted inside a subfolder
                                matches = true;
                            }
                        }

                        if (matches)
                        {
                            List<ReverseIncludeEdge> edgeList;
                            if (!graph.TryGetValue(targetInclude.FilePath, out edgeList))
                            {
                                edgeList = new List<ReverseIncludeEdge>();
                                graph[targetInclude.FilePath] = edgeList;
                            }

                            ReverseIncludeEdge edge = new ReverseIncludeEdge();
                            edge.ReferencingFile = caller;
                            edge.ReferenceDetail = incRef;
                            edgeList.Add(edge);
                        }
                    }
                }
            }

            return graph;
        }

        private static FileSearchResult GetOrCreateResult(
            Dictionary<string, FileSearchResult> resultsByPath,
            ScannedFileEntry entry)
        {
            FileSearchResult result;
            if (!resultsByPath.TryGetValue(entry.FilePath, out result))
            {
                result = new FileSearchResult();
                result.FilePath = entry.FilePath;
                result.RelativePath = entry.RelativePath;
                result.Extension = entry.Extension;
                result.IsCompilable = entry.IsCompilable;
                result.SelectedForCompile = entry.IsCompilable;
                resultsByPath[entry.FilePath] = result;
            }
            return result;
        }

        private static List<LineMatch> FindMatchesInContent(
            string originalContent,
            string searchTargetContent,
            string searchTerm,
            StringComparison comparison,
            bool wholeWord)
        {
            List<LineMatch> matches = new List<LineMatch>();
            if (string.IsNullOrEmpty(searchTargetContent) || string.IsNullOrEmpty(searchTerm))
            {
                return matches;
            }

            // Fast pre-check before splitting lines
            if (searchTargetContent.IndexOf(searchTerm, comparison) < 0)
            {
                return matches;
            }

            string[] originalLines = ProgressCodeAnalyzer.SplitLines(originalContent);
            string[] targetLines = ProgressCodeAnalyzer.SplitLines(searchTargetContent);
            int count = Math.Min(originalLines.Length, targetLines.Length);

            for (int i = 0; i < count; i++)
            {
                string line = targetLines[i];
                int searchFrom = 0;
                while (searchFrom <= line.Length - searchTerm.Length)
                {
                    int idx = line.IndexOf(searchTerm, searchFrom, comparison);
                    if (idx < 0)
                    {
                        break;
                    }

                    if (!wholeWord || IsWholeProgressWord(line, idx, searchTerm.Length))
                    {
                        LineMatch m = new LineMatch();
                        m.LineNumber = i + 1;
                        m.ColumnIndex = idx + 1;
                        m.LineText = originalLines[i];
                        matches.Add(m);
                        break; // One match entry per line (like VS Code line grouping)
                    }

                    searchFrom = idx + 1;
                }
            }

            return matches;
        }

        private static bool IsWholeProgressWord(string line, int startIndex, int length)
        {
            if (startIndex > 0 && IsProgressIdentifierChar(line[startIndex - 1]))
            {
                return false;
            }
            int endIndex = startIndex + length;
            if (endIndex < line.Length && IsProgressIdentifierChar(line[endIndex]))
            {
                return false;
            }
            return true;
        }

        private static bool IsProgressIdentifierChar(char c)
        {
            return char.IsLetterOrDigit(c) || c == '_' || c == '-';
        }

        private static List<string> EnumerateCandidateFiles(
            string rootDirectory,
            HashSet<string> allowedExtensions,
            CancellationToken cancellationToken)
        {
            List<string> files = new List<string>();
            Stack<string> dirs = new Stack<string>();
            dirs.Push(rootDirectory);

            while (dirs.Count > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();
                string currentDir = dirs.Pop();

                string[] subDirs = null;
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                catch (Exception)
                {
                    continue;
                }

                // Push in reverse order so traversal is alphabetical
                for (int i = subDirs.Length - 1; i >= 0; i--)
                {
                    string dirName = Path.GetFileName(subDirs[i]);
                    if (!string.IsNullOrEmpty(dirName) && !dirName.StartsWith("."))
                    {
                        dirs.Push(subDirs[i]);
                    }
                }

                string[] dirFiles = null;
                try
                {
                    dirFiles = Directory.GetFiles(currentDir);
                }
                catch (Exception)
                {
                    continue;
                }

                foreach (string file in dirFiles)
                {
                    string ext = Path.GetExtension(file);
                    if (!string.IsNullOrEmpty(ext) && allowedExtensions.Contains(ext))
                    {
                        files.Add(file);
                    }
                }
            }

            return files;
        }

        public static string GetRelativePath(string rootFull, string fullFilePath)
        {
            string normalizedRoot = rootFull.Replace('\\', '/').TrimEnd('/');
            string normalizedFile = Path.GetFullPath(fullFilePath).Replace('\\', '/');

            if (normalizedFile.StartsWith(normalizedRoot + "/", StringComparison.OrdinalIgnoreCase))
            {
                return normalizedFile.Substring(normalizedRoot.Length + 1);
            }
            return normalizedFile;
        }
    }
}
