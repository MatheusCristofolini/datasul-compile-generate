using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatasulCompileGen.Core;

namespace DatasulCompileGen.UI
{
    public class MainForm : Form
    {
        // Paleta VS Code Dark+
        private static readonly Color BgDark = Color.FromArgb(30, 30, 30);
        private static readonly Color BgSidebar = Color.FromArgb(37, 37, 38);
        private static readonly Color BgHeader = Color.FromArgb(45, 45, 48);
        private static readonly Color BgInput = Color.FromArgb(60, 60, 60);
        private static readonly Color FgPrimary = Color.FromArgb(220, 220, 220);
        private static readonly Color FgMuted = Color.FromArgb(160, 160, 160);
        private static readonly Color AccentBlue = Color.FromArgb(0, 122, 204);
        private static readonly Color AccentGreen = Color.FromArgb(46, 160, 67);
        private static readonly Color HighlightLineBg = Color.FromArgb(38, 79, 120);
        private static readonly Color HighlightTermBg = Color.FromArgb(90, 70, 0);
        private static readonly Color HighlightTermFg = Color.FromArgb(255, 225, 100);

        // Controles Superiores de Busca
        private TextBox _txtRootDir;
        private Button _btnBrowseDir;
        private TextBox _txtSearchTerm;
        private TextBox _txtExtensions;
        private CheckBox _chkTrackIncludes;
        private CheckBox _chkIgnoreComments;
        private CheckBox _chkWholeWord;
        private CheckBox _chkCaseSensitive;
        private Button _btnSearch;
        private Button _btnCancel;
        private Button _btnQuickExport;

        // Painel Esquerdo (Resultados)
        private TabControl _tabLeft;
        private TabPage _tabCompilables;
        private TabPage _tabTreeSearch;
        private TextBox _txtFilterCompilables;
        private Button _btnSelectAll;
        private Button _btnUnselectAll;
        private Label _lblSelectedSummary;
        private ListView _lvCompilables;
        private TreeView _tvOccurrences;

        // Painel Direito (Preview de Código + Preview do Script .p)
        private TabControl _tabRight;
        private TabPage _tabCodePreview;
        private TabPage _tabScriptPreview;
        private Label _lblCodePreviewFile;
        private Button _btnOpenFolder;
        private RichTextBox _rtbCodePreview;

        // Controles de Geração do Script .p
        private ComboBox _cmbScriptMode;
        private ComboBox _cmbPathFormat;
        private Button _btnSaveScript;
        private Button _btnCopyScript;
        private RichTextBox _rtbScriptPreview;

        // Barra de Status
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _lblStatus;
        private ToolStripProgressBar _progressBar;

        // Estado Interno
        private readonly ProgressSearchEngine _searchEngine;
        private readonly CompileScriptGenerator _scriptGenerator;
        private CancellationTokenSource _cts;
        private SearchReport _currentReport;
        private bool _suppressItemCheck;
        private string _currentPreviewFilePath;

        private class TreeNodePayload
        {
            public FileSearchResult Result { get; set; }
            public int LineNumber { get; set; }
        }

        public MainForm()
        {
            _searchEngine = new ProgressSearchEngine();
            _scriptGenerator = new CompileScriptGenerator();
            _currentPreviewFilePath = string.Empty;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Datasul Search & Compile Script Generator - Progress 4GL / ABL";
            Size = new Size(1340, 820);
            MinimumSize = new Size(1024, 640);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = BgDark;
            ForeColor = FgPrimary;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // 1. Painel Superior (Configuração de Busca)
            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 116,
                BackColor = BgHeader,
                Padding = new Padding(12, 10, 12, 10)
            };

            Label lblDir = new Label
            {
                Text = "Diretório de Programas:",
                Location = new Point(12, 14),
                AutoSize = true,
                ForeColor = FgPrimary
            };

