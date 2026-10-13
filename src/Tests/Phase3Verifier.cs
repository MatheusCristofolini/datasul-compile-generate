using System;
using System.IO;
using System.Text;
using System.Threading;
using DatasulCompileGen.Core;
using DatasulCompileGen.UI;

namespace DatasulCompileGen.Tests
{
    public static class Phase3Verifier
    {
        public static int Main(string[] args)
        {
            int exitCode = 1;
            Exception capturedException = null;

            Thread staThread = new Thread(() =>
            {
                string tempDir = Path.Combine(Path.GetTempPath(), "DatasulCompileGen_Phase3Test_" + Guid.NewGuid().ToString("N"));
                try
                {
                    Console.WriteLine("=== Iniciando Verificacao da Interface WPF (UI/UX Pro Max) ===");
                    Directory.CreateDirectory(Path.Combine(tempDir, "esp"));
                    Directory.CreateDirectory(Path.Combine(tempDir, "include"));

                    File.WriteAllText(
                        Path.Combine(tempDir, "include", "es-tabela.i"),
                        "FIND FIRST es-teste-123 NO-LOCK NO-ERROR.\r\n",
                        Encoding.UTF8);

                    File.WriteAllText(
                        Path.Combine(tempDir, "esp", "es0010.p"),
                        "{include/es-tabela.i}\r\n",
                        Encoding.UTF8);

                    File.WriteAllText(
                        Path.Combine(tempDir, "esp", "es0020.w"),
                        "FOR EACH es-teste-123 NO-LOCK:\r\nEND.\r\n",
                        Encoding.UTF8);

                    ProgressSearchEngine engine = new ProgressSearchEngine();
                    SearchOptions opts = new SearchOptions
                    {
                        RootDirectory = tempDir,
                        SearchTerm = "es-teste-123",
                        TrackIncludes = true,
                        IgnoreComments = true
                    };

                    SearchReport report = engine.ExecuteSearch(opts, null, CancellationToken.None);

                    string tempCacheFile = Path.Combine(tempDir, "test-cache.cfg");
                    MainForm form = new MainForm(new AppCacheService(tempCacheFile));
                    try
                    {
                        Assert(form.GetPathFormatIndex() == 1,
                            "A opcao de Caminho Absoluto Completo (index 1) deve vir marcada por padrao.");

                        form.LoadReportIntoUI(report);

                        Assert(form.GetCompilableListViewCount() == 2,
                            "Lista de compilaveis deveria ter 2 cards (es0010.p e es0020.w), mas teve " + form.GetCompilableListViewCount());

                        Assert(form.GetTreeNodesCount() == 3,
                            "Arvore estilo VS Code deveria ter 3 arquivos (2 compilaveis + 1 include), mas teve " + form.GetTreeNodesCount());

                        // Modo padrao: Com Log de Erros no SESSION:TEMP-DIRECTORY + Caminho Absoluto Completo
                        string expectedAbs10 = Path.Combine(tempDir, "esp", "es0010.p").Replace('\\', '/');
                        string previewLogMode = form.GetGeneratedScriptPreviewText();
                        Assert(previewLogMode.Contains("SESSION:TEMP-DIRECTORY"),
                            "Preview no modo Log de Erros deveria gravar o log em SESSION:TEMP-DIRECTORY.");
                        Assert(previewLogMode.Contains("RUN pi-compilar (INPUT \"" + expectedAbs10 + "\")."),
                            "Preview padrao deveria apresentar o caminho absoluto para es0010.p.");
                        Assert(previewLogMode.Contains("COMPILE VALUE(p-cod-prog) SAVE NO-ERROR."),
                            "Preview no modo Log de Erros deveria conter COMPILE VALUE(p-cod-prog) SAVE NO-ERROR.");

                        // Alternar para Modo Puro + Caminho Relativo via pills segmentados
                        form.SetPathFormatIndex(0);
                        form.SetScriptModeIndex(1);
                        string previewPureMode = form.GetGeneratedScriptPreviewText();
                        Assert(previewPureMode.Contains("COMPILE esp/es0010.p SAVE."),
                            "Preview no Modo Puro Relativo deveria conter COMPILE esp/es0010.p SAVE.");
                        Assert(previewPureMode.Contains("COMPILE esp/es0020.w SAVE."),
                            "Preview no Modo Puro Relativo deveria conter COMPILE esp/es0020.w SAVE.");

                        // Verificacao do Localizador In-Editor (Ctrl+F) na visualizacao de codigo
                        Assert(!form.IsEditorFindVisible(), "A barra de localizacao deve iniciar oculta.");
                        form.OpenEditorFind();
                        Assert(form.IsEditorFindVisible(), "A barra de localizacao deve ficar visivel ao abrir.");

                        form.SetEditorFindText("es-teste-123");
                        Assert(form.GetEditorFindMatchesCount() == 1,
                            "Deveria encontrar 1 ocorrencia de 'es-teste-123' no editor de codigo ativo, mas encontrou " + form.GetEditorFindMatchesCount());
                        Assert(form.GetCurrentFindIndex() == 0,
                            "Indice da ocorrencia atual deveria ser 0, mas foi " + form.GetCurrentFindIndex());

                        form.SetEditorFindText("termo-inexistente-xyz");
                        Assert(form.GetEditorFindMatchesCount() == 0,
                            "Nao deveria encontrar nenhuma ocorrencia para termo inexistente.");

                        form.CloseEditorFind();
                        Assert(!form.IsEditorFindVisible(), "A barra de localizacao deve ficar oculta apos fechar.");

                        // Verificacao do Localizador In-Editor (Ctrl+F) na aba de script .p
                        form.SwitchRightTab(false);
                        form.OpenEditorFind();
                        Assert(form.IsEditorFindVisible(), "A barra de localizacao deve ficar visivel na aba de script.");

                        form.SetEditorFindText("COMPILE");
                        Assert(form.GetEditorFindMatchesCount() >= 2,
                            "Deveria encontrar ao menos 2 ocorrencias de COMPILE no script .p gerado, mas encontrou " + form.GetEditorFindMatchesCount());
                        Assert(form.GetCurrentFindIndex() == 0, "O indice inicial da busca deve ser 0.");

                        form.TriggerFindNext();
                        Assert(form.GetCurrentFindIndex() == 1, "Apos TriggerFindNext, o indice deveria ser 1.");

                        form.TriggerFindPrevious();
                        Assert(form.GetCurrentFindIndex() == 0, "Apos TriggerFindPrevious, o indice deveria voltar a 0.");

                        form.CloseEditorFind();
                        Assert(!form.IsEditorFindVisible(), "A barra de localizacao deve ficar oculta apos fechar na aba de script.");
                    }
                    finally
                    {
                        form.Close();
                    }

                    Console.WriteLine("  - Renderizacao dos Cards de Programas Compilaveis + Badges (DIRETO / VIA INCLUDE .I): OK");
                    Console.WriteLine("  - Renderizacao da Arvore de Ocorrencias Estilo VS Code: OK");
                    Console.WriteLine("  - Seletores Segmentados (Pills) e Preview Ao Vivo do Script .p: OK");
                    Console.WriteLine("  - Localizador In-Editor (Ctrl+F), Destaques e Navegacao Proxima/Anterior: OK");
                    Console.WriteLine("PHASE 5 WPF UI/UX PRO MAX VERIFICATION PASSED");
                    exitCode = 0;
                }
                catch (Exception ex)
                {
                    capturedException = ex;
                    exitCode = 1;
                }
                finally
                {
                    if (Directory.Exists(tempDir))
                    {
                        try { Directory.Delete(tempDir, true); } catch { }
                    }
                }
            });

            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join();

            if (capturedException != null)
            {
                Console.Error.WriteLine("VERIFICATION FAILED: " + capturedException.Message);
            }

            return exitCode;
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
