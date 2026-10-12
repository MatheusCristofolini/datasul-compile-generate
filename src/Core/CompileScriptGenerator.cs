using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DatasulCompileGen.Core
{
    public enum CompilePathFormat
    {
        RelativeToRoot = 0,
        AbsolutePath = 1
    }

    public enum CompileScriptMode
    {
        WithErrorLog = 0,
        PureCompileSave = 1
    }

    public class CompileScriptOptions
    {
        public CompilePathFormat PathFormat { get; set; }
        public CompileScriptMode ScriptMode { get; set; }
        public bool UseForwardSlashes { get; set; }
        public string SearchTermUsed { get; set; }
        public string RootDirectory { get; set; }
        public string TargetScriptFilePath { get; set; }

        public CompileScriptOptions()
        {
            PathFormat = CompilePathFormat.RelativeToRoot;
            ScriptMode = CompileScriptMode.WithErrorLog;
            UseForwardSlashes = true;
            SearchTermUsed = string.Empty;
            RootDirectory = string.Empty;
            TargetScriptFilePath = string.Empty;
        }
    }

    public class CompileScriptGenerator
    {
        public string GenerateScript(IEnumerable<FileSearchResult> results, CompileScriptOptions options)
        {
            if (options == null)
            {
                options = new CompileScriptOptions();
            }

            List<FileSearchResult> selectedCompilables = new List<FileSearchResult>();
            if (results != null)
            {
                selectedCompilables = results
                    .Where(r => r != null && r.IsCompilable && r.SelectedForCompile)
                    .OrderBy(r => r.RelativePath, StringComparer.OrdinalIgnoreCase)
                    .ToList();
            }

            if (options.ScriptMode == CompileScriptMode.PureCompileSave)
            {
                return GeneratePureScript(selectedCompilables, options);
            }

            return GenerateErrorLogScript(selectedCompilables, options);
        }

        private string GeneratePureScript(List<FileSearchResult> selectedCompilables, CompileScriptOptions options)
        {
            StringBuilder sb = new StringBuilder();

            foreach (FileSearchResult item in selectedCompilables)
            {
                string progPath = FormatProgramPath(item, options);
                string token = progPath.Contains(" ") ? ("\"" + progPath + "\"") : progPath;
                sb.AppendFormat("COMPILE {0} SAVE.", token).AppendLine();
            }

            return sb.ToString();
        }

        private string GenerateErrorLogScript(List<FileSearchResult> selectedCompilables, CompileScriptOptions options)
        {
            StringBuilder sb = new StringBuilder();
            string defaultLogFileName = "compile-errors.log";
            string fallbackLogPath = defaultLogFileName;

            if (!string.IsNullOrWhiteSpace(options.TargetScriptFilePath))
            {
                try
                {
                    string fullTarget = Path.GetFullPath(options.TargetScriptFilePath);
                    string logPath = Path.ChangeExtension(fullTarget, ".log");
                    fallbackLogPath = logPath.Replace('\\', '/');
                    defaultLogFileName = Path.GetFileName(fallbackLogPath);
                }
                catch (Exception)
                {
                    fallbackLogPath = "compile-errors.log";
                }
            }

            sb.AppendLine("/*------------------------------------------------------------------------");
            sb.AppendLine("  Script de Compilacao Automatica - Progress Datasul");
            if (!string.IsNullOrWhiteSpace(options.SearchTermUsed))
            {
                sb.AppendFormat("  Termo pesquisado : {0}", options.SearchTermUsed).AppendLine();
            }
            if (!string.IsNullOrWhiteSpace(options.RootDirectory))
            {
                sb.AppendFormat("  Diretorio base   : {0}", options.RootDirectory).AppendLine();
            }
            sb.AppendFormat("  Total programas  : {0}", selectedCompilables.Count).AppendLine();
            sb.AppendFormat("  Gerado em        : {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")).AppendLine();
            sb.AppendLine("------------------------------------------------------------------------*/");
            sb.AppendLine();
            sb.AppendLine("DEFINE STREAM s-log.");
            sb.AppendLine("DEFINE VARIABLE c-arq-log   AS CHARACTER NO-UNDO.");
            sb.AppendLine("DEFINE VARIABLE c-dir-script AS CHARACTER NO-UNDO.");
            sb.AppendLine("DEFINE VARIABLE i-tot-erros AS INTEGER   NO-UNDO.");
            sb.AppendLine();
            sb.AppendLine("/* Resolve o caminho do .log no mesmo diretorio do script .p */");
            sb.AppendLine("ASSIGN FILE-INFO:FILE-NAME = THIS-PROCEDURE:FILE-NAME.");
            sb.AppendLine("IF FILE-INFO:FULL-PATHNAME <> ? AND INDEX(THIS-PROCEDURE:FILE-NAME, \".ped\") = 0 THEN DO:");
            sb.AppendLine("    ASSIGN c-dir-script = REPLACE(FILE-INFO:FULL-PATHNAME, \"\\\", \"/\").");
            sb.AppendLine("    IF R-INDEX(c-dir-script, \"/\") > 0 THEN");
            sb.AppendFormat("        ASSIGN c-arq-log = SUBSTRING(c-dir-script, 1, R-INDEX(c-dir-script, \"/\")) + \"{0}\".", EscapeProgressString(defaultLogFileName)).AppendLine();
            sb.AppendLine("    ELSE");
            sb.AppendFormat("        ASSIGN c-arq-log = \"{0}\".", EscapeProgressString(fallbackLogPath)).AppendLine();
            sb.AppendLine("END.");
            sb.AppendLine("ELSE DO:");
            sb.AppendFormat("    ASSIGN c-arq-log = \"{0}\".", EscapeProgressString(fallbackLogPath)).AppendLine();
            sb.AppendLine("END.");
            sb.AppendLine();
            sb.AppendLine("/* Remove arquivo de log anterior caso exista */");
            sb.AppendLine("OS-DELETE VALUE(c-arq-log) NO-ERROR.");
            sb.AppendLine();
            sb.AppendLine("/* Lista de programas para compilacao */");

            foreach (FileSearchResult item in selectedCompilables)
            {
                string progPath = FormatProgramPath(item, options);
                sb.AppendFormat("RUN pi-compilar (INPUT \"{0}\").", EscapeProgressString(progPath)).AppendLine();
            }

            sb.AppendLine();
            sb.AppendLine("/* Exibe alerta no final APENAS se ocorrerem erros de compilacao */");
            sb.AppendLine("IF i-tot-erros > 0 THEN DO:");
            sb.AppendLine("    MESSAGE \"Ocorreram erros durante a compilacao de \" + STRING(i-tot-erros) + \" programa(s).\" SKIP(1)");
            sb.AppendLine("            \"Verifique o arquivo de log gerado no diretorio do script:\" SKIP");
            sb.AppendLine("            c-arq-log");
            sb.AppendLine("        VIEW-AS ALERT-BOX ERROR BUTTONS OK TITLE \"Erros de Compilacao\".");
            sb.AppendLine("END.");
            sb.AppendLine();
            sb.AppendLine("RETURN.");
            sb.AppendLine();
            sb.AppendLine("/*------------------------------------------------------------------------");
            sb.AppendLine("  Procedure interna: Compila sem travar o editor e grava log apenas em erro");
            sb.AppendLine("------------------------------------------------------------------------*/");
            sb.AppendLine("PROCEDURE pi-compilar:");
            sb.AppendLine("    DEFINE INPUT PARAMETER p-cod-prog AS CHARACTER NO-UNDO.");
            sb.AppendLine("    DEFINE VARIABLE i-msg AS INTEGER NO-UNDO.");
            sb.AppendLine();
            sb.AppendLine("    COMPILE VALUE(p-cod-prog) SAVE NO-ERROR.");
            sb.AppendLine();
            sb.AppendLine("    IF COMPILER:ERROR OR ERROR-STATUS:ERROR THEN DO:");
            sb.AppendLine("        ASSIGN i-tot-erros = i-tot-erros + 1.");
            sb.AppendLine();
            sb.AppendLine("        OUTPUT STREAM s-log TO VALUE(c-arq-log) APPEND UNBUFFERED.");
            sb.AppendLine("        PUT STREAM s-log UNFORMATTED");
            sb.AppendLine("            \"======================================================================\" SKIP");
            sb.AppendLine("            \"PROGRAMA : \" p-cod-prog SKIP");
            sb.AppendLine("            \"DATA/HORA: \" STRING(TODAY, \"99/99/9999\") \" \" STRING(TIME, \"HH:MM:SS\") SKIP");
            sb.AppendLine("            \"LINHA/COL: Linha \" STRING(COMPILER:ERROR-ROW) \" / Coluna \" STRING(COMPILER:ERROR-COLUMN) SKIP.");
            sb.AppendLine();
            sb.AppendLine("        DO i-msg = 1 TO ERROR-STATUS:NUM-MESSAGES:");
            sb.AppendLine("            PUT STREAM s-log UNFORMATTED");
            sb.AppendLine("                \"  -> [\" STRING(ERROR-STATUS:GET-NUMBER(i-msg)) \"] \"");
            sb.AppendLine("                ERROR-STATUS:GET-MESSAGE(i-msg) SKIP.");
            sb.AppendLine("        END.");
            sb.AppendLine();
            sb.AppendLine("        PUT STREAM s-log UNFORMATTED SKIP.");
            sb.AppendLine("        OUTPUT STREAM s-log CLOSE.");
            sb.AppendLine("    END.");
            sb.AppendLine("END PROCEDURE.");

            return sb.ToString();
        }

        public string FormatProgramPath(FileSearchResult item, CompileScriptOptions options)
        {
            if (item == null)
            {
                return string.Empty;
            }

            string rawPath = (options != null && options.PathFormat == CompilePathFormat.AbsolutePath)
                ? item.FilePath
                : item.RelativePath;

            if (string.IsNullOrEmpty(rawPath))
            {
                rawPath = item.FilePath ?? string.Empty;
            }

            if (options == null || options.UseForwardSlashes)
            {
                return rawPath.Replace('\\', '/');
            }

            return rawPath.Replace('/', '\\');
        }

        public void SaveScriptToFile(string scriptContent, string targetFilePath)
        {
            if (string.IsNullOrWhiteSpace(targetFilePath))
            {
                throw new ArgumentException("O caminho do arquivo .p nao pode ser vazio.");
            }

            string dir = Path.GetDirectoryName(Path.GetFullPath(targetFilePath));
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Windows-1252 is standard for Progress Datasul Procedure Editor / AppBuilder on Windows
            Encoding encoding = Encoding.GetEncoding(1252);
            File.WriteAllText(targetFilePath, scriptContent ?? string.Empty, encoding);
        }

        private static string EscapeProgressString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return input.Replace("~", "~~").Replace("\"", "~\"");
        }
    }
}