            _txtRootDir = new TextBox
            {
                Location = new Point(160, 11),
                Width = 490,
                BackColor = BgInput,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            _btnBrowseDir = CreateStyledButton("Procurar...", new Point(658, 9), new Size(95, 26), Color.FromArgb(62, 62, 66));
            _btnBrowseDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnBrowseDir.Click += OnBrowseDirectoryClick;

            Label lblExt = new Label
            {
                Text = "Extensões:",
                Location = new Point(768, 14),
                AutoSize = true,
                ForeColor = FgPrimary,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _txtExtensions = new TextBox
            {
                Text = ".p, .w, .i, .cls",
                Location = new Point(838, 11),
                Width = 140,
                BackColor = BgInput,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _btnQuickExport = CreateStyledButton("Salvar Script .p...", new Point(995, 9), new Size(315, 28), AccentGreen);
            _btnQuickExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnQuickExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnQuickExport.Click += OnSaveScriptClick;

            // Linha 2: Termo de Busca e Botões Buscar / Cancelar
            Label lblSearch = new Label
            {
                Text = "Palavra / Tabela Busca:",
                Location = new Point(12, 48),
                AutoSize = true,
                ForeColor = FgPrimary
            };

            _txtSearchTerm = new TextBox
            {
                Location = new Point(160, 45),
                Width = 490,
                BackColor = BgInput,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 10F, FontStyle.Regular),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            _txtSearchTerm.KeyDown += OnSearchTermKeyDown;

            _btnSearch = CreateStyledButton("Buscar Programas", new Point(658, 43), new Size(150, 28), AccentBlue);
            _btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnSearch.Click += OnSearchClick;

            _btnCancel = CreateStyledButton("Cancelar", new Point(816, 43), new Size(90, 28), Color.FromArgb(160, 50, 50));
            _btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnCancel.Enabled = false;
            _btnCancel.Click += OnCancelSearchClick;

            // Linha 3: Checkboxes de Opções Progress Datasul
            _chkTrackIncludes = new CheckBox
            {
                Text = "Rastrear Includes (.i -> .p, .w, .cls)",
                Location = new Point(160, 82),
                AutoSize = true,
                Checked = true,
                ForeColor = Color.FromArgb(120, 210, 255)
            };

            _chkIgnoreComments = new CheckBox
            {
                Text = "Ignorar Comentários (/* ... */ e //)",
                Location = new Point(410, 82),
                AutoSize = true,
                Checked = true,
                ForeColor = FgPrimary
            };

            _chkWholeWord = new CheckBox
            {
                Text = "Palavra Inteira",
                Location = new Point(655, 82),
                AutoSize = true,
                Checked = false,
                ForeColor = FgPrimary
            };

            _chkCaseSensitive = new CheckBox
            {
                Text = "Diferenciar Maiúsculas/Minúsculas",
                Location = new Point(780, 82),
                AutoSize = true,
                Checked = false,
                ForeColor = FgPrimary
            };

            topPanel.Controls.AddRange(new Control[]
            {
                lblDir, _txtRootDir, _btnBrowseDir, lblExt, _txtExtensions, _btnQuickExport,
                lblSearch, _txtSearchTerm, _btnSearch, _btnCancel,
                _chkTrackIncludes, _chkIgnoreComments, _chkWholeWord, _chkCaseSensitive
            });

            // 2. Barra de Status Inferior (Estilo VS Code)
            _statusStrip = new StatusStrip
            {
                BackColor = AccentBlue,
                ForeColor = Color.White,
                SizingGrip = true
            };

            _lblStatus = new ToolStripStatusLabel
            {
                Text = "Pronto. Selecione o diretório de programas e informe o termo de busca (ex: es-teste-123).",
                Spring = true,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };

            _progressBar = new ToolStripProgressBar
            {
                Size = new Size(200, 16),
                Visible = false
            };

            _statusStrip.Items.Add(_lblStatus);
            _statusStrip.Items.Add(_progressBar);

            // 3. Container Principal Dividido (Esquerda: Resultados | Direita: Preview Código & Script .p)
            SplitContainer splitMain = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 590,
                BackColor = BgHeader,
                SplitterWidth = 5
            };

            // Painel Esquerdo
            _tabLeft = new TabControl
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };

            _tabCompilables = new TabPage("Programas p/ Compilar (0)")
            {
                BackColor = BgSidebar,
                ForeColor = FgPrimary,
                Padding = new Padding(6)
            };

            Panel pnlCompActions = new Panel
            {
                Dock = DockStyle.Top,
                Height = 64,
                BackColor = BgSidebar
            };

            _btnSelectAll = CreateStyledButton("Marcar Todos", new Point(2, 4), new Size(105, 25), Color.FromArgb(55, 55, 60));
            _btnSelectAll.Click += (s, e) => SetAllCompilableChecks(true);

            _btnUnselectAll = CreateStyledButton("Desmarcar Todos", new Point(113, 4), new Size(120, 25), Color.FromArgb(55, 55, 60));
            _btnUnselectAll.Click += (s, e) => SetAllCompilableChecks(false);

            _lblSelectedSummary = new Label
            {
                Text = "0 selecionados para o script .p",
                Location = new Point(245, 9),
                AutoSize = true,
                ForeColor = Color.FromArgb(120, 210, 255),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            Label lblFilter = new Label
            {
                Text = "Filtrar lista:",
                Location = new Point(4, 37),
                AutoSize = true,
                ForeColor = FgMuted
            };

            _txtFilterCompilables = new TextBox
            {
                Location = new Point(78, 34),
                Width = 480,
                BackColor = BgInput,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            _txtFilterCompilables.TextChanged += (s, e) => PopulateCompilablesListView();

            pnlCompActions.Controls.AddRange(new Control[]
            {
                _btnSelectAll, _btnUnselectAll, _lblSelectedSummary, lblFilter, _txtFilterCompilables
            });

            _lvCompilables = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = false,
                BackColor = BgSidebar,
                ForeColor = FgPrimary,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 9.5F, FontStyle.Regular)
            };
            _lvCompilables.Columns.Add("Programa (PROPATH)", 240);
            _lvCompilables.Columns.Add("Origem", 115);
            _lvCompilables.Columns.Add("Ocorr.", 60);
            _lvCompilables.Columns.Add("Referência / Cadeia de Include", 260);
            _lvCompilables.ItemChecked += OnCompilableItemChecked;
            _lvCompilables.SelectedIndexChanged += OnCompilableSelectedIndexChanged;

            _tabCompilables.Controls.Add(_lvCompilables);
            _tabCompilables.Controls.Add(pnlCompActions);

            _tabTreeSearch = new TabPage("Ocorrências Estilo VS Code (0)")
            {
                BackColor = BgSidebar,
                ForeColor = FgPrimary,
                Padding = new Padding(6)
            };

            _tvOccurrences = new TreeView
            {
                Dock = DockStyle.Fill,
                BackColor = BgSidebar,
                ForeColor = FgPrimary,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 9.5F, FontStyle.Regular),
                HideSelection = false,
                ShowLines = true
            };
            _tvOccurrences.AfterSelect += OnTreeOccurrenceAfterSelect;
            _tabTreeSearch.Controls.Add(_tvOccurrences);

