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

                // 3. Testar Padrao de CompileScriptOptions (Caminho Absoluto marcado por padrao)
                CompileScriptOptions defaultOpts = new CompileScriptOptions();
                Assert(defaultOpts.PathFormat == CompilePathFormat.AbsolutePath,
                    "CompileScriptOptions deve vir com PathFormat = AbsolutePath por padrao.");

                // 4. Testar Modo Com Log de Erros no SESSION:TEMP-DIRECTORY
                CompileScriptOptions errorLogOpts = new CompileScriptOptions
                {
                    ScriptMode = CompileScriptMode.WithErrorLog,
                    PathFormat = CompilePathFormat.AbsolutePath,
                    SearchTermUsed = "es-teste-123",
                    RootDirectory = @"C:\Totvs\Fontes",
                    TargetScriptFilePath = @"C:\Scripts\compilar-es-teste.p"
                };

                string logScript = generator.GenerateScript(sampleResults, errorLogOpts);
                Assert(logScript.Contains("DEFINE STREAM s-log."), "Deve definir stream s-log.");
                Assert(logScript.Contains("SESSION:TEMP-DIRECTORY"), "Deve configurar caminho do .log no SESSION:TEMP-DIRECTORY.");
                Assert(logScript.Contains("compilar-es-teste.log"), "Deve usar o nome do arquivo .log em SESSION:TEMP-DIRECTORY.");
                Assert(logScript.Contains("RUN pi-compilar (INPUT \"C:/Totvs/Fontes/esp/es0001.p\")."), "Deve chamar pi-compilar com caminho absoluto para esp/es0001.p.");
                Assert(logScript.Contains("RUN pi-compilar (INPUT \"C:/Totvs/Fontes/esp/es0002.w\")."), "Deve chamar pi-compilar com caminho absoluto para esp/es0002.w.");
                Assert(!logScript.Contains("es0003-desmarcado.p"), "Nao deve incluir programa desmarcado.");
                Assert(logScript.Contains("COMPILE VALUE(p-cod-prog) SAVE NO-ERROR."), "Deve usar COMPILE VALUE(p-cod-prog) SAVE NO-ERROR.");
                Assert(logScript.Contains("IF COMPILER:ERROR OR ERROR-STATUS:ERROR THEN DO:"), "Deve verificar COMPILER:ERROR para logar apenas erros.");
                Assert(logScript.Contains("IF i-tot-erros > 0 THEN DO:"), "Deve exibir MESSAGE no final apenas se i-tot-erros > 0.");

                // 5. Testar AppCacheService (Persistencia de configuracoes, diretorios e termos recentes)
                string tempCacheFile = Path.Combine(Path.GetTempPath(), "DatasulCompileGen_CacheTest_" + Guid.NewGuid().ToString("N") + ".cfg");
                try
                {
                    AppCacheService cacheSvc = new AppCacheService(tempCacheFile);
                    AppCacheData initial = cacheSvc.Load();
                    Assert(initial.PathFormatIndex == 1, "Cache inicial deve vir com PathFormatIndex = 1 (Caminho Absoluto) marcado.");

                    initial.LastRootDirectory = @"D:\totvs\datasul\dts11\ERP\Espec";
                    initial.LastSearchTerm = "es_politica_tipo_carga";
                    initial.WholeWord = true;
                    AppCacheService.AddRecentDirectory(initial, @"D:\totvs\datasul\dts11\ERP\Espec");
                    AppCacheService.AddRecentSearchTerm(initial, "es_politica_tipo_carga");
                    AppCacheService.AddRecentSearchTerm(initial, "es-teste-123");
                    cacheSvc.Save(initial);

                    AppCacheData reloaded = cacheSvc.Load();
                    Assert(reloaded.LastRootDirectory == @"D:\totvs\datasul\dts11\ERP\Espec", "Deve restaurar LastRootDirectory do cache.");
                    Assert(reloaded.LastSearchTerm == "es_politica_tipo_carga", "Deve restaurar LastSearchTerm do cache.");
                    Assert(reloaded.WholeWord == true, "Deve restaurar WholeWord do cache.");
                    Assert(reloaded.RecentDirectories.Count == 1 && reloaded.RecentDirectories[0] == @"D:\totvs\datasul\dts11\ERP\Espec",
                        "Deve restaurar lista de RecentDirectories do cache.");
                    Assert(reloaded.RecentSearchTerms.Count == 2 && reloaded.RecentSearchTerms[0] == "es-teste-123",
                        "Deve restaurar lista de RecentSearchTerms na ordem mais recente.");
                }
                finally
                {
                    if (File.Exists(tempCacheFile))
                    {
                        try { File.Delete(tempCacheFile); } catch { }
                    }
                }

                Console.WriteLine("  - Modo Puro (Relativo e Absoluto): OK");
                Console.WriteLine("  - Modo Com Log de Erros em SESSION:TEMP-DIRECTORY e Caminho Absoluto por padrao: OK");
                Console.WriteLine("  - Persistencia em Cache (AppCacheService): OK");
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
