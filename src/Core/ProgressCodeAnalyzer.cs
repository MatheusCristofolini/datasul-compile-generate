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
                    int closeBrace = line.IndexOf('}', openBrace + 1);
                    int endIndex = closeBrace >= 0 ? closeBrace : line.Length;
                    string inside = line.Substring(openBrace + 1, endIndex - openBrace - 1).Trim();

                    if (inside.Length > 0 && inside[0] != '&')
                    {
                        string firstToken = ExtractFirstToken(inside);
                        if (!string.IsNullOrEmpty(firstToken) && EndsWithIncludeExtension(firstToken))
                        {
                            string normalized = NormalizePath(firstToken);
                            string fileName = Path.GetFileName(normalized);
                            if (!string.IsNullOrEmpty(fileName))
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
                    return trimmed.Substring(1, endQuote - 1).Trim();
                }
            }

            int spaceIdx = 0;
            while (spaceIdx < trimmed.Length && !char.IsWhiteSpace(trimmed[spaceIdx]))
            {
                spaceIdx++;
            }

            return trimmed.Substring(0, spaceIdx).Trim('"', '\'');
        }

        private static bool EndsWithIncludeExtension(string token)
        {
            return token.EndsWith(".i", StringComparison.OrdinalIgnoreCase);
        }

        public static string NormalizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }
            string p = path.Trim().Replace('\\', '/');
            while (p.StartsWith("./"))
            {
                p = p.Substring(2);
            }
            return p.TrimStart('/');
        }
    }
}
