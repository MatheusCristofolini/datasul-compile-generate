using System;
using System.Collections.Generic;
using System.IO;
using DatasulCompileGen.Core;

namespace DatasulCompileGen.Tests
{
    public static class Phase2Verifier
    {
        public static int Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Iniciando Verificacao da Fase 2 (CompileScriptGenerator) ===");

                List<FileSearchResult> sampleResults = new List<FileSearchResult>
                {
                    new FileSearchResult
                    {
                        FilePath = @"C:\Totvs\Fontes\esp\es0001.p",
                        RelativePath = "esp/es0001.p",
                        Extension = ".p",
                        IsCompilable = true,
                        IsDirectMatch = true,
                        SelectedForCompile = true
                    },
                    new FileSearchResult
                    {
                        FilePath = @"C:\Totvs\Fontes\esp\es0002.w",
                        RelativePath = "esp/es0002.w",
                        Extension = ".w",
                        IsCompilable = true,
                        IsIncludeMatch = true,
                        SelectedForCompile = true
                    },
                    new FileSearchResult
                    {
                        FilePath = @"C:\Totvs\Fontes\esp\es0003-desmarcado.p",
                        RelativePath = "esp/es0003-desmarcado.p",
                        Extension = ".p",
                        IsCompilable = true,
                        IsDirectMatch = true,
                        SelectedForCompile = false
                    },
                    new FileSearchResult
                    {
                        FilePath = @"C:\Totvs\Fontes\include\es-def.i",
                        RelativePath = "include/es-def.i",
                        Extension = ".i",
                        IsCompilable = false,
                        IsDirectMatch = true,
                        SelectedForCompile = false
                    }
                };

                CompileScriptGenerator generator = new CompileScriptGenerator();

                // 1. Testar Modo Puro com Caminho Relativo
                CompileScriptOptions pureRelativeOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.PureCompileSave,
                    PathFormat = CompilePathFormat.RelativeToRoot,
                    UseForwardSlashes = true
                };

                string pureScript = generator.GenerateScript(sampleResults, pureRelativeOpts);
                Assert(pureScript.Contains("COMPILE esp/es0001.p SAVE."), "Modo Puro deveria conter COMPILE esp/es0001.p SAVE.");
                Assert(pureScript.Contains("COMPILE esp/es0002.w SAVE."), "Modo Puro deveria conter COMPILE esp/es0002.w SAVE.");
                Assert(!pureScript.Contains("es0003-desmarcado.p"), "Programa desmarcado nao deve entrar no script.");
                Assert(!pureScript.Contains("es-def.i"), "Include (.i) nao deve entrar no script.");

                // 2. Testar Modo Puro com Caminho Absoluto
                CompileScriptOptions pureAbsOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.PureCompileSave,
                    PathFormat = CompilePathFormat.AbsolutePath,
                    UseForwardSlashes = true
                };

                string pureAbsScript = generator.GenerateScript(sampleResults, pureAbsOpts);
                Assert(pureAbsScript.Contains("COMPILE C:/Totvs/Fontes/esp/es0001.p SAVE."),
                    "Modo Puro Absoluto deveria conter COMPILE C:/Totvs/Fontes/esp/es0001.p SAVE.");

                // 3. Testar Modo Com Log de Erros (WithErrorLog)
                CompileScriptOptions errorLogOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.WithErrorLog,
                    PathFormat = CompilePathFormat.RelativeToRoot,
                    SearchTermUsed = "es-teste-123",
                    RootDirectory = @"C:\Totvs\Fontes",
                    TargetScriptFilePath = @"C:\Scripts\compilar-es-teste.p"
                };

                string logScript = generator.GenerateScript(sampleResults, errorLogOpts);
                Assert(logScript.Contains("DEFINE STREAM s-log."), "Deve definir stream s-log.");
                Assert(logScript.Contains("C:/Scripts/compilar-es-teste.log"), "Deve configurar caminho do .log no mesmo diretorio do script .p.");
                Assert(logScript.Contains("RUN pi-compilar (INPUT \"esp/es0001.p\")."), "Deve chamar pi-compilar para esp/es0001.p.");
                Assert(logScript.Contains("RUN pi-compilar (INPUT \"esp/es0002.w\")."), "Deve chamar pi-compilar para esp/es0002.w.");
                Assert(!logScript.Contains("es0003-desmarcado.p"), "Nao deve incluir programa desmarcado.");
                Assert(logScript.Contains("COMPILE VALUE(p-cod-prog) SAVE NO-ERROR."), "Deve usar COMPILE VALUE(p-cod-prog) SAVE NO-ERROR.");
                Assert(logScript.Contains("IF COMPILER:ERROR OR ERROR-STATUS:ERROR THEN DO:"), "Deve verificar COMPILER:ERROR para logar apenas erros.");
                Assert(logScript.Contains("IF i-tot-erros > 0 THEN DO:"), "Deve exibir MESSAGE no final apenas se i-tot-erros > 0.");

                Console.WriteLine("  - Modo Puro (Relativo e Absoluto): OK");
                Console.WriteLine("  - Modo Com Log de Erros (NO-ERROR, apenas erros no .log do mesmo diretorio e MESSAGE condicional): OK");
                Console.WriteLine("PHASE 2 VERIFICATION PASSED");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("PHASE 2 VERIFICATION FAILED: " + ex.Message);
                return 1;
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
