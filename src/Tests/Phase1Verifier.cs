using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using DatasulCompileGen.Core;

namespace DatasulCompileGen.Tests
{
    public static class Phase1Verifier
    {
        public static int Main(string[] args)
        {
            string tempDir = Path.Combine(Path.GetTempPath(), "DatasulCompileGen_Phase1Test_" + Guid.NewGuid().ToString("N"));
            try
            {
                Console.WriteLine("=== Iniciando Verificacao da Fase 1 (Core Engine) ===");
                SetupMockDatasulDirectory(tempDir);

                ProgressSearchEngine engine = new ProgressSearchEngine();

                // Cenário 1: Busca padrão (IgnoreComments = false, TrackIncludes = true)
                SearchOptions opts1 = new SearchOptions();
                opts1.RootDirectory = tempDir;
                opts1.SearchTerm = "es-teste-123";
                opts1.IgnoreComments = false;
                opts1.TrackIncludes = true;

                SearchReport report1 = engine.ExecuteSearch(opts1, null, CancellationToken.None);

                Assert(report1.TotalFilesScanned == 8, "Total de arquivos varridos deveria ser 8, mas foi " + report1.TotalFilesScanned);

                // Com IgnoreComments = false, es-comentado.p deve aparecer
                Assert(report1.CompilableResults.Any(r => r.RelativePath == "esp/es-comentado.p"),
                    "Com IgnoreComments=false, esp/es-comentado.p deveria ser encontrado.");

                // Cenário 2: Busca com IgnoreComments = true e TrackIncludes = true
                SearchOptions opts2 = new SearchOptions();
                opts2.RootDirectory = tempDir;
                opts2.SearchTerm = "es-teste-123";
                opts2.IgnoreComments = true;
                opts2.TrackIncludes = true;
                opts2.WholeWord = true;

                SearchReport report2 = engine.ExecuteSearch(opts2, null, CancellationToken.None);

                // 1. Verificar exclusão de ocorrências apenas comentadas
                Assert(!report2.AllResults.Any(r => r.RelativePath == "esp/es-comentado.p"),
                    "Com IgnoreComments=true, esp/es-comentado.p NAO deveria aparecer nos resultados.");

                // 2. Verificar match direto em esp/es0001.p (linhas 4 e 5)
                FileSearchResult es0001 = report2.CompilableResults.FirstOrDefault(r => r.RelativePath == "esp/es0001.p");
                Assert(es0001 != null && es0001.IsDirectMatch && es0001.DirectMatches.Count == 2,
                    "esp/es0001.p deveria ter 2 matches diretos (linhas 4 e 5).");
                Assert(es0001.DirectMatches[0].LineNumber == 4 && es0001.DirectMatches[1].LineNumber == 5,
                    "Matches em esp/es0001.p deveriam estar nas linhas 4 e 5.");

                // 3. Verificar rastreamento multinível (.i -> .i -> .w) em esp/es0002.w
                FileSearchResult es0002 = report2.CompilableResults.FirstOrDefault(r => r.RelativePath == "esp/es0002.w");
                Assert(es0002 != null && es0002.IsIncludeMatch && !es0002.IsDirectMatch,
                    "esp/es0002.w deveria ser encontrado via rastreamento recursivo de include.");
                Assert(es0002.IncludeMatches.Any(m => m.ChainDescription.Contains("include/es-nivel1.i -> include/es-nivel2.i -> esp/es0002.w")),
                    "Cadeia de includes de esp/es0002.w incorreta.");

                // 4. Verificar classe .cls que inclui {es-nivel1.i &modo="calc"}
                FileSearchResult clsCalc = report2.CompilableResults.FirstOrDefault(r => r.RelativePath == "cls/CalculoImposto.cls");
                Assert(clsCalc != null && clsCalc.IsCompilable && clsCalc.IsIncludeMatch,
                    "cls/CalculoImposto.cls deveria ser compilavel e rastreado via include.");

                // 5. Verificar que arquivos .i NÃO estão na lista de CompilableResults
                Assert(!report2.CompilableResults.Any(r => r.Extension.Equals(".i", StringComparison.OrdinalIgnoreCase)),
                    "Nenhum arquivo .i pode estar em CompilableResults.");

                // 6. Verificar que exatamente 3 programas compiláveis foram selecionados (es0001.p, es0002.w, CalculoImposto.cls)
                Assert(report2.CompilableResults.Count == 3,
                    "Deveriam existir exatamente 3 compilaveis com IgnoreComments=true, mas foram encontrados " + report2.CompilableResults.Count);

                Console.WriteLine("  - Arquivos varridos: " + report2.TotalFilesScanned);
                Console.WriteLine("  - Total de arquivos impactados (diretos + includes): " + report2.AllResults.Count);
                Console.WriteLine("  - Programas compilaveis identificados (.p, .w, .cls): " + report2.CompilableResults.Count);
                foreach (FileSearchResult comp in report2.CompilableResults)
                {
                    string origin = comp.IsDirectMatch ? "Direto" : ("Via Include: " + comp.IncludeMatches[0].ChainDescription);
                    Console.WriteLine("    [x] " + comp.RelativePath + " (" + origin + ")");
                }

                Console.WriteLine("PHASE 1 VERIFICATION PASSED");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("PHASE 1 VERIFICATION FAILED: " + ex.Message);
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

        private static void SetupMockDatasulDirectory(string root)
        {
            string espDir = Path.Combine(root, "esp");
            string incDir = Path.Combine(root, "include");
            string clsDir = Path.Combine(root, "cls");

            Directory.CreateDirectory(espDir);
            Directory.CreateDirectory(incDir);
            Directory.CreateDirectory(clsDir);

            // 1. esp/es0001.p (Match direto + texto acentuado em Windows-1252)
            File.WriteAllText(
                Path.Combine(espDir, "es0001.p"),
                "/* Programa de Atualização de Pedidos */\r\n" +
                "DEF VAR c-msg AS CHAR NO-UNDO.\r\n" +
                "/* Comentario falso: es-teste-123 */\r\n" +
                "FOR EACH es-teste-123 NO-LOCK:\r\n" +
                "    DISP es-teste-123.cod-item.\r\n" +
                "END.\r\n",
                Encoding.GetEncoding(1252));

            // 2. include/es-nivel1.i (Contém a tabela es-teste-123)
            File.WriteAllText(
                Path.Combine(incDir, "es-nivel1.i"),
                "/* Definicao compartilhada */\r\n" +
                "FIND FIRST es-teste-123 WHERE es-teste-123.cod-estabel = '101' NO-LOCK NO-ERROR.\r\n",
                Encoding.UTF8);

            // 3. include/es-nivel2.i (Inclui es-nivel1.i)
            File.WriteAllText(
                Path.Combine(incDir, "es-nivel2.i"),
                "/* Include intermediaria */\r\n" +
                "{include/es-nivel1.i}\r\n",
                Encoding.UTF8);

            // 4. esp/es0002.w (Inclui es-nivel2.i, logo depende indiretamente de es-nivel1.i)
            File.WriteAllText(
                Path.Combine(espDir, "es0002.w"),
                "&ANALYZE-SUSPEND _VERSION-NUMBER UIB_v8r12 GUI\r\n" +
                "/* Janela de Consulta */\r\n" +
                "{include/es-nivel2.i}\r\n" +
                "/* {include/inexistente.i} comentada nao deve afetar */\r\n",
                Encoding.UTF8);

            // 5. cls/CalculoImposto.cls (Inclui es-nivel1.i passando parâmetros de pré-processador)
            File.WriteAllText(
                Path.Combine(clsDir, "CalculoImposto.cls"),
                "CLASS cls.CalculoImposto:\r\n" +
                "    METHOD PUBLIC VOID Calcular():\r\n" +
                "        {es-nivel1.i &modo=\"calc\"}\r\n" +
                "    END METHOD.\r\n" +
                "END CLASS.\r\n",
                Encoding.UTF8);

            // 6 & 7. Includes em loop circular (loop-a.i <-> loop-b.i) para testar proteção contra ciclo infinito
            File.WriteAllText(
                Path.Combine(incDir, "loop-a.i"),
                "DEF TEMP-TABLE tt-loop LIKE es-teste-123.\r\n" +
                "{include/loop-b.i}\r\n",
                Encoding.UTF8);

            File.WriteAllText(
                Path.Combine(incDir, "loop-b.i"),
                "{include/loop-a.i}\r\n",
                Encoding.UTF8);

            // 8 (Extra). esp/es-comentado.p (Apenas comentado, incluindo comentário aninhado Progress)
            File.WriteAllText(
                Path.Combine(espDir, "es-comentado.p"),
                "/* Bloco externo /* aninhado com es-teste-123 */ ainda comentado es-teste-123 */\r\n" +
                "// Linha comentada com es-teste-123\r\n" +
                "MESSAGE 'Programa sem uso ativo da tabela' VIEW-AS ALERT-BOX.\r\n",
                Encoding.UTF8);
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
