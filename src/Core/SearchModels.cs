using System;
using System.Collections.Generic;

namespace DatasulCompileGen.Core
{
    public class SearchOptions
    {
        public string RootDirectory { get; set; }
        public string SearchTerm { get; set; }
        public List<string> Extensions { get; set; }
        public HashSet<string> CompilableExtensions { get; set; }
        public bool CaseSensitive { get; set; }
        public bool WholeWord { get; set; }
        public bool IgnoreComments { get; set; }
        public bool TrackIncludes { get; set; }
        public int MaxIncludeDepth { get; set; }

        public SearchOptions()
        {
            RootDirectory = string.Empty;
            SearchTerm = string.Empty;
            Extensions = new List<string> { ".p", ".w", ".i", ".cls" };
            CompilableExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".p",
                ".w",
                ".cls"
            };
            CaseSensitive = false;
            WholeWord = false;
            IgnoreComments = false;
            TrackIncludes = true;
            MaxIncludeDepth = 10;
        }
    }

    public class LineMatch
    {
        public int LineNumber { get; set; }
        public int ColumnIndex { get; set; }
        public string LineText { get; set; }

        public LineMatch()
        {
            LineText = string.Empty;
        }
    }

    public class IncludeReference
    {
        public string RawReference { get; set; }
        public string NormalizedIncludePath { get; set; }
        public string IncludeFileName { get; set; }
        public int LineNumber { get; set; }
        public string LineText { get; set; }

        public IncludeReference()
        {
            RawReference = string.Empty;
            NormalizedIncludePath = string.Empty;
            IncludeFileName = string.Empty;
            LineText = string.Empty;
        }
    }

    public class IncludeChainStep
    {
        public string SourceIncludeFile { get; set; }
        public string TargetFile { get; set; }
        public int LineNumber { get; set; }
        public string LineText { get; set; }
        public string ChainDescription { get; set; }

        public IncludeChainStep()
        {
            SourceIncludeFile = string.Empty;
            TargetFile = string.Empty;
            LineText = string.Empty;
            ChainDescription = string.Empty;
        }
    }

    public class FileSearchResult
    {
        public string FilePath { get; set; }
        public string RelativePath { get; set; }
        public string Extension { get; set; }
        public bool IsCompilable { get; set; }
        public bool IsDirectMatch { get; set; }
        public bool IsIncludeMatch { get; set; }
        public bool SelectedForCompile { get; set; }
        public List<LineMatch> DirectMatches { get; set; }
        public List<IncludeChainStep> IncludeMatches { get; set; }

        public FileSearchResult()
        {
            FilePath = string.Empty;
            RelativePath = string.Empty;
            Extension = string.Empty;
            DirectMatches = new List<LineMatch>();
            IncludeMatches = new List<IncludeChainStep>();
        }

        public int TotalOccurrences
        {
            get { return DirectMatches.Count + IncludeMatches.Count; }
        }
    }

    public class SearchProgressInfo
    {
        public int ProcessedFiles { get; set; }
        public int TotalFiles { get; set; }
        public string CurrentFile { get; set; }
        public string PhaseMessage { get; set; }

        public SearchProgressInfo()
        {
            CurrentFile = string.Empty;
            PhaseMessage = string.Empty;
        }
    }

    public class SearchReport
    {
        public SearchOptions Options { get; set; }
        public List<FileSearchResult> AllResults { get; set; }
        public List<FileSearchResult> CompilableResults { get; set; }
        public int TotalFilesScanned { get; set; }
        public long ElapsedMilliseconds { get; set; }

        public SearchReport()
        {
            Options = new SearchOptions();
            AllResults = new List<FileSearchResult>();
            CompilableResults = new List<FileSearchResult>();
        }
    }
}
