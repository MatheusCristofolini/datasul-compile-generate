using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DatasulCompileGen.Core
{
    public static class ProgressCodeAnalyzer
    {
        private static readonly UTF8Encoding StrictUtf8 = new UTF8Encoding(false, true);
        private static readonly Encoding Windows1252 = Encoding.GetEncoding(1252);

        /// <summary>
        /// Reads a Progress source file, automatically detecting UTF-8 or falling back to Windows-1252 (ANSI).
        /// </summary>
        public static string ReadFileWithAutoEncoding(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            if (bytes.Length == 0)
            {
                return string.Empty;
            }

            // Check UTF-8 BOM
            if (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
            {
                return Encoding.UTF8.GetString(bytes, 3, bytes.Length - 3);
            }

            try
            {
                return StrictUtf8.GetString(bytes);
            }
            catch (DecoderFallbackException)
            {
                return Windows1252.GetString(bytes);
            }
        }

        /// <summary>
        /// Replaces Progress block comments /* ... */ (supporting nested comments) and single-line // comments
        /// with spaces while preserving all line breaks (\r and \n) so line and column numbers stay accurate.
        /// </summary>
        public static string StripCommentsPreservingLines(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return string.Empty;
            }

            char[] buffer = content.ToCharArray();
            int length = buffer.Length;
            int blockCommentDepth = 0;
            bool inSingleLineComment = false;
            bool inDoubleQuote = false;
            bool inSingleQuote = false;

            for (int i = 0; i < length; i++)
            {
                char c = buffer[i];
                char next = (i + 1 < length) ? buffer[i + 1] : '\0';

                if (c == '\r' || c == '\n')
                {
                    if (inSingleLineComment)
                    {
                        inSingleLineComment = false;
                    }
                    inDoubleQuote = false;
                    inSingleQuote = false;
                    continue;
                }

                if (inSingleLineComment)
                {
                    buffer[i] = ' ';
                    continue;
                }

                if (blockCommentDepth > 0)
                {
                    if (c == '/' && next == '*')
                    {
                        blockCommentDepth++;
                        buffer[i] = ' ';
                        buffer[i + 1] = ' ';
                        i++;
                        continue;
                    }
                    if (c == '*' && next == '/')
                    {
                        blockCommentDepth--;
                        buffer[i] = ' ';
                        buffer[i + 1] = ' ';
                        i++;
                        continue;
                    }
                    buffer[i] = ' ';
                    continue;
                }

                // Inside string literals
                if (inDoubleQuote)
                {
                    if (c == '~' && i + 1 < length)
                    {
                        i++;
                        continue;
                    }
                    if (c == '"')
                    {
                        if (next == '"')
                        {
                            i++;
                            continue;
                        }
                        inDoubleQuote = false;
                    }
                    continue;
                }

                if (inSingleQuote)
                {
                    if (c == '~' && i + 1 < length)
                    {
                        i++;
                        continue;
                    }
                    if (c == '\'')
                    {
                        if (next == '\'')
                        {
                            i++;
                            continue;
                        }
                        inSingleQuote = false;
                    }
                    continue;
                }

                // Check start of comment or string
                if (c == '/' && next == '*')
                {
                    blockCommentDepth = 1;
                    buffer[i] = ' ';
                    buffer[i + 1] = ' ';
                    i++;
                    continue;
                }

                if (c == '/' && next == '/')
                {
                    inSingleLineComment = true;
                    buffer[i] = ' ';
                    buffer[i + 1] = ' ';
                    i++;
                    continue;
                }

                if (c == '"')
                {
                    inDoubleQuote = true;
                    continue;
                }

                if (c == '\'')
                {
                    inSingleQuote = true;
                    continue;
                }
            }

            return new string(buffer);
        }

        /// <summary>
        /// Splits text into lines preserving 1-based indexing correspondence.
        /// </summary>
        public static string[] SplitLines(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return new string[0];
            }
            return content.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
        }

        /// <summary>
        /// Extracts Progress include references {path/to/file.i ...} from content.
        /// Always ignores commented-out include calls so dead code does not create false dependencies.
        /// </summary>
        public static List<IncludeReference> ExtractIncludeReferences(string originalContent, string strippedContent)
        {
            List<IncludeReference> results = new List<IncludeReference>();
            if (string.IsNullOrEmpty(originalContent))
            {
                return results;
            }

            string effectiveContent = string.IsNullOrEmpty(strippedContent)
                ? StripCommentsPreservingLines(originalContent)
                : strippedContent;

            string[] originalLines = SplitLines(originalContent);
            string[] cleanLines = SplitLines(effectiveContent);

            int lineCount = Math.Min(originalLines.Length, cleanLines.Length);
            for (int lineIdx = 0; lineIdx < lineCount; lineIdx++)
            {
                string line = cleanLines[lineIdx];
                int openBrace = line.IndexOf('{');
                while (openBrace >= 0)
                {
                    int closeBrace = FindMatchingCloseBrace(line, openBrace);
                    int endIndex = closeBrace >= 0 ? closeBrace : line.Length;
                    string inside = line.Substring(openBrace + 1, endIndex - openBrace - 1).Trim();

                    if (inside.Length > 0 && inside[0] != '&')
                    {
                        string firstToken = ExtractFirstToken(inside);
                        if (!string.IsNullOrEmpty(firstToken) && EndsWithIncludeExtension(firstToken))
                        {
                            string normalized = NormalizePath(firstToken);
                            string fileName = SafeGetFileName(normalized);
                            if (!string.IsNullOrEmpty(fileName) && EndsWithIncludeExtension(fileName))
                            {
                                IncludeReference includeRef = new IncludeReference();
                                includeRef.RawReference = inside;
                                includeRef.NormalizedIncludePath = normalized;
                                includeRef.IncludeFileName = fileName;
                                includeRef.LineNumber = lineIdx + 1;
                                includeRef.LineText = originalLines[lineIdx].Trim();
                                results.Add(includeRef);
                            }
                        }
                    }

                    openBrace = closeBrace >= 0 ? line.IndexOf('{', closeBrace + 1) : -1;
                }
            }

            return results;
        }

        private static int FindMatchingCloseBrace(string line, int openBraceIndex)
        {
            int depth = 0;
            for (int i = openBraceIndex; i < line.Length; i++)
            {
                if (line[i] == '{')
                {
                    depth++;
                }
                else if (line[i] == '}')
                {
                    depth--;
                    if (depth == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private static string ExtractFirstToken(string insideBrace)
        {
            string trimmed = insideBrace.Trim();
            if (trimmed.Length == 0)
            {
                return string.Empty;
            }

            if (trimmed[0] == '"' || trimmed[0] == '\'')
            {
                char quote = trimmed[0];
                int endQuote = trimmed.IndexOf(quote, 1);
                if (endQuote > 1)
                {
                    return SanitizeToken(trimmed.Substring(1, endQuote - 1));
                }
            }

            int spaceIdx = 0;
            while (spaceIdx < trimmed.Length && !char.IsWhiteSpace(trimmed[spaceIdx]))
            {
                spaceIdx++;
            }

            return SanitizeToken(trimmed.Substring(0, spaceIdx));
        }

        private static string SanitizeToken(string raw)
        {
            if (string.IsNullOrEmpty(raw))
            {
                return string.Empty;
            }

            // Remove preprocessors like {&var} if embedded and strip quotes/invalid chars
            StringBuilder sb = new StringBuilder(raw.Length);
            bool inNestedPreproc = false;
            for (int i = 0; i < raw.Length; i++)
            {
                char c = raw[i];
                if (c == '{')
                {
                    inNestedPreproc = true;
                    continue;
                }
                if (c == '}')
                {
                    inNestedPreproc = false;
                    continue;
                }
                if (inNestedPreproc)
                {
                    continue;
                }
                if (c == '"' || c == '\'' || c == '<' || c == '>' || c == '|' || c == '*' || c == '?' || c < 32)
                {
                    continue;
                }
                sb.Append(c);
            }

            return sb.ToString().Trim();
        }

        private static bool EndsWithIncludeExtension(string token)
        {
            return IsIncludeFile(token);
        }

        private static readonly HashSet<string> ExcludedNonProgressExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".pdf", ".pkg", ".ppt", ".pptx", ".pub", ".pages",
            ".png", ".psd", ".pic", ".pict",
            ".ico", ".img", ".iso", ".icns",
            ".wav", ".wasm", ".webp", ".woff", ".woff2", ".wma", ".wmv",
            ".ini", ".inf", ".info", ".properties", ".proto",
            ".py", ".pyc", ".pyd", ".pl", ".php", ".ps1", ".pem", ".p12", ".pfx",
            ".class", ".clj",
            ".win"
        };

        public static bool IsCompilableFile(string filePath, IEnumerable<string> compilableExtensions = null)
        {
            if (string.IsNullOrEmpty(filePath)) return false;

            string ext = SafeGetExtension(filePath);
            string extLower = (ext ?? string.Empty).ToLowerInvariant();
            if (!string.IsNullOrEmpty(extLower) && ExcludedNonProgressExtensions.Contains(extLower))
            {
                return false;
            }

            if (compilableExtensions != null)
            {
                foreach (string compExt in compilableExtensions)
                {
                    if (string.IsNullOrWhiteSpace(compExt)) continue;
                    string norm = compExt.Trim();
                    if (!norm.StartsWith(".")) norm = "." + norm;

                    if (norm.Equals(ext, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }

                    string normLower = norm.ToLowerInvariant();
                    if (normLower == ".p" || normLower == ".w" || normLower == ".cls")
                    {
                        if (MatchesBaseDerivative(filePath, extLower, normLower))
                        {
                            return true;
                        }
                    }
                }
            }

            return MatchesBaseDerivative(filePath, extLower, ".p")
                || MatchesBaseDerivative(filePath, extLower, ".w")
                || MatchesBaseDerivative(filePath, extLower, ".cls");
        }

        public static bool IsIncludeFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return false;

            string ext = SafeGetExtension(filePath);
            string extLower = (ext ?? string.Empty).ToLowerInvariant();
            if (!string.IsNullOrEmpty(extLower) && ExcludedNonProgressExtensions.Contains(extLower))
            {
                return false;
            }

            return MatchesBaseDerivative(filePath, extLower, ".i");
        }

        public static bool MatchesProgressFilter(string filePath, IEnumerable<string> allowedExtensions)
        {
            if (string.IsNullOrEmpty(filePath)) return false;

            string ext = SafeGetExtension(filePath);
            string extLower = (ext ?? string.Empty).ToLowerInvariant();
            if (!string.IsNullOrEmpty(extLower) && ExcludedNonProgressExtensions.Contains(extLower))
            {
                return false;
            }

            if (allowedExtensions == null)
            {
                return IsCompilableFile(filePath) || IsIncludeFile(filePath);
            }

            foreach (string rawExt in allowedExtensions)
            {
                if (string.IsNullOrWhiteSpace(rawExt)) continue;
                string norm = rawExt.Trim();
                if (!norm.StartsWith(".")) norm = "." + norm;

                if (norm.Equals(ext, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                string normLower = norm.ToLowerInvariant();
                if (normLower == ".p" || normLower == ".w" || normLower == ".cls")
                {
                    if (MatchesBaseDerivative(filePath, extLower, normLower))
                    {
                        return true;
                    }
                }
                else if (normLower == ".i")
                {
                    if (MatchesBaseDerivative(filePath, extLower, normLower))
                    {
                        return true;
                    }
                }
                else
                {
                    if (extLower.StartsWith(normLower))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool MatchesBaseDerivative(string filePath, string extLower, string baseExtLower)
        {
            if (string.IsNullOrEmpty(baseExtLower)) return false;

            if (!string.IsNullOrEmpty(extLower) && extLower.StartsWith(baseExtLower))
            {
                return true;
            }

            string fileNameLower = SafeGetFileName(filePath).ToLowerInvariant();
            if (fileNameLower.Contains(baseExtLower + "."))
            {
                return true;
            }

            return false;
        }

        public static string NormalizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }
            string p = SanitizeToken(path).Replace('\\', '/');
            while (p.StartsWith("./"))
            {
                p = p.Substring(2);
            }
            while (p.Contains("//"))
            {
                p = p.Replace("//", "/");
            }
            return p.TrimStart('/');
        }

        public static string SafeGetFileName(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }
            int lastSlash = path.LastIndexOf('/');
            int lastBackslash = path.LastIndexOf('\\');
            int cut = Math.Max(lastSlash, lastBackslash);
            string name = cut >= 0 ? path.Substring(cut + 1) : path;
            return SanitizeToken(name);
        }

        public static string SafeGetExtension(string path)
        {
            string fileName = SafeGetFileName(path);
            if (string.IsNullOrEmpty(fileName))
            {
                return string.Empty;
            }
            int lastDot = fileName.LastIndexOf('.');
            if (lastDot < 0)
            {
                return string.Empty;
            }
            return fileName.Substring(lastDot);
        }
    }
}