            _tabLeft.TabPages.Add(_tabCompilables);
            _tabLeft.TabPages.Add(_tabTreeSearch);
            splitMain.Panel1.Controls.Add(_tabLeft);

            // Painel Direito (Visualizador de Código & Script .p Gerado)
            _tabRight = new TabControl
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };

            _tabCodePreview = new TabPage("Visualizador de Código-Fonte")
            {
                BackColor = BgDark,
                ForeColor = FgPrimary,
                Padding = new Padding(6)
            };

            Panel pnlCodeHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 34,
                BackColor = BgHeader
            };

            _lblCodePreviewFile = new Label
            {
                Text = "Selecione um programa ou ocorrência à esquerda para inspecionar o código-fonte.",
                Location = new Point(8, 8),
                AutoSize = true,
                ForeColor = FgPrimary,
                Font = new Font("Consolas", 9.5F, FontStyle.Bold)
            };

            _btnOpenFolder = CreateStyledButton("Abrir na Pasta", new Point(560, 4), new Size(115, 25), Color.FromArgb(62, 62, 66));
            _btnOpenFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnOpenFolder.Enabled = false;
            _btnOpenFolder.Click += OnOpenFolderClick;

            pnlCodeHeader.Controls.Add(_lblCodePreviewFile);
            pnlCodeHeader.Controls.Add(_btnOpenFolder);

            _rtbCodePreview = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                WordWrap = false,
                BackColor = BgDark,
                ForeColor = FgPrimary,
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 10F, FontStyle.Regular),
                DetectUrls = false
            };

            _tabCodePreview.Controls.Add(_rtbCodePreview);
            _tabCodePreview.Controls.Add(pnlCodeHeader);

            _tabScriptPreview = new TabPage("Script .p de Compilação (Preview)")
            {
                BackColor = BgDark,
                ForeColor = FgPrimary,
                Padding = new Padding(6)
            };

            Panel pnlScriptOptions = new Panel
            {
                Dock = DockStyle.Top,
                Height = 72,
                BackColor = BgHeader,
                Padding = new Padding(8)
            };

            Label lblMode = new Label
            {
                Text = "Formato do Script .p:",
                Location = new Point(8, 10),
                AutoSize = true,
                ForeColor = FgPrimary
            };

            _cmbScriptMode = new ComboBox
            {
                Location = new Point(135, 7),
                Width = 365,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = BgInput,
                ForeColor = Color.White
            };
            _cmbScriptMode.Items.Add("Com Log de Erros (NO-ERROR + .log na pasta do script)");
            _cmbScriptMode.Items.Add("Modo Puro (Apenas 'COMPILE <programa> SAVE.')");
            _cmbScriptMode.SelectedIndex = 0;
            _cmbScriptMode.SelectedIndexChanged += (s, e) => RefreshScriptPreview();

            Label lblPathFmt = new Label
            {
                Text = "Caminho no COMPILE:",
                Location = new Point(8, 41),
                AutoSize = true,
                ForeColor = FgPrimary
            };

            _cmbPathFormat = new ComboBox
            {
                Location = new Point(135, 38),
                Width = 365,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = BgInput,
                ForeColor = Color.White
            };
            _cmbPathFormat.Items.Add("Caminho Relativo à Raiz (Padrão PROPATH: esp/prog.p)");
            _cmbPathFormat.Items.Add("Caminho Absoluto Completo (C:/.../esp/prog.p)");
            _cmbPathFormat.SelectedIndex = 0;
            _cmbPathFormat.SelectedIndexChanged += (s, e) => RefreshScriptPreview();

            _btnSaveScript = CreateStyledButton("Salvar Arquivo .p...", new Point(512, 7), new Size(165, 28), AccentGreen);
            _btnSaveScript.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnSaveScript.Click += OnSaveScriptClick;

            _btnCopyScript = CreateStyledButton("Copiar Código .p", new Point(512, 38), new Size(165, 27), AccentBlue);
            _btnCopyScript.Click += OnCopyScriptClick;

            pnlScriptOptions.Controls.AddRange(new Control[]
            {
                lblMode, _cmbScriptMode, lblPathFmt, _cmbPathFormat, _btnSaveScript, _btnCopyScript
            });

            _rtbScriptPreview = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                WordWrap = false,
                BackColor = BgDark,
                ForeColor = Color.FromArgb(180, 230, 180),
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 10F, FontStyle.Regular),
                DetectUrls = false
            };

            _tabScriptPreview.Controls.Add(_rtbScriptPreview);
            _tabScriptPreview.Controls.Add(pnlScriptOptions);

            _tabRight.TabPages.Add(_tabCodePreview);
            _tabRight.TabPages.Add(_tabScriptPreview);
            splitMain.Panel2.Controls.Add(_tabRight);

            Controls.Add(splitMain);
            Controls.Add(topPanel);
            Controls.Add(_statusStrip);
        }

        private static Button CreateStyledButton(string text, Point location, Size size, Color backColor)
        {
            Button btn = new Button
            {
                Text = text,
                Location = location,
                Size = size,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 85);
            btn.FlatAppearance.BorderSize = 1;
            return btn;
        }

        private void OnBrowseDirectoryClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Selecione o diretório raiz dos programas Progress Datasul:";
                if (!string.IsNullOrWhiteSpace(_txtRootDir.Text) && Directory.Exists(_txtRootDir.Text))
                {
                    dlg.SelectedPath = _txtRootDir.Text;
                }

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _txtRootDir.Text = dlg.SelectedPath;
                }
            }
        }

        private void OnSearchTermKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                OnSearchClick(sender, EventArgs.Empty);
            }
        }

        private async void OnSearchClick(object sender, EventArgs e)
        {
            string rootDir = _txtRootDir.Text.Trim();
            string searchTerm = _txtSearchTerm.Text.Trim();

            if (string.IsNullOrEmpty(rootDir) || !Directory.Exists(rootDir))
            {
                MessageBox.Show(this,
                    "Selecione um diretório válido onde estão os programas Progress.",
                    "Diretório Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show(this,
                    "Informe a palavra ou nome da tabela que deseja buscar (ex: es-teste-123).",
                    "Termo de Busca Obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                _txtSearchTerm.Focus();
                return;
            }

            SearchOptions options = BuildSearchOptionsFromUI(rootDir, searchTerm);
            SetSearchingState(true);

            _cts = new CancellationTokenSource();
            IProgress<SearchProgressInfo> progress = new Progress<SearchProgressInfo>(info =>
            {
                if (info.TotalFiles > 0)
                {
                    _progressBar.Maximum = info.TotalFiles;
                    _progressBar.Value = Math.Min(info.ProcessedFiles, info.TotalFiles);
                }
                _lblStatus.Text = info.PhaseMessage;
            });

            try
            {
                SearchReport report = await _searchEngine.ExecuteSearchAsync(options, progress, _cts.Token);
                LoadReportIntoUI(report);
            }
            catch (OperationCanceledException)
            {
                _lblStatus.Text = "Busca cancelada pelo usuário.";
            }
            catch (Exception ex)
            {
                _lblStatus.Text = "Erro na busca: " + ex.Message;
                MessageBox.Show(this, ex.Message, "Erro durante a varredura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetSearchingState(false);
            }
        }

        private void OnCancelSearchClick(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
            }
        }

        private SearchOptions BuildSearchOptionsFromUI(string rootDir, string searchTerm)
        {
            SearchOptions options = new SearchOptions
            {
                RootDirectory = rootDir,
                SearchTerm = searchTerm,
                TrackIncludes = _chkTrackIncludes.Checked,
                IgnoreComments = _chkIgnoreComments.Checked,
                WholeWord = _chkWholeWord.Checked,
                CaseSensitive = _chkCaseSensitive.Checked
            };

            List<string> parsedExts = _txtExtensions.Text
                .Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim().StartsWith(".") ? x.Trim() : "." + x.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (parsedExts.Count > 0)
            {
                options.Extensions = parsedExts;
            }

            return options;
        }

        private void SetSearchingState(bool searching)
        {
            _btnSearch.Enabled = !searching;
            _btnCancel.Enabled = searching;
            _btnBrowseDir.Enabled = !searching;
            _progressBar.Visible = searching;
            if (searching)
            {
                _progressBar.Value = 0;
            }
        }

        public void LoadReportIntoUI(SearchReport report)
        {
            _currentReport = report;
            _txtRootDir.Text = report.Options.RootDirectory;
            _txtSearchTerm.Text = report.Options.SearchTerm;

            PopulateCompilablesListView();
            PopulateOccurrencesTreeView();
            RefreshScriptPreview();

            int totalCompilables = report.CompilableResults.Count;
            int totalIncludes = report.AllResults.Count(r => !r.IsCompilable);

            _tabCompilables.Text = string.Format("Programas p/ Compilar ({0})", totalCompilables);
            _tabTreeSearch.Text = string.Format("Ocorrências Estilo VS Code ({0})", report.AllResults.Count);

            _lblStatus.Text = string.Format(
                "Busca concluída em {0} ms | Arquivos varridos: {1} | Compiláveis impactados: {2} | Includes (.i) encontradas: {3}",
                report.ElapsedMilliseconds,
                report.TotalFilesScanned,
                totalCompilables,
                totalIncludes);

            if (report.CompilableResults.Count > 0)
            {
                FileSearchResult first = report.CompilableResults[0];
                int firstLine = GetFirstRelevantLine(first);
                ShowFileInCodePreview(first, firstLine);
            }
            else if (report.AllResults.Count > 0)
            {
                FileSearchResult first = report.AllResults[0];
                int firstLine = GetFirstRelevantLine(first);
                ShowFileInCodePreview(first, firstLine);
            }
            else
            {
                _rtbCodePreview.Clear();
                _lblCodePreviewFile.Text = "Nenhuma ocorrência encontrada para '" + report.Options.SearchTerm + "'.";
                _btnOpenFolder.Enabled = false;
            }
        }

        private void PopulateCompilablesListView()
        {
            if (_currentReport == null)
            {
                return;
            }

            string filter = _txtFilterCompilables.Text.Trim();
            _suppressItemCheck = true;
            _lvCompilables.BeginUpdate();
            try
            {
                _lvCompilables.Items.Clear();

                foreach (FileSearchResult item in _currentReport.CompilableResults)
                {
                    if (!string.IsNullOrEmpty(filter) &&
                        item.RelativePath.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    string originText = item.IsDirectMatch && item.IsIncludeMatch
                        ? "Direto + Include"
                        : (item.IsDirectMatch ? "Direto" : "Via Include (.i)");

                    string detailText;
                    if (item.IsIncludeMatch && item.IncludeMatches.Count > 0)
                    {
                        detailText = item.IncludeMatches[0].ChainDescription;
                    }
                    else if (item.DirectMatches.Count > 0)
                    {
                        detailText = string.Format("Linha {0}: {1}", item.DirectMatches[0].LineNumber, item.DirectMatches[0].LineText.Trim());
                    }
                    else
                    {
                        detailText = string.Empty;
                    }

                    ListViewItem lvi = new ListViewItem(item.RelativePath)
                    {
                        Checked = item.SelectedForCompile,
                        Tag = item
                    };
                    lvi.SubItems.Add(originText);
                    lvi.SubItems.Add(item.TotalOccurrences.ToString());
                    lvi.SubItems.Add(detailText);

                    if (item.IsIncludeMatch && !item.IsDirectMatch)
                    {
                        lvi.ForeColor = Color.FromArgb(140, 215, 255);
                    }

                    _lvCompilables.Items.Add(lvi);
                }
            }
            finally
            {
                _lvCompilables.EndUpdate();
                _suppressItemCheck = false;
            }

            UpdateSelectedSummaryLabel();
        }

        private void PopulateOccurrencesTreeView()
        {
            _tvOccurrences.BeginUpdate();
            try
            {
                _tvOccurrences.Nodes.Clear();
                if (_currentReport == null)
                {
                    return;
                }

                foreach (FileSearchResult fileResult in _currentReport.AllResults)
                {
                    string badge = fileResult.IsCompilable ? "[COMPILÁVEL]" : "[INCLUDE .i]";
                    string headerText = string.Format("{0}  {1}  ({2} ocorr.)",
                        fileResult.RelativePath,
                        badge,
                        fileResult.TotalOccurrences);

                    TreeNode fileNode = new TreeNode(headerText)
                    {
                        Tag = new TreeNodePayload { Result = fileResult, LineNumber = GetFirstRelevantLine(fileResult) },
                        ForeColor = fileResult.IsCompilable ? Color.FromArgb(180, 240, 180) : Color.FromArgb(255, 210, 120)
                    };

                    foreach (LineMatch match in fileResult.DirectMatches)
                    {
                        string lineLabel = string.Format("Linha {0}: {1}", match.LineNumber, match.LineText.Trim());
                        TreeNode lineNode = new TreeNode(lineLabel)
                        {
                            Tag = new TreeNodePayload { Result = fileResult, LineNumber = match.LineNumber },
                            ForeColor = FgPrimary
                        };
                        fileNode.Nodes.Add(lineNode);
                    }

                    foreach (IncludeChainStep step in fileResult.IncludeMatches)
                    {
                        string incLabel = string.Format("Linha {0} [Via Include]: {1}  ({2})",
                            step.LineNumber,
                            step.LineText.Trim(),
                            step.ChainDescription);
                        TreeNode incNode = new TreeNode(incLabel)
                        {
                            Tag = new TreeNodePayload { Result = fileResult, LineNumber = step.LineNumber },
                            ForeColor = Color.FromArgb(140, 215, 255)
                        };
                        fileNode.Nodes.Add(incNode);
                    }

                    fileNode.Expand();
                    _tvOccurrences.Nodes.Add(fileNode);
                }
            }
            finally
            {
                _tvOccurrences.EndUpdate();
            }
        }

        private void SetAllCompilableChecks(bool checkState)
        {
            if (_currentReport == null)
            {
                return;
            }

            _suppressItemCheck = true;
            try
            {
                foreach (ListViewItem lvi in _lvCompilables.Items)
                {
                    lvi.Checked = checkState;
                    FileSearchResult res = lvi.Tag as FileSearchResult;
                    if (res != null)
                    {
                        res.SelectedForCompile = checkState;
                    }
                }
            }
            finally
            {
                _suppressItemCheck = false;
            }

            UpdateSelectedSummaryLabel();
            RefreshScriptPreview();
        }

        private void OnCompilableItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (_suppressItemCheck || e.Item == null)
            {
                return;
            }

            FileSearchResult res = e.Item.Tag as FileSearchResult;
            if (res != null)
            {
                res.SelectedForCompile = e.Item.Checked;
            }

            UpdateSelectedSummaryLabel();
            RefreshScriptPreview();
        }

        private void UpdateSelectedSummaryLabel()
        {
            if (_currentReport == null)
            {
                _lblSelectedSummary.Text = "0 selecionados para o script .p";
                return;
            }

            int selectedCount = _currentReport.CompilableResults.Count(r => r.SelectedForCompile);
            _lblSelectedSummary.Text = string.Format("{0} de {1} selecionados p/ compilar",
                selectedCount,
                _currentReport.CompilableResults.Count);
        }

        private void OnCompilableSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvCompilables.SelectedItems.Count == 0)
            {
                return;
            }

            FileSearchResult res = _lvCompilables.SelectedItems[0].Tag as FileSearchResult;
            if (res != null)
            {
                ShowFileInCodePreview(res, GetFirstRelevantLine(res));
            }
        }

        private void OnTreeOccurrenceAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            TreeNodePayload payload = e.Node.Tag as TreeNodePayload;
            if (payload != null && payload.Result != null)
            {
                ShowFileInCodePreview(payload.Result, payload.LineNumber);
            }
        }

        private static int GetFirstRelevantLine(FileSearchResult res)
        {
            if (res == null)
            {
                return 1;
            }
            if (res.DirectMatches.Count > 0)
            {
                return res.DirectMatches[0].LineNumber;
            }
            if (res.IncludeMatches.Count > 0)
            {
                return res.IncludeMatches[0].LineNumber;
            }
            return 1;
        }

        private void ShowFileInCodePreview(FileSearchResult result, int targetLineNumber)
        {
            if (result == null || !File.Exists(result.FilePath))
            {
                return;
            }

            _currentPreviewFilePath = result.FilePath;
            _btnOpenFolder.Enabled = true;
            _lblCodePreviewFile.Text = string.Format("{0}  (Linha {1})", result.RelativePath, targetLineNumber);

            string content;
            try
            {
                content = ProgressCodeAnalyzer.ReadFileWithAutoEncoding(result.FilePath);
            }
            catch (Exception ex)
            {
                _rtbCodePreview.Text = "Erro ao ler arquivo: " + ex.Message;
                return;
            }

            string[] lines = ProgressCodeAnalyzer.SplitLines(content);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int targetCharStart = 0;
            int targetCharLength = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                int lineNo = i + 1;
                string prefix = string.Format("{0,5} | ", lineNo);
                int lineStart = sb.Length;
                sb.Append(prefix).Append(lines[i]).Append('\n');

                if (lineNo == targetLineNumber)
                {
                    targetCharStart = lineStart;
                    targetCharLength = sb.Length - lineStart - 1;
                }
            }

            _rtbCodePreview.SuspendLayout();
            _rtbCodePreview.Clear();
            _rtbCodePreview.Text = sb.ToString();

            // Destaca a linha alvo
            if (targetCharLength > 0 && targetCharStart + targetCharLength <= _rtbCodePreview.TextLength)
            {
                _rtbCodePreview.Select(targetCharStart, targetCharLength);
                _rtbCodePreview.SelectionBackColor = HighlightLineBg;
                _rtbCodePreview.SelectionColor = Color.White;
            }

            // Destaca o termo pesquisado no texto
            if (_currentReport != null && !string.IsNullOrEmpty(_currentReport.Options.SearchTerm))
            {
                HighlightSearchTermInPreview(_currentReport.Options.SearchTerm, _currentReport.Options.CaseSensitive);
            }

            // Rola até a linha alvo
            int scrollPos = Math.Max(0, targetCharStart);
            _rtbCodePreview.Select(scrollPos, 0);
            _rtbCodePreview.ScrollToCaret();
            _rtbCodePreview.ResumeLayout();
        }

        private void HighlightSearchTermInPreview(string term, bool caseSensitive)
        {
            if (string.IsNullOrEmpty(term))
            {
                return;
            }

            StringComparison cmp = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            string text = _rtbCodePreview.Text;
            int idx = 0;
            int highlightCount = 0;

            while (idx <= text.Length - term.Length && highlightCount < 300)
            {
                int found = text.IndexOf(term, idx, cmp);
                if (found < 0)
                {
                    break;
                }

                _rtbCodePreview.Select(found, term.Length);
                _rtbCodePreview.SelectionBackColor = HighlightTermBg;
                _rtbCodePreview.SelectionColor = HighlightTermFg;

                idx = found + term.Length;
                highlightCount++;
            }
        }

        private CompileScriptOptions BuildCompileScriptOptions(string targetFilePath)
        {
            CompileScriptOptions opts = new CompileScriptOptions
            {
                ScriptMode = _cmbScriptMode.SelectedIndex == 0
                    ? CompileScriptMode.WithErrorLog
                    : CompileScriptMode.PureCompileSave,
                PathFormat = _cmbPathFormat.SelectedIndex == 0
                    ? CompilePathFormat.RelativeToRoot
                    : CompilePathFormat.AbsolutePath,
                UseForwardSlashes = true,
                SearchTermUsed = _currentReport != null ? _currentReport.Options.SearchTerm : _txtSearchTerm.Text.Trim(),
                RootDirectory = _currentReport != null ? _currentReport.Options.RootDirectory : _txtRootDir.Text.Trim(),
                TargetScriptFilePath = targetFilePath ?? string.Empty
            };
            return opts;
        }

        public void RefreshScriptPreview()
        {
            if (_currentReport == null)
            {
                _rtbScriptPreview.Text = "/* Realize uma busca para visualizar o script .p de compilacao gerado automaticamente. */";
                return;
            }

            CompileScriptOptions opts = BuildCompileScriptOptions(string.Empty);
            _rtbScriptPreview.Text = _scriptGenerator.GenerateScript(_currentReport.CompilableResults, opts);
        }

        private void OnSaveScriptClick(object sender, EventArgs e)
        {
            if (_currentReport == null || !_currentReport.CompilableResults.Any(r => r.SelectedForCompile))
            {
                MessageBox.Show(this,
                    "Não há programas compiláveis selecionados para gerar o arquivo .p.\nRealize uma busca e marque ao menos um programa.",
                    "Nenhum Programa Selecionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string safeTerm = SanitizeFileName(_currentReport.Options.SearchTerm);
            string defaultFileName = string.IsNullOrEmpty(safeTerm)
                ? "compilar-programas.p"
                : string.Format("compilar-{0}.p", safeTerm);

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Salvar Script Progress de Compilação (.p)";
                dlg.Filter = "Programa Progress ABL (*.p)|*.p|Todos os Arquivos (*.*)|*.*";
                dlg.FileName = defaultFileName;
                dlg.DefaultExt = "p";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    CompileScriptOptions opts = BuildCompileScriptOptions(dlg.FileName);
                    string finalScript = _scriptGenerator.GenerateScript(_currentReport.CompilableResults, opts);
                    _scriptGenerator.SaveScriptToFile(finalScript, dlg.FileName);
                    _rtbScriptPreview.Text = finalScript;
                    _tabRight.SelectedTab = _tabScriptPreview;

                    _lblStatus.Text = "Arquivo .p gerado com sucesso em: " + dlg.FileName;
                    MessageBox.Show(this,
                        string.Format("Script de compilação salvo com sucesso!\n\nArquivo: {0}\nProgramas incluídos: {1}",
                            dlg.FileName,
                            _currentReport.CompilableResults.Count(r => r.SelectedForCompile)),
                        "Script .p Gerado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void OnCopyScriptClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_rtbScriptPreview.Text))
            {
                return;
            }

            Clipboard.SetText(_rtbScriptPreview.Text);
            _lblStatus.Text = "Código do script .p copiado para a área de transferência!";
        }

        private void OnOpenFolderClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentPreviewFilePath) && File.Exists(_currentPreviewFilePath))
            {
                Process.Start("explorer.exe", "/select,\"" + _currentPreviewFilePath + "\"");
            }
        }

        private static string SanitizeFileName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }
            char[] invalid = Path.GetInvalidFileNameChars();
            return new string(input.Trim().Select(c => invalid.Contains(c) ? '-' : c).ToArray());
        }

        // Métodos auxiliares para verificação automatizada (Phase3Verifier)
        public int GetCompilableListViewCount()
        {
            return _lvCompilables.Items.Count;
        }

        public int GetTreeNodesCount()
        {
            return _tvOccurrences.Nodes.Count;
        }

        public string GetGeneratedScriptPreviewText()
        {
            return _rtbScriptPreview.Text;
        }

        public void SetScriptModeIndex(int index)
        {
            _cmbScriptMode.SelectedIndex = index;
        }

        public void SetPathFormatIndex(int index)
        {
            _cmbPathFormat.SelectedIndex = index;
        }
    }
}
