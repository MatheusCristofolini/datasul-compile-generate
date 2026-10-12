using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DatasulCompileGen.Core
{
    public class AppCacheData
    {
        public string LastRootDirectory { get; set; }
        public string LastSearchTerm { get; set; }
        public string Extensions { get; set; }
        public bool TrackIncludes { get; set; }
        public bool IgnoreComments { get; set; }
        public bool WholeWord { get; set; }
        public bool CaseSensitive { get; set; }
        public int ScriptModeIndex { get; set; }
        public int PathFormatIndex { get; set; }
        public string FilterText { get; set; }
        public string LastExportDirectory { get; set; }
        public List<string> RecentDirectories { get; set; }
        public List<string> RecentSearchTerms { get; set; }

        public AppCacheData()
        {
            LastRootDirectory = string.Empty;
            LastSearchTerm = string.Empty;
            Extensions = ".p, .w, .i, .cls";
            TrackIncludes = true;
            IgnoreComments = true;
            WholeWord = false;
            CaseSensitive = false;
            ScriptModeIndex = 0; // 0 = WithErrorLog (SESSION:TEMP-DIRECTORY)
            PathFormatIndex = 1; // 1 = AbsolutePath (Marcado por padrão!)
            FilterText = string.Empty;
            LastExportDirectory = string.Empty;
            RecentDirectories = new List<string>();
            RecentSearchTerms = new List<string>();
        }
    }

    public class AppCacheService
    {
        private const int MaxRecentDirectories = 15;
        private const int MaxRecentSearchTerms = 25;
        private readonly string _cacheFilePath;

        public AppCacheService()
            : this(GetDefaultCacheFilePath())
        {
        }

        public AppCacheService(string customCacheFilePath)
        {
            _cacheFilePath = string.IsNullOrWhiteSpace(customCacheFilePath)
                ? GetDefaultCacheFilePath()
                : customCacheFilePath;
        }

        public string CacheFilePath
        {
            get { return _cacheFilePath; }
        }

        public static string GetDefaultCacheFilePath()
        {
            try
            {
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                if (!string.IsNullOrWhiteSpace(localAppData))
                {
                    string folder = Path.Combine(localAppData, "DatasulCompileGen");
                    return Path.Combine(folder, "user-cache.cfg");
                }
            }
            catch (Exception)
            {
            }

            return Path.Combine(Path.GetTempPath(), "DatasulCompileGen_user-cache.cfg");
        }

        public AppCacheData Load()
        {
            AppCacheData data = new AppCacheData();
            try
            {
                if (string.IsNullOrWhiteSpace(_cacheFilePath) || !File.Exists(_cacheFilePath))
                {
                    return data;
                }

                string[] lines = File.ReadAllLines(_cacheFilePath, Encoding.UTF8);
                foreach (string rawLine in lines)
                {
                    if (string.IsNullOrWhiteSpace(rawLine) || rawLine.StartsWith("#"))
                    {
                        continue;
                    }

                    int eqIndex = rawLine.IndexOf('=');
                    if (eqIndex <= 0)
                    {
                        continue;
                    }

                    string key = rawLine.Substring(0, eqIndex).Trim();
                    string val = UnescapeValue(rawLine.Substring(eqIndex + 1));

                    switch (key)
                    {
                        case "LastRootDirectory":
                            data.LastRootDirectory = val;
                            break;
                        case "LastSearchTerm":
                            data.LastSearchTerm = val;
                            break;
                        case "Extensions":
                            if (!string.IsNullOrWhiteSpace(val))
                            {
                                data.Extensions = val;
                            }
                            break;
                        case "TrackIncludes":
                            data.TrackIncludes = ParseBool(val, true);
                            break;
                        case "IgnoreComments":
                            data.IgnoreComments = ParseBool(val, true);
                            break;
                        case "WholeWord":
                            data.WholeWord = ParseBool(val, false);
                            break;
                        case "CaseSensitive":
                            data.CaseSensitive = ParseBool(val, false);
                            break;
                        case "ScriptModeIndex":
                            data.ScriptModeIndex = ParseInt(val, 0);
                            break;
                        case "PathFormatIndex":
                            data.PathFormatIndex = ParseInt(val, 1);
                            break;
                        case "FilterText":
                            data.FilterText = val;
                            break;
                        case "LastExportDirectory":
                            data.LastExportDirectory = val;
                            break;
                        case "RecentDir":
                            if (!string.IsNullOrWhiteSpace(val) &&
                                !data.RecentDirectories.Any(d => string.Equals(d, val, StringComparison.OrdinalIgnoreCase)))
                            {
                                data.RecentDirectories.Add(val);
                            }
                            break;
                        case "RecentTerm":
                            if (!string.IsNullOrWhiteSpace(val) &&
                                !data.RecentSearchTerms.Any(t => string.Equals(t, val, StringComparison.OrdinalIgnoreCase)))
                            {
                                data.RecentSearchTerms.Add(val);
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                // Retorna configuracoes padrao caso o arquivo de cache esteja inacessivel
            }

            return data;
        }

        public void Save(AppCacheData data)
        {
            if (data == null)
            {
                return;
            }

            try
            {
                string dir = Path.GetDirectoryName(_cacheFilePath);
                if (!string.IsNullOrWhiteSpace(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("# DatasulCompileGen - Cache de Configuracoes e Historico do Usuario");
                sb.AppendFormat("LastRootDirectory={0}", EscapeValue(data.LastRootDirectory)).AppendLine();
                sb.AppendFormat("LastSearchTerm={0}", EscapeValue(data.LastSearchTerm)).AppendLine();
                sb.AppendFormat("Extensions={0}", EscapeValue(data.Extensions)).AppendLine();
                sb.AppendFormat("TrackIncludes={0}", data.TrackIncludes ? "true" : "false").AppendLine();
                sb.AppendFormat("IgnoreComments={0}", data.IgnoreComments ? "true" : "false").AppendLine();
                sb.AppendFormat("WholeWord={0}", data.WholeWord ? "true" : "false").AppendLine();
                sb.AppendFormat("CaseSensitive={0}", data.CaseSensitive ? "true" : "false").AppendLine();
                sb.AppendFormat("ScriptModeIndex={0}", data.ScriptModeIndex).AppendLine();
                sb.AppendFormat("PathFormatIndex={0}", data.PathFormatIndex).AppendLine();
                sb.AppendFormat("FilterText={0}", EscapeValue(data.FilterText)).AppendLine();
                sb.AppendFormat("LastExportDirectory={0}", EscapeValue(data.LastExportDirectory)).AppendLine();

                if (data.RecentDirectories != null)
                {
                    foreach (string recentDir in data.RecentDirectories.Take(MaxRecentDirectories))
                    {
                        if (!string.IsNullOrWhiteSpace(recentDir))
                        {
                            sb.AppendFormat("RecentDir={0}", EscapeValue(recentDir)).AppendLine();
                        }
                    }
                }

                if (data.RecentSearchTerms != null)
                {
                    foreach (string recentTerm in data.RecentSearchTerms.Take(MaxRecentSearchTerms))
                    {
                        if (!string.IsNullOrWhiteSpace(recentTerm))
                        {
                            sb.AppendFormat("RecentTerm={0}", EscapeValue(recentTerm)).AppendLine();
                        }
                    }
                }

                File.WriteAllText(_cacheFilePath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception)
            {
                // Ignora falhas de I/O de cache para nao interromper o fluxo do usuario
            }
        }

        public static void AddRecentDirectory(AppCacheData data, string directory)
        {
            if (data == null || string.IsNullOrWhiteSpace(directory))
            {
                return;
            }

            string clean = directory.Trim().Trim('"', '\'');
            if (string.IsNullOrWhiteSpace(clean))
            {
                return;
            }

            data.RecentDirectories.RemoveAll(d => string.Equals(d, clean, StringComparison.OrdinalIgnoreCase));
            data.RecentDirectories.Insert(0, clean);
            if (data.RecentDirectories.Count > MaxRecentDirectories)
            {
                data.RecentDirectories.RemoveRange(MaxRecentDirectories, data.RecentDirectories.Count - MaxRecentDirectories);
            }
        }

        public static void AddRecentSearchTerm(AppCacheData data, string searchTerm)
        {
            if (data == null || string.IsNullOrWhiteSpace(searchTerm))
            {
                return;
            }

            string clean = searchTerm.Trim();
            if (string.IsNullOrWhiteSpace(clean))
            {
                return;
            }

            data.RecentSearchTerms.RemoveAll(t => string.Equals(t, clean, StringComparison.OrdinalIgnoreCase));
            data.RecentSearchTerms.Insert(0, clean);
            if (data.RecentSearchTerms.Count > MaxRecentSearchTerms)
            {
                data.RecentSearchTerms.RemoveRange(MaxRecentSearchTerms, data.RecentSearchTerms.Count - MaxRecentSearchTerms);
            }
        }

        private static string EscapeValue(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return input
                .Replace("\\", "\\\\")
                .Replace("\r", "\\r")
                .Replace("\n", "\\n");
        }

        private static string UnescapeValue(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '\\' && i + 1 < input.Length)
                {
                    char next = input[i + 1];
                    if (next == '\\')
                    {
                        sb.Append('\\');
                        i++;
                        continue;
                    }
                    if (next == 'r')
                    {
                        sb.Append('\r');
                        i++;
                        continue;
                    }
                    if (next == 'n')
                    {
                        sb.Append('\n');
                        i++;
                        continue;
                    }
                }
                sb.Append(c);
            }
            return sb.ToString();
        }

        private static bool ParseBool(string value, bool defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }
            if (string.Equals(value.Trim(), "true", StringComparison.OrdinalIgnoreCase) || value.Trim() == "1")
            {
                return true;
            }
            if (string.Equals(value.Trim(), "false", StringComparison.OrdinalIgnoreCase) || value.Trim() == "0")
            {
                return false;
            }
            return defaultValue;
        }

        private static int ParseInt(string value, int defaultValue)
        {
            int parsed;
            if (int.TryParse(value, out parsed))
            {
                return parsed;
            }
            return defaultValue;
        }
    }
}
