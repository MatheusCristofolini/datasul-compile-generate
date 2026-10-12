using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using DatasulCompileGen.Core;

namespace DatasulCompileGen.Tests
{
    public static class EndToEndVerifier
    {
        public static int Main(string[] args)
        {
            string tempDir = Path.Combine(Path.GetTempPath(), "DatasulCompileGen_E2ETest_" + Guid.NewGuid().ToString("N"));
            try
            {
                Console.WriteLine("=== Iniciando Verificacao End-to-End da Fase 4 ===");

                // 1. Verificar existencia do executavel portatil na raiz e em dist/
                string rootExe = Path.GetFullPath("DatasulCompileGen.exe");
                string distExe = Path.GetFullPath(@"dist\DatasulCompileGen.exe");

                Assert(File.Exists(rootExe), "DatasulCompileGen.exe nao encontrado na raiz: " + rootExe);
                Assert(File.Exists(distExe), "DatasulCompileGen.exe nao encontrado em dist: " + distExe);

                FileInfo exeInfo = new FileInfo(rootExe);
                Assert(exeInfo.Length > 10240, "Tamanho de DatasulCompileGen.exe invalido: " + exeInfo.Length);

                // 2. Criar ambiente simulado Datasul e rodar fluxo completo ate gerar os arquivos .p em disco
                string srcRoot = Path.Combine(tempDir, "fontes");
                string outScripts = Path.Combine(tempDir, "scripts");
                Directory.CreateDirectory(Path.Combine(srcRoot, "esp"));
                Directory.CreateDirectory(Path.Combine(srcRoot, "include"));
                Directory.CreateDirectory(outScripts);

                File.WriteAllText(
                    Path.Combine(srcRoot, "include", "es-teste-123.i"),
                    "/* Definicao da tabela es-teste-123 */\r\nFIND FIRST es-teste-123 NO-LOCK NO-ERROR.\r\n",
                    Encoding.GetEncoding(1252));

                File.WriteAllText(
                    Path.Combine(srcRoot, "esp", "es0100.p"),
                    "/* Programa que usa include */\r\n{include/es-teste-123.i}\r\n",
                    Encoding.GetEncoding(1252));

                File.WriteAllText(
                    Path.Combine(srcRoot, "esp", "es0200.w"),
                    "/* Programa com acesso direto */\r\nFOR EACH es-teste-123 NO-LOCK:\r\nEND.\r\n",
                    Encoding.GetEncoding(1252));

                ProgressSearchEngine engine = new ProgressSearchEngine();
                SearchOptions searchOpts = new SearchOptions
                {
                    RootDirectory = srcRoot,
                    SearchTerm = "es-teste-123",
                    TrackIncludes = true,
                    IgnoreComments = true
                };

                SearchReport report = engine.ExecuteSearch(searchOpts, null, CancellationToken.None);
                Assert(report.CompilableResults.Count == 2, "Deveriam ser encontrados 2 programas compilaveis (es0100.p e es0200.w).");

                CompileScriptGenerator generator = new CompileScriptGenerator();

                // Exportar script com log de erros
                string logScriptPath = Path.Combine(outScripts, "compila-es-teste-123.p");
                CompileScriptOptions logOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.WithErrorLog,
                    PathFormat = CompilePathFormat.RelativeToRoot,
                    SearchTermUsed = "es-teste-123",
                    RootDirectory = srcRoot,
                    TargetScriptFilePath = logScriptPath
                };

                string logScriptContent = generator.GenerateScript(report.CompilableResults, logOpts);
                generator.SaveScriptToFile(logScriptContent, logScriptPath);
                Assert(File.Exists(logScriptPath), "Arquivo compila-es-teste-123.p deveria ter sido gravado em disco.");

                string savedLogScript = File.ReadAllText(logScriptPath, Encoding.GetEncoding(1252));
                Assert(savedLogScript.Contains("RUN pi-compilar (INPUT \"esp/es0100.p\")."), "Script salvo deve compilar esp/es0100.p.");
                Assert(savedLogScript.Contains("RUN pi-compilar (INPUT \"esp/es0200.w\")."), "Script salvo deve compilar esp/es0200.w.");
                Assert(savedLogScript.Contains("compila-es-teste-123.log"), "Script salvo deve apontar o .log para o mesmo diretorio do script .p.");

                // Exportar script puro
                string pureScriptPath = Path.Combine(outScripts, "compila-puro.p");
                CompileScriptOptions pureOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.PureCompileSave,
                    PathFormat = CompilePathFormat.RelativeToRoot
                };

                string pureScriptContent = generator.GenerateScript(report.CompilableResults, pureOpts);
                generator.SaveScriptToFile(pureScriptContent, pureScriptPath);
                string savedPureScript = File.ReadAllText(pureScriptPath, Encoding.GetEncoding(1252));
                Assert(savedPureScript.Contains("COMPILE esp/es0100.p SAVE."), "Script puro deve conter COMPILE esp/es0100.p SAVE.");
                Assert(savedPureScript.Contains("COMPILE esp/es0200.w SAVE."), "Script puro deve conter COMPILE esp/es0200.w SAVE.");

                Console.WriteLine("  - Executavel portatil verificado: " + rootExe + " (" + exeInfo.Length + " bytes)");
                Console.WriteLine("  - Exportacao End-to-End de scripts .p (Com Log de Erros e Modo Puro): OK");
                Console.WriteLine("PHASE 4 END-TO-END VERIFICATION PASSED");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("PHASE 4 END-TO-END VERIFICATION FAILED: " + ex.Message);
                return 1;
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    try { Directory.Delete(tempDir, true); } catch { }
                }
            }
        }

        private static void Assert(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
