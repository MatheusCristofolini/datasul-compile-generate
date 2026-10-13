using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Effects;
using DatasulCompileGen.Core;
using WinForms = System.Windows.Forms;

namespace DatasulCompileGen.UI
{
    public class MainForm : Window
    {
        // Paleta de Cores UI/UX Pro Max (design-system/MASTER.md - Dark Slate OLED + Emerald/Blue)
        private static readonly Color ColBgCanvas = Color.FromRgb(9, 13, 22);         // #090D16
        private static readonly Color ColBgSurface = Color.FromRgb(17, 24, 39);       // #111827
        private static readonly Color ColBgElevated = Color.FromRgb(30, 41, 59);      // #1E293B
        private static readonly Color ColBgInput = Color.FromRgb(11, 17, 32);         // #0B1120
        private static readonly Color ColBorderSubtle = Color.FromRgb(30, 41, 59);    // #1E293B
        private static readonly Color ColBorderDefault = Color.FromRgb(51, 65, 85);   // #334155
        private static readonly Color ColBorderFocus = Color.FromRgb(56, 189, 248);   // #38BDF8
        private static readonly Color ColPrimaryBlue = Color.FromRgb(37, 99, 235);    // #2563EB
        private static readonly Color ColPrimaryBlueHover = Color.FromRgb(59, 130, 246); // #3B82F6
        private static readonly Color ColEmerald = Color.FromRgb(5, 150, 105);        // #059669
        private static readonly Color ColEmeraldHover = Color.FromRgb(16, 185, 129);  // #10B981
        private static readonly Color ColDanger = Color.FromRgb(220, 38, 38);         // #DC2626
        private static readonly Color ColTextPrimary = Color.FromRgb(248, 250, 252);  // #F8FAFC
        private static readonly Color ColTextSecondary = Color.FromRgb(148, 163, 184);// #94A3B8
        private static readonly Color ColTextMuted = Color.FromRgb(100, 116, 139);    // #64748B

        private static readonly SolidColorBrush BrushBgCanvas = Freeze(new SolidColorBrush(ColBgCanvas));
        private static readonly SolidColorBrush BrushBgSurface = Freeze(new SolidColorBrush(ColBgSurface));
        private static readonly SolidColorBrush BrushBgElevated = Freeze(new SolidColorBrush(ColBgElevated));
        private static readonly SolidColorBrush BrushBgInput = Freeze(new SolidColorBrush(ColBgInput));
        private static readonly SolidColorBrush BrushBorderSubtle = Freeze(new SolidColorBrush(ColBorderSubtle));
        private static readonly SolidColorBrush BrushBorderDefault = Freeze(new SolidColorBrush(ColBorderDefault));
        private static readonly SolidColorBrush BrushBorderFocus = Freeze(new SolidColorBrush(ColBorderFocus));
        private static readonly SolidColorBrush BrushPrimaryBlue = Freeze(new SolidColorBrush(ColPrimaryBlue));
        private static readonly SolidColorBrush BrushPrimaryBlueHover = Freeze(new SolidColorBrush(ColPrimaryBlueHover));
        private static readonly SolidColorBrush BrushEmerald = Freeze(new SolidColorBrush(ColEmerald));
        private static readonly SolidColorBrush BrushEmeraldHover = Freeze(new SolidColorBrush(ColEmeraldHover));
        private static readonly SolidColorBrush BrushDanger = Freeze(new SolidColorBrush(ColDanger));
        private static readonly SolidColorBrush BrushTextPrimary = Freeze(new SolidColorBrush(ColTextPrimary));
        private static readonly SolidColorBrush BrushTextSecondary = Freeze(new SolidColorBrush(ColTextSecondary));
        private static readonly SolidColorBrush BrushTextMuted = Freeze(new SolidColorBrush(ColTextMuted));

        // Ícones Vetoriais SVG (Lucide 24x24 Paths - Zero Emojis!)
        private const string SvgFolder = "M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z";
        private const string SvgSearch = "M11 19a8 8 0 1 0 0-16 8 8 0 0 0 0 16z M21 21l-4.35-4.35";
        private const string SvgDownload = "M21 15v4a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2v-4 M7 10l5 5 5-5 M12 15V3";
        private const string SvgCopy = "M8 4v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V7.242a2 2 0 0 0-.602-1.43L16.083 2.57A2 2 0 0 0 14.685 2H10a2 2 0 0 0-2 2z M16 18v2a2 2 0 0 1-2 2H6a2 2 0 0 1-2-2V9a2 2 0 0 1 2-2h2";
        private const string SvgCheck = "M20 6L9 17l-5-5";
        private const string SvgCode = "M16 18l6-6-6-6 M8 6l-6 6 6 6";
        private const string SvgGitBranch = "M6 3v12 M18 9a3 3 0 1 0 0-6 3 3 0 0 0 0 6z M6 21a3 3 0 1 0 0-6 3 3 0 0 0 0 6z M18 9a9 9 0 0 1-9 9";
        private const string SvgStop = "M18 6L6 18 M6 6l12 12";
        private const string SvgExternal = "M18 13v6a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h6 M15 3h6v6 M10 14L21 3";
        private const string SvgLayers = "M12 2L2 7l10 5 10-5-10-5z M2 17l10 5 10-5 M2 12l10 5 10-5";
        private const string SvgHistory = "M3 12a9 9 0 1 0 9-9 9.75 9.75 0 0 0-6.74 2.74L3 8 M3 3v5h5 M12 7v5l4 2";

        // Controles de Busca
        private TextBox _txtRootDir;
        private Button _btnRecentDirs;
        private Button _btnBrowseDir;
        private TextBox _txtSearchTerm;
        private Button _btnRecentTerms;
        private TextBox _txtExtensions;
        private CheckBox _chkTrackIncludes;
        private CheckBox _chkIgnoreComments;
        private CheckBox _chkWholeWord;
        private CheckBox _chkCaseSensitive;
        private Button _btnSearch;
        private Button _btnCancel;

        // KPI Cards
        private TextBlock _lblKpiScanned;
        private TextBlock _lblKpiScannedSub;
        private TextBlock _lblKpiCompilables;
        private TextBlock _lblKpiViaInclude;
        private TextBlock _lblKpiSelected;

        // Painel Esquerdo (Segmented Tabs + Listas)
        private Button _btnTabCompilables;
        private Button _btnTabOccurrences;
        private Grid _viewCompilables;
        private Grid _viewOccurrences;
        private TextBox _txtFilterCompilables;
        private StackPanel _spCompilableItems;
        private StackPanel _spOccurrenceTree;
        private int _compilableRenderedCount;
        private int _treeFileNodesCount;

        // Painel Direito (Segmented Tabs + Preview Código + Preview Script .p)
        private Button _btnTabCodePreview;
        private Button _btnTabScriptPreview;
        private Grid _viewCodePreview;
        private Grid _viewScriptPreview;
        private TextBlock _lblCodePreviewFile;
        private TextBlock _lblCodePreviewLineBadge;
        private Button _btnOpenFolder;
        private RichTextBox _rtbCodePreview;

        // Opções Segmentadas do Script .p
        private Button _btnModeErrorLog;
        private Button _btnModePure;
        private Button _btnPathRelative;
        private Button _btnPathAbsolute;
        private int _scriptModeIndex; // 0 = WithErrorLog (SESSION:TEMP-DIRECTORY), 1 = PureCompileSave
        private int _pathFormatIndex; // 0 = RelativeToRoot, 1 = AbsolutePath (Padrão = 1)
        private RichTextBox _rtbScriptPreview;
        private string _cachedScriptPreviewText;

        // Barra Flutuante de Localização no Editor (Ctrl + F)
        private class TextFindMatch
        {
            public TextPointer Start { get; set; }
            public TextPointer End { get; set; }
            public Paragraph Paragraph { get; set; }
            public Run OwnerRun { get; set; }
            public int LineNumber { get; set; }
            public int MatchIndex { get; set; }
        }

        private Border _findBarBorder;
        private TextBox _txtEditorFind;
        private TextBlock _lblFindCount;
        private Button _btnFindPrev;
        private Button _btnFindNext;
        private Button _btnFindClose;
        private Button _btnFindCode;
        private List<TextFindMatch> _activeFindMatches = new List<TextFindMatch>();
        private int _currentFindIndex = -1;

        // Barra de Progresso Principal e Status
        private Border _scanProgressBorder;
        private ProgressBar _mainProgressBar;
        private TextBlock _lblProgressTitle;
        private TextBlock _lblProgressCounter;
        private TextBlock _lblProgressPercent;
        private TextBlock _lblProgressCurrentFile;
        private Ellipse _statusDot;
        private TextBlock _lblStatus;
        private ProgressBar _progressBar;

        // Serviços, Cache e Estado
        private readonly ProgressSearchEngine _searchEngine;
        private readonly CompileScriptGenerator _scriptGenerator;
        private readonly AppCacheService _cacheService;
        private AppCacheData _cacheData;
        private bool _isLoadingCache;
        private CancellationTokenSource _cts;
        private SearchReport _currentReport;
        private string _currentPreviewFilePath;
        private Border _selectedProgramCardBorder;

        public MainForm()
            : this(null)
        {
        }

        public MainForm(AppCacheService customCacheService)
        {
            _searchEngine = new ProgressSearchEngine();
            _scriptGenerator = new CompileScriptGenerator();
            _cacheService = customCacheService ?? new AppCacheService();
            _cacheData = _cacheService.Load();
            _currentPreviewFilePath = string.Empty;
            _cachedScriptPreviewText = string.Empty;
            _scriptModeIndex = 0;
            _pathFormatIndex = 1; // Marcado Caminho Absoluto por padrão

            InitializeGlobalResources();
            InitializeLayout();
            ApplyCacheToUI();
            HookAutoSaveCacheEvents();
            Closing += (s, e) => SaveCurrentStateToCache();
        }

        private static SolidColorBrush Freeze(SolidColorBrush brush)
        {
            brush.Freeze();
            return brush;
        }

        private void InitializeGlobalResources()
        {
            // Estilos globais em XAML para eliminar 100% das bordas e scrollbars brancas legadas do Windows
            string xamlResources = @"
<ResourceDictionary xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                    xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
    <Style TargetType='{x:Type ScrollBar}'>
        <Setter Property='Background' Value='Transparent'/>
        <Setter Property='Width' Value='8'/>
        <Setter Property='Template'>
            <Setter.Value>
                <ControlTemplate TargetType='{x:Type ScrollBar}'>
                    <Grid Background='#090D16' Width='8'>
                        <Track x:Name='PART_Track' IsDirectionReversed='true'>
                            <Track.Thumb>
                                <Thumb>
                                    <Thumb.Template>
                                        <ControlTemplate TargetType='{x:Type Thumb}'>
                                            <Border Background='#334155' CornerRadius='4' Margin='1'/>
                                        </ControlTemplate>
                                    </Thumb.Template>
                                </Thumb>
                            </Track.Thumb>
                        </Track>
                    </Grid>
                    <ControlTemplate.Triggers>
                        <Trigger Property='Orientation' Value='Horizontal'>
                            <Setter Property='Width' Value='Auto'/>
                            <Setter Property='Height' Value='8'/>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
    <Style TargetType='{x:Type ProgressBar}'>
        <Setter Property='Background' Value='#090D16'/>
        <Setter Property='Foreground' Value='#38BDF8'/>
        <Setter Property='BorderBrush' Value='#1E293B'/>
        <Setter Property='BorderThickness' Value='1'/>
        <Setter Property='Template'>
            <Setter.Value>
                <ControlTemplate TargetType='{x:Type ProgressBar}'>
                    <Border x:Name='TemplateRoot'
                            Background='{TemplateBinding Background}'
                            BorderBrush='{TemplateBinding BorderBrush}'
                            BorderThickness='{TemplateBinding BorderThickness}'
                            CornerRadius='5'
                            SnapsToDevicePixels='True'>
                        <Grid x:Name='PART_Track' Margin='1'>
                            <Border x:Name='PART_Indicator'
                                    HorizontalAlignment='Left'
                                    Background='{TemplateBinding Foreground}'
                                    CornerRadius='4'/>
                        </Grid>
                    </Border>
                    <ControlTemplate.Triggers>
                        <Trigger Property='IsIndeterminate' Value='True'>
                            <Setter TargetName='PART_Indicator' Property='Opacity' Value='0.55'/>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>";

            ResourceDictionary dict = (ResourceDictionary)XamlReader.Parse(xamlResources);
            Resources.MergedDictionaries.Add(dict);
        }

        private void InitializeLayout()
        {
            Title = "Datasul Search & Compile Script Generator — Progress 4GL / ABL";
            Width = 1380;
            Height = 860;
            MinWidth = 1060;
            MinHeight = 680;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Background = BrushBgCanvas;
            Foreground = BrushTextPrimary;
            FontFamily = new FontFamily("Segoe UI");
            FontSize = 13;

            Grid rootGrid = new Grid { Margin = new Thickness(16, 14, 16, 10) };
            rootGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // 0: Header Titlebar
            rootGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // 1: Search Command Panel
            rootGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // 2: KPI Cards
            rootGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // 3: Split Workspace
            rootGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // 4: Status Bar

            // 0. Header Bar
            UIElement headerBar = BuildHeaderBar();
            Grid.SetRow(headerBar, 0);
            rootGrid.Children.Add(headerBar);

            // 1. Search Command Card
            UIElement searchCard = BuildSearchCommandCard();
            Grid.SetRow(searchCard, 1);
            rootGrid.Children.Add(searchCard);

            // 2. KPI Metrics Strip
            UIElement kpiStrip = BuildKpiStrip();
            Grid.SetRow(kpiStrip, 2);
            rootGrid.Children.Add(kpiStrip);

            // 3. Main Split Workspace
            UIElement workspace = BuildMainWorkspace();
            Grid.SetRow(workspace, 3);
            rootGrid.Children.Add(workspace);

            // 4. Status Bar
            UIElement statusBar = BuildStatusBar();
            Grid.SetRow(statusBar, 4);
            rootGrid.Children.Add(statusBar);

            Content = rootGrid;
            RefreshScriptPreview();
        }

        private UIElement BuildHeaderBar()
        {
            Grid header = new Grid { Margin = new Thickness(0, 0, 0, 12) };
            header.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            header.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            StackPanel leftBrand = new StackPanel { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Center };

            Border iconBadge = new Border
            {
                Width = 36,
                Height = 36,
                CornerRadius = new CornerRadius(9),
                Background = new SolidColorBrush(Color.FromRgb(23, 37, 84)),
                BorderBrush = new SolidColorBrush(Color.FromRgb(59, 130, 246)),
                BorderThickness = new Thickness(1),
                Margin = new Thickness(0, 0, 12, 0),
                Child = CreateSvgIcon(SvgLayers, Color.FromRgb(96, 165, 250), 18)
            };

            StackPanel titleStack = new StackPanel { VerticalAlignment = VerticalAlignment.Center };
            titleStack.Children.Add(new TextBlock
            {
                Text = "Datasul Search & Compile Generator",
                FontSize = 17,
                FontWeight = FontWeights.SemiBold,
                Foreground = BrushTextPrimary
            });
            titleStack.Children.Add(new TextBlock
            {
                Text = "Varredura de impacto de tabelas Progress 4GL/ABL, rastreamento reverso de includes (.i) e geração de script COMPILE SAVE.",
                FontSize = 12,
                Foreground = BrushTextSecondary
            });

            leftBrand.Children.Add(iconBadge);
            leftBrand.Children.Add(titleStack);
            header.Children.Add(leftBrand);

            return header;
        }

        private UIElement BuildSearchCommandCard()
        {
            Border card = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(12),
                Padding = new Thickness(16, 14, 16, 14),
                Margin = new Thickness(0, 0, 0, 12)
            };

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(12) });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            // Linha 1: Diretório + Botão Recentes + Botão Procurar + Extensões
            Grid row1 = new Grid();
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(16) });
            row1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(210) });

            StackPanel dirGroup = new StackPanel();
            dirGroup.Children.Add(CreateFieldLabel("DIRETÓRIO DE PROGRAMAS PROGRESS"));
            _txtRootDir = CreateModernTextBox(SvgFolder, "Selecione ou cole o caminho da pasta de fontes (ex: C:\\Totvs\\Fontes)...", false);
            dirGroup.Children.Add(_txtRootDir);
            Grid.SetColumn(dirGroup, 0);
            row1.Children.Add(dirGroup);

            _btnRecentDirs = CreateActionButton(
                "Recentes ▾",
                SvgHistory,
                BrushBgElevated,
                new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                ColBorderDefault,
                114,
                36);
            _btnRecentDirs.VerticalAlignment = VerticalAlignment.Bottom;
            _btnRecentDirs.ToolTip = "Selecionar um dos últimos diretórios utilizados";
            _btnRecentDirs.Click += OnRecentDirsClick;
            Grid.SetColumn(_btnRecentDirs, 2);
            row1.Children.Add(_btnRecentDirs);

            _btnBrowseDir = CreateActionButton(
                "Procurar Pasta",
                SvgFolder,
                BrushBgElevated,
                new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                ColBorderDefault,
                135,
                36);
            _btnBrowseDir.VerticalAlignment = VerticalAlignment.Bottom;
            _btnBrowseDir.Click += OnBrowseDirectoryClick;
            Grid.SetColumn(_btnBrowseDir, 4);
            row1.Children.Add(_btnBrowseDir);

            StackPanel extGroup = new StackPanel();
            extGroup.Children.Add(CreateFieldLabel("EXTENSÕES VARRIDAS"));
            _txtExtensions = CreateModernTextBox(SvgCode, ".p, .w, .i, .cls", true);
            _txtExtensions.Text = ".p, .w, .i, .cls";
            extGroup.Children.Add(_txtExtensions);
            Grid.SetColumn(extGroup, 6);
            row1.Children.Add(extGroup);

            Grid.SetRow(row1, 0);
            grid.Children.Add(row1);

            // Linha 2: Palavra-chave / Tabela + Botão Recentes + Buscar + Cancelar
            Grid row2 = new Grid();
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            row2.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            StackPanel searchGroup = new StackPanel();
            searchGroup.Children.Add(CreateFieldLabel("TERMO OU TABELA BUSCADA (EX: es-teste-123)"));
            _txtSearchTerm = CreateModernTextBox(SvgSearch, "Digite o nome da tabela, campo ou palavra-chave e pressione Enter...", true);
            _txtSearchTerm.KeyDown += OnSearchTermKeyDown;
            searchGroup.Children.Add(_txtSearchTerm);
            Grid.SetColumn(searchGroup, 0);
            row2.Children.Add(searchGroup);

            _btnRecentTerms = CreateActionButton(
                "Recentes ▾",
                SvgHistory,
                BrushBgElevated,
                new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                ColBorderDefault,
                114,
                36);
            _btnRecentTerms.VerticalAlignment = VerticalAlignment.Bottom;
            _btnRecentTerms.ToolTip = "Selecionar uma das últimas palavras-chave ou tabelas pesquisadas";
            _btnRecentTerms.Click += OnRecentTermsClick;
            Grid.SetColumn(_btnRecentTerms, 2);
            row2.Children.Add(_btnRecentTerms);

            _btnSearch = CreateActionButton(
                "Buscar Programas",
                SvgSearch,
                BrushPrimaryBlue,
                BrushPrimaryBlueHover,
                Color.FromRgb(96, 165, 250),
                168,
                36);
            _btnSearch.VerticalAlignment = VerticalAlignment.Bottom;
            _btnSearch.Click += OnSearchClick;
            Grid.SetColumn(_btnSearch, 4);
            row2.Children.Add(_btnSearch);

            _btnCancel = CreateActionButton(
                "Cancelar",
                SvgStop,
                BrushDanger,
                new SolidColorBrush(Color.FromRgb(239, 68, 68)),
                Color.FromRgb(248, 113, 113),
                110,
                36);
            _btnCancel.VerticalAlignment = VerticalAlignment.Bottom;
            _btnCancel.IsEnabled = false;
            _btnCancel.Opacity = 0.45;
            _btnCancel.Click += OnCancelSearchClick;
            Grid.SetColumn(_btnCancel, 6);
            row2.Children.Add(_btnCancel);

            Grid.SetRow(row2, 2);
            grid.Children.Add(row2);

            // Linha 3: Pills de Opções de Busca
            WrapPanel optionsBar = new WrapPanel { Orientation = Orientation.Horizontal };
            _chkTrackIncludes = CreateOptionPillCheckBox("Rastrear Includes Recursivamente (.i → .p, .w, .cls)", true, true);
            _chkIgnoreComments = CreateOptionPillCheckBox("Ignorar Comentários Progress (/* ... */ e //)", true, false);
            _chkWholeWord = CreateOptionPillCheckBox("Palavra Inteira", false, false);
            _chkCaseSensitive = CreateOptionPillCheckBox("Diferenciar Maiúsculas/Minúsculas", false, false);

            optionsBar.Children.Add(_chkTrackIncludes);
            optionsBar.Children.Add(_chkIgnoreComments);
            optionsBar.Children.Add(_chkWholeWord);
            optionsBar.Children.Add(_chkCaseSensitive);

            Grid.SetRow(optionsBar, 4);
            grid.Children.Add(optionsBar);

            // Linha 4: Barra de Progresso de Varredura em Destaque (Sempre Visível)
            _scanProgressBorder = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderDefault,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(9),
                Padding = new Thickness(12, 8, 12, 8)
            };

            Grid progGrid = new Grid();
            progGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            progGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(6) });
            progGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            progGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4) });
            progGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            Grid progHeader = new Grid();
            progHeader.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            progHeader.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            progHeader.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            _lblProgressTitle = new TextBlock
            {
                Text = "PROGRESSO DA VARREDURA — Pronto para iniciar",
                FontSize = 11.5,
                FontWeight = FontWeights.Bold,
                Foreground = BrushTextSecondary,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(_lblProgressTitle, 0);
            progHeader.Children.Add(_lblProgressTitle);

            _lblProgressCounter = new TextBlock
            {
                Text = "0 / 0 arquivos",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11.5,
                Foreground = BrushTextMuted,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(12, 0, 12, 0)
            };
            Grid.SetColumn(_lblProgressCounter, 1);
            progHeader.Children.Add(_lblProgressCounter);

            _lblProgressPercent = new TextBlock
            {
                Text = "0%",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                FontWeight = FontWeights.Bold,
                Foreground = BrushBorderFocus,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(_lblProgressPercent, 2);
            progHeader.Children.Add(_lblProgressPercent);

            Grid.SetRow(progHeader, 0);
            progGrid.Children.Add(progHeader);

            _mainProgressBar = new ProgressBar
            {
                Height = 10,
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Background = BrushBgCanvas,
                Foreground = BrushBorderFocus,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1)
            };
            Grid.SetRow(_mainProgressBar, 2);
            progGrid.Children.Add(_mainProgressBar);

            _lblProgressCurrentFile = new TextBlock
            {
                Text = "Selecione a pasta de fontes e clique em 'Buscar Programas' para acompanhar a varredura em tempo real.",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11,
                Foreground = BrushTextMuted,
                TextTrimming = TextTrimming.CharacterEllipsis
            };
            Grid.SetRow(_lblProgressCurrentFile, 4);
            progGrid.Children.Add(_lblProgressCurrentFile);

            _scanProgressBorder.Child = progGrid;
            Grid.SetRow(_scanProgressBorder, 6);
            grid.Children.Add(_scanProgressBorder);

            card.Child = grid;
            return card;
        }

        private UIElement BuildKpiStrip()
        {
            UniformGrid kpiGrid = new UniformGrid
            {
                Columns = 4,
                Margin = new Thickness(0, 0, 0, 12)
            };

            kpiGrid.Children.Add(CreateKpiCard(
                "ARQUIVOS VARRIDOS",
                SvgFolder,
                Color.FromRgb(56, 189, 248),
                out _lblKpiScanned,
                out _lblKpiScannedSub,
                "Aguardando varredura",
                new Thickness(0, 0, 6, 0)));

            TextBlock subComp;
            kpiGrid.Children.Add(CreateKpiCard(
                "COMPILÁVEIS (.P / .W / .CLS)",
                SvgCode,
                Color.FromRgb(52, 211, 153),
                out _lblKpiCompilables,
                out subComp,
                "Programas que entram no COMPILE",
                new Thickness(6, 0, 6, 0)));

            TextBlock subInc;
            kpiGrid.Children.Add(CreateKpiCard(
                "IMPACTO VIA INCLUDE (.I)",
                SvgGitBranch,
                Color.FromRgb(129, 140, 248),
                out _lblKpiViaInclude,
                out subInc,
                "Rastreados indiretamente por .i",
                new Thickness(6, 0, 6, 0)));

            TextBlock subSel;
            kpiGrid.Children.Add(CreateKpiCard(
                "SELECIONADOS P/ SCRIPT .P",
                SvgCheck,
                Color.FromRgb(251, 191, 36),
                out _lblKpiSelected,
                out subSel,
                "Marcados para gerar o arquivo .p",
                new Thickness(6, 0, 0, 0)));

            return kpiGrid;
        }

        private Border CreateKpiCard(
            string title,
            string svgPath,
            Color accentColor,
            out TextBlock valueBlock,
            out TextBlock subBlock,
            string defaultSubtitle,
            Thickness margin)
        {
            Border card = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(14, 10, 14, 10),
                Margin = margin
            };

            Grid g = new Grid();
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            StackPanel sp = new StackPanel();
            sp.Children.Add(new TextBlock
            {
                Text = title,
                FontSize = 10.5,
                FontWeight = FontWeights.Bold,
                Foreground = BrushTextSecondary
            });

            valueBlock = new TextBlock
            {
                Text = "0",
                FontSize = 22,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(accentColor),
                Margin = new Thickness(0, 2, 0, 2)
            };
            sp.Children.Add(valueBlock);

            subBlock = new TextBlock
            {
                Text = defaultSubtitle,
                FontSize = 11,
                Foreground = BrushTextMuted
            };
            sp.Children.Add(subBlock);

            Border iconBox = new Border
            {
                Width = 34,
                Height = 34,
                CornerRadius = new CornerRadius(8),
                Background = new SolidColorBrush(Color.FromArgb(30, accentColor.R, accentColor.G, accentColor.B)),
                VerticalAlignment = VerticalAlignment.Top,
                Child = CreateSvgIcon(svgPath, accentColor, 16)
            };

            Grid.SetColumn(sp, 0);
            Grid.SetColumn(iconBox, 1);
            g.Children.Add(sp);
            g.Children.Add(iconBox);

            card.Child = g;
            return card;
        }

        private UIElement BuildMainWorkspace()
        {
            Grid splitGrid = new Grid();
            splitGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(540), MinWidth = 360 });
            splitGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(10) });
            splitGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star), MinWidth = 420 });

            // Painel Esquerdo
            Border leftCard = BuildLeftResultsCard();
            Grid.SetColumn(leftCard, 0);
            splitGrid.Children.Add(leftCard);

            // Splitter
            GridSplitter splitter = new GridSplitter
            {
                Width = 10,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Background = Brushes.Transparent,
                Cursor = Cursors.SizeWE
            };
            Grid.SetColumn(splitter, 1);
            splitGrid.Children.Add(splitter);

            // Painel Direito
            Border rightCard = BuildRightPreviewCard();
            Grid.SetColumn(rightCard, 2);
            splitGrid.Children.Add(rightCard);

            return splitGrid;
        }

        private Border BuildLeftResultsCard()
        {
            Border card = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(12),
                Padding = new Thickness(12)
            };

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Segmented Switcher
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            // Segmented Pill Header
            Border segTrack = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(3)
            };

            UniformGrid segButtons = new UniformGrid { Columns = 2 };
            _btnTabCompilables = CreateSegmentedTabButton("Programas p/ Compilar (0)", true);
            _btnTabOccurrences = CreateSegmentedTabButton("Árvore VS Code (0)", false);

            _btnTabCompilables.Click += (s, e) => SwitchLeftTab(true);
            _btnTabOccurrences.Click += (s, e) => SwitchLeftTab(false);

            segButtons.Children.Add(_btnTabCompilables);
            segButtons.Children.Add(_btnTabOccurrences);
            segTrack.Child = segButtons;

            Grid.SetRow(segTrack, 0);
            grid.Children.Add(segTrack);

            // View 1: Compiláveis
            _viewCompilables = new Grid();
            _viewCompilables.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            _viewCompilables.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8) });
            _viewCompilables.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Grid filterBar = new Grid();
            filterBar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            filterBar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(6) });
            filterBar.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            filterBar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(6) });
            filterBar.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            _txtFilterCompilables = CreateModernTextBox(SvgSearch, "Filtrar programas na lista...", false);
            _txtFilterCompilables.TextChanged += (s, e) => PopulateCompilablesListView();
            Grid.SetColumn(_txtFilterCompilables, 0);
            filterBar.Children.Add(_txtFilterCompilables);

            Button btnAll = CreateSmallSecondaryButton("Marcar Todos");
            btnAll.Click += (s, e) => SetAllCompilableChecks(true);
            Grid.SetColumn(btnAll, 2);
            filterBar.Children.Add(btnAll);

            Button btnNone = CreateSmallSecondaryButton("Desmarcar");
            btnNone.Click += (s, e) => SetAllCompilableChecks(false);
            Grid.SetColumn(btnNone, 4);
            filterBar.Children.Add(btnNone);

            Grid.SetRow(filterBar, 0);
            _viewCompilables.Children.Add(filterBar);

            ScrollViewer svComp = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };
            _spCompilableItems = new StackPanel();
            _spCompilableItems.Children.Add(BuildEmptyStateBlock(
                "Nenhum programa listado ainda",
                "Escolha o diretório acima, digite o nome da tabela ou palavra-chave (ex: es-teste-123) e clique em Buscar Programas."));
            svComp.Content = _spCompilableItems;

            Grid.SetRow(svComp, 2);
            _viewCompilables.Children.Add(svComp);

            // View 2: Árvore de Ocorrências Estilo VS Code
            _viewOccurrences = new Grid { Visibility = Visibility.Collapsed };
            ScrollViewer svTree = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };
            _spOccurrenceTree = new StackPanel();
            svTree.Content = _spOccurrenceTree;
            _viewOccurrences.Children.Add(svTree);

            Grid.SetRow(_viewCompilables, 2);
            Grid.SetRow(_viewOccurrences, 2);
            grid.Children.Add(_viewCompilables);
            grid.Children.Add(_viewOccurrences);

            card.Child = grid;
            return card;
        }

        private Border BuildRightPreviewCard()
        {
            Border card = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(12),
                Padding = new Thickness(12)
            };

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Segmented Switcher
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Border segTrack = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(3)
            };

            UniformGrid segButtons = new UniformGrid { Columns = 2 };
            _btnTabCodePreview = CreateSegmentedTabButton("Visualizador de Código-Fonte", true);
            _btnTabScriptPreview = CreateSegmentedTabButton("Script .p de Compilação (Preview Ao Vivo)", false);

            _btnTabCodePreview.Click += (s, e) => SwitchRightTab(true);
            _btnTabScriptPreview.Click += (s, e) => SwitchRightTab(false);

            segButtons.Children.Add(_btnTabCodePreview);
            segButtons.Children.Add(_btnTabScriptPreview);
            segTrack.Child = segButtons;

            Grid.SetRow(segTrack, 0);
            grid.Children.Add(segTrack);

            // View 1: Visualizador de Código
            _viewCodePreview = new Grid();
            _viewCodePreview.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            _viewCodePreview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8) });
            _viewCodePreview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Border codeHeader = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(12, 7, 12, 7)
            };

            Grid codeHeaderGrid = new Grid();
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8) });
            codeHeaderGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            StackPanel fileLabelStack = new StackPanel { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Center };
            fileLabelStack.Children.Add(CreateSvgIcon(SvgCode, Color.FromRgb(56, 189, 248), 15));
            _lblCodePreviewFile = new TextBlock
            {
                Text = "Selecione um programa ou ocorrência à esquerda para inspecionar o código-fonte",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 12.5,
                FontWeight = FontWeights.SemiBold,
                Foreground = BrushTextPrimary,
                Margin = new Thickness(8, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center
            };
            fileLabelStack.Children.Add(_lblCodePreviewFile);
            Grid.SetColumn(fileLabelStack, 0);
            codeHeaderGrid.Children.Add(fileLabelStack);

            Border lineBadge = new Border
            {
                Background = new SolidColorBrush(Color.FromRgb(30, 58, 138)),
                BorderBrush = new SolidColorBrush(Color.FromRgb(59, 130, 246)),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(8, 3, 8, 3),
                VerticalAlignment = VerticalAlignment.Center
            };
            _lblCodePreviewLineBadge = new TextBlock
            {
                Text = "Linha -",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(Color.FromRgb(147, 197, 253))
            };
            lineBadge.Child = _lblCodePreviewLineBadge;
            Grid.SetColumn(lineBadge, 1);
            codeHeaderGrid.Children.Add(lineBadge);

            _btnFindCode = CreateSmallSecondaryButton("Localizar (Ctrl+F)");
            _btnFindCode.Click += (s, e) => OpenOrFocusEditorFind();
            Grid.SetColumn(_btnFindCode, 3);
            codeHeaderGrid.Children.Add(_btnFindCode);

            _btnOpenFolder = CreateSmallSecondaryButton("Abrir na Pasta");
            _btnOpenFolder.IsEnabled = false;
            _btnOpenFolder.Click += OnOpenFolderClick;
            Grid.SetColumn(_btnOpenFolder, 5);
            codeHeaderGrid.Children.Add(_btnOpenFolder);

            codeHeader.Child = codeHeaderGrid;
            Grid.SetRow(codeHeader, 0);
            _viewCodePreview.Children.Add(codeHeader);

            Border codeBoxBorder = new Border
            {
                Background = BrushBgCanvas,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(4)
            };

            _rtbCodePreview = new RichTextBox
            {
                IsReadOnly = true,
                Background = Brushes.Transparent,
                Foreground = BrushTextPrimary,
                BorderThickness = new Thickness(0),
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                IsInactiveSelectionHighlightEnabled = true,
                SelectionBrush = new SolidColorBrush(Color.FromRgb(245, 158, 11)),
                SelectionOpacity = 0.85,
                Document = new FlowDocument { PageWidth = 2200 }
            };
            codeBoxBorder.Child = _rtbCodePreview;
            Grid.SetRow(codeBoxBorder, 2);
            _viewCodePreview.Children.Add(codeBoxBorder);

            // View 2: Script .p de Compilação (Preview & Opções Segmentadas)
            _viewScriptPreview = new Grid { Visibility = Visibility.Collapsed };
            _viewScriptPreview.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            _viewScriptPreview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8) });
            _viewScriptPreview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Border scriptOptionsCard = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(12, 10, 12, 10)
            };

            Grid scriptOptGrid = new Grid();
            scriptOptGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            scriptOptGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8) });
            scriptOptGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            scriptOptGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            scriptOptGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(12) });
            scriptOptGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            scriptOptGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(12) });
            scriptOptGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            // Seletor 1: Modo do Script .p
            TextBlock lblModeTitle = new TextBlock
            {
                Text = "MODO DO SCRIPT .P:",
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Foreground = BrushTextSecondary,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(lblModeTitle, 0);
            Grid.SetColumn(lblModeTitle, 0);
            scriptOptGrid.Children.Add(lblModeTitle);

            UniformGrid modePills = new UniformGrid { Columns = 2 };
            _btnModeErrorLog = CreateSegmentedOptionButton("Com Log no Session-Temp (NO-ERROR + .log)", true);
            _btnModePure = CreateSegmentedOptionButton("Modo Puro (Apenas COMPILE SAVE.)", false);
            _btnModeErrorLog.Click += (s, e) => SetScriptModeIndex(0);
            _btnModePure.Click += (s, e) => SetScriptModeIndex(1);
            modePills.Children.Add(_btnModeErrorLog);
            modePills.Children.Add(_btnModePure);
            Grid.SetRow(modePills, 0);
            Grid.SetColumn(modePills, 2);
            scriptOptGrid.Children.Add(modePills);

            Button btnCopy = CreateActionButton(
                "Copiar Código .p",
                SvgCopy,
                BrushPrimaryBlue,
                BrushPrimaryBlueHover,
                Color.FromRgb(96, 165, 250),
                155,
                32);
            btnCopy.Click += OnCopyScriptClick;
            Grid.SetRow(btnCopy, 0);
            Grid.SetColumn(btnCopy, 4);
            scriptOptGrid.Children.Add(btnCopy);

            // Seletor 2: Formato do Caminho
            TextBlock lblPathTitle = new TextBlock
            {
                Text = "FORMATO CAMINHO:",
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Foreground = BrushTextSecondary,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(lblPathTitle, 2);
            Grid.SetColumn(lblPathTitle, 0);
            scriptOptGrid.Children.Add(lblPathTitle);

            UniformGrid pathPills = new UniformGrid { Columns = 2 };
            _btnPathRelative = CreateSegmentedOptionButton("Caminho Relativo (Padrão PROPATH)", false);
            _btnPathAbsolute = CreateSegmentedOptionButton("Caminho Absoluto Completo", true);
            _btnPathRelative.Click += (s, e) => SetPathFormatIndex(0);
            _btnPathAbsolute.Click += (s, e) => SetPathFormatIndex(1);
            pathPills.Children.Add(_btnPathRelative);
            pathPills.Children.Add(_btnPathAbsolute);
            Grid.SetRow(pathPills, 2);
            Grid.SetColumn(pathPills, 2);
            scriptOptGrid.Children.Add(pathPills);

            Button btnSaveP = CreateActionButton(
                "Salvar Arquivo .p...",
                SvgDownload,
                BrushEmerald,
                BrushEmeraldHover,
                Color.FromRgb(16, 185, 129),
                155,
                32);
            btnSaveP.Click += OnSaveScriptClick;
            Grid.SetRow(btnSaveP, 2);
            Grid.SetColumn(btnSaveP, 4);
            scriptOptGrid.Children.Add(btnSaveP);

            scriptOptionsCard.Child = scriptOptGrid;
            Grid.SetRow(scriptOptionsCard, 0);
            _viewScriptPreview.Children.Add(scriptOptionsCard);

            Border scriptBoxBorder = new Border
            {
                Background = BrushBgCanvas,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(6)
            };

            _rtbScriptPreview = new RichTextBox
            {
                IsReadOnly = true,
                Background = Brushes.Transparent,
                Foreground = new SolidColorBrush(Color.FromRgb(167, 243, 208)),
                BorderThickness = new Thickness(0),
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                IsInactiveSelectionHighlightEnabled = true,
                SelectionBrush = new SolidColorBrush(Color.FromRgb(245, 158, 11)),
                SelectionOpacity = 0.85,
                Document = new FlowDocument { PageWidth = 2200 }
            };
            scriptBoxBorder.Child = _rtbScriptPreview;
            Grid.SetRow(scriptBoxBorder, 2);
            _viewScriptPreview.Children.Add(scriptBoxBorder);

            Grid.SetRow(_viewCodePreview, 2);
            Grid.SetRow(_viewScriptPreview, 2);
            grid.Children.Add(_viewCodePreview);
            grid.Children.Add(_viewScriptPreview);

            _findBarBorder = BuildFindBar();
            Grid.SetRow(_findBarBorder, 2);
            Panel.SetZIndex(_findBarBorder, 100);
            grid.Children.Add(_findBarBorder);

            card.Child = grid;
            return card;
        }

        private UIElement BuildStatusBar()
        {
            Border bar = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(12, 7, 12, 7),
                Margin = new Thickness(0, 10, 0, 0)
            };

            Grid g = new Grid();
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            _statusDot = new Ellipse
            {
                Width = 8,
                Height = 8,
                Fill = BrushEmeraldHover,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 8, 0)
            };
            Grid.SetColumn(_statusDot, 0);
            g.Children.Add(_statusDot);

            _lblStatus = new TextBlock
            {
                Text = "Pronto. Selecione o diretório de programas e informe o termo de busca (ex: es-teste-123).",
                FontSize = 12,
                Foreground = BrushTextSecondary,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(_lblStatus, 1);
            g.Children.Add(_lblStatus);

            _progressBar = new ProgressBar
            {
                Width = 180,
                Height = 8,
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(12, 0, 12, 0),
                Background = BrushBgInput,
                Foreground = BrushPrimaryBlueHover,
                BorderThickness = new Thickness(0),
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(_progressBar, 2);
            g.Children.Add(_progressBar);

            TextBlock versionBadge = new TextBlock
            {
                Text = "UI/UX Pro Max • Portátil (.exe)",
                FontSize = 11,
                FontWeight = FontWeights.SemiBold,
                Foreground = BrushTextMuted,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(versionBadge, 3);
            g.Children.Add(versionBadge);

            bar.Child = g;
            return bar;
        }

        // ── Construtores de Controles Estilizados (UI/UX Pro Max) ──────────────────

        private static TextBlock CreateFieldLabel(string text)
        {
            return new TextBlock
            {
                Text = text,
                FontSize = 10.5,
                FontWeight = FontWeights.Bold,
                Foreground = BrushTextSecondary,
                Margin = new Thickness(2, 0, 0, 5)
            };
        }

        private static TextBox CreateModernTextBox(string svgIconPath, string placeholderText, bool monospace)
        {
            TextBox tb = new TextBox
            {
                Height = 36,
                Background = BrushBgInput,
                Foreground = BrushTextPrimary,
                CaretBrush = BrushBorderFocus,
                BorderBrush = BrushBorderDefault,
                BorderThickness = new Thickness(1),
                FontFamily = monospace ? new FontFamily("Consolas") : new FontFamily("Segoe UI"),
                FontSize = monospace ? 13.5 : 13,
                VerticalContentAlignment = VerticalAlignment.Center,
                Padding = new Thickness(10, 0, 10, 0),
                Tag = placeholderText ?? string.Empty,
                ToolTip = placeholderText
            };

            string safePath = string.IsNullOrEmpty(svgIconPath) ? SvgSearch : svgIconPath;

            string templateXaml = string.Format(@"
<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
                 TargetType='{{x:Type TextBox}}'>
    <Border x:Name='Bd'
            Background='{{TemplateBinding Background}}'
            BorderBrush='{{TemplateBinding BorderBrush}}'
            BorderThickness='{{TemplateBinding BorderThickness}}'
            CornerRadius='8'>
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width='34'/>
                <ColumnDefinition Width='*'/>
            </Grid.ColumnDefinitions>
            <Path Grid.Column='0'
                  Data='{0}'
                  Stroke='#64748B'
                  StrokeThickness='1.8'
                  Stretch='Uniform'
                  Width='14' Height='14'
                  HorizontalAlignment='Center'
                  VerticalAlignment='Center'
                  Margin='4,0,0,0'/>
            <ScrollViewer Grid.Column='1'
                          x:Name='PART_ContentHost'
                          Margin='2,0,10,0'
                          VerticalAlignment='Center'/>
            <TextBlock Grid.Column='1'
                       x:Name='Watermark'
                       Text='{{TemplateBinding Tag}}'
                       Foreground='#64748B'
                       FontSize='12.5'
                       VerticalAlignment='Center'
                       Margin='4,0,10,0'
                       IsHitTestVisible='False'
                       Visibility='Collapsed'/>
        </Grid>
    </Border>
    <ControlTemplate.Triggers>
        <Trigger Property='Text' Value=''>
            <Setter TargetName='Watermark' Property='Visibility' Value='Visible'/>
        </Trigger>
        <Trigger Property='IsKeyboardFocused' Value='True'>
            <Setter TargetName='Bd' Property='BorderBrush' Value='#38BDF8'/>
            <Setter TargetName='Bd' Property='Background' Value='#0F172A'/>
        </Trigger>
        <Trigger Property='IsMouseOver' Value='True'>
            <Setter TargetName='Bd' Property='BorderBrush' Value='#475569'/>
        </Trigger>
    </ControlTemplate.Triggers>
</ControlTemplate>", safePath);

            tb.Template = (ControlTemplate)XamlReader.Parse(templateXaml);
            return tb;
        }

        private static CheckBox CreateRowCheckBox(bool isChecked)
        {
            CheckBox cb = new CheckBox
            {
                IsChecked = isChecked,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 10, 0),
                Cursor = Cursors.Hand
            };

            string templateXaml = @"
<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
                 TargetType='{x:Type CheckBox}'>
    <Border x:Name='Box'
            Width='18' Height='18'
            CornerRadius='5'
            Background='#090D16'
            BorderBrush='#475569'
            BorderThickness='1.5'>
        <Path x:Name='CheckMark'
              Data='M4 9.5L7.5 13L14 5.5'
              Stroke='White'
              StrokeThickness='2'
              StrokeStartLineCap='Round'
              StrokeEndLineCap='Round'
              StrokeLineJoin='Round'
              Visibility='Collapsed'/>
    </Border>
    <ControlTemplate.Triggers>
        <Trigger Property='IsChecked' Value='True'>
            <Setter TargetName='Box' Property='Background' Value='#2563EB'/>
            <Setter TargetName='Box' Property='BorderBrush' Value='#60A5FA'/>
            <Setter TargetName='CheckMark' Property='Visibility' Value='Visible'/>
        </Trigger>
        <Trigger Property='IsMouseOver' Value='True'>
            <Setter TargetName='Box' Property='BorderBrush' Value='#38BDF8'/>
        </Trigger>
    </ControlTemplate.Triggers>
</ControlTemplate>";

            cb.Template = (ControlTemplate)XamlReader.Parse(templateXaml);
            return cb;
        }

        private static Button CreateActionButton(
            string text,
            string svgPath,
            SolidColorBrush normalBg,
            SolidColorBrush hoverBg,
            Color borderColor,
            double width,
            double height)
        {
            StackPanel content = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            if (!string.IsNullOrEmpty(svgPath))
            {
                UIElement icon = CreateSvgIcon(svgPath, Colors.White, 15);
                content.Children.Add(icon);
            }

            content.Children.Add(new TextBlock
            {
                Text = text,
                FontSize = 12.5,
                FontWeight = FontWeights.SemiBold,
                Foreground = Brushes.White,
                Margin = new Thickness(string.IsNullOrEmpty(svgPath) ? 0 : 8, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center
            });

            Button btn = new Button
            {
                Width = width,
                Height = height,
                Background = normalBg,
                BorderBrush = new SolidColorBrush(borderColor),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                Content = content
            };

            btn.Template = CreateRoundedButtonTemplate(8);
            btn.MouseEnter += (s, e) => { if (btn.IsEnabled) btn.Background = hoverBg; };
            btn.MouseLeave += (s, e) => { if (btn.IsEnabled) btn.Background = normalBg; };
            return btn;
        }

        private static Button CreateSmallSecondaryButton(string text)
        {
            Button btn = new Button
            {
                Content = text,
                Height = 32,
                Padding = new Thickness(12, 0, 12, 0),
                Background = BrushBgElevated,
                Foreground = BrushTextPrimary,
                BorderBrush = BrushBorderDefault,
                BorderThickness = new Thickness(1),
                FontSize = 12,
                FontWeight = FontWeights.SemiBold,
                Cursor = Cursors.Hand
            };
            btn.Template = CreateRoundedButtonTemplate(7);
            btn.MouseEnter += (s, e) => { if (btn.IsEnabled) btn.Background = new SolidColorBrush(Color.FromRgb(51, 65, 85)); };
            btn.MouseLeave += (s, e) => { if (btn.IsEnabled) btn.Background = BrushBgElevated; };
            return btn;
        }

        private static Button CreateSegmentedTabButton(string text, bool active)
        {
            Button btn = new Button
            {
                Content = text,
                Height = 32,
                FontSize = 12.5,
                FontWeight = FontWeights.SemiBold,
                Cursor = Cursors.Hand,
                BorderThickness = new Thickness(0)
            };
            btn.Template = CreateRoundedButtonTemplate(6);
            ApplySegmentedTabVisual(btn, active);
            return btn;
        }

        private static void ApplySegmentedTabVisual(Button btn, bool active)
        {
            if (active)
            {
                btn.Background = BrushPrimaryBlue;
                btn.Foreground = Brushes.White;
            }
            else
            {
                btn.Background = Brushes.Transparent;
                btn.Foreground = BrushTextSecondary;
            }
        }

        private static Button CreateSegmentedOptionButton(string text, bool active)
        {
            Button btn = new Button
            {
                Content = text,
                Height = 30,
                Margin = new Thickness(0, 0, 4, 0),
                FontSize = 11.5,
                FontWeight = FontWeights.SemiBold,
                Cursor = Cursors.Hand,
                BorderThickness = new Thickness(1)
            };
            btn.Template = CreateRoundedButtonTemplate(6);
            ApplySegmentedOptionVisual(btn, active);
            return btn;
        }

        private static void ApplySegmentedOptionVisual(Button btn, bool active)
        {
            if (active)
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(30, 58, 138));
                btn.BorderBrush = new SolidColorBrush(Color.FromRgb(59, 130, 246));
                btn.Foreground = new SolidColorBrush(Color.FromRgb(224, 242, 254));
            }
            else
            {
                btn.Background = BrushBgSurface;
                btn.BorderBrush = BrushBorderDefault;
                btn.Foreground = BrushTextSecondary;
            }
        }

        private static ControlTemplate CreateRoundedButtonTemplate(int radius)
        {
            string xaml = string.Format(@"
<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
                 TargetType='{{x:Type Button}}'>
    <Border Background='{{TemplateBinding Background}}'
            BorderBrush='{{TemplateBinding BorderBrush}}'
            BorderThickness='{{TemplateBinding BorderThickness}}'
            CornerRadius='{0}'
            Padding='{{TemplateBinding Padding}}'>
        <ContentPresenter HorizontalAlignment='Center' VerticalAlignment='Center'/>
    </Border>
</ControlTemplate>", radius);

            return (ControlTemplate)XamlReader.Parse(xaml);
        }

        private static CheckBox CreateOptionPillCheckBox(string text, bool isChecked, bool highlightAccent)
        {
            CheckBox cb = new CheckBox
            {
                Content = text,
                IsChecked = isChecked,
                Foreground = highlightAccent ? new SolidColorBrush(Color.FromRgb(125, 211, 252)) : BrushTextPrimary,
                FontSize = 12,
                FontWeight = highlightAccent ? FontWeights.SemiBold : FontWeights.Normal,
                Margin = new Thickness(0, 0, 18, 0),
                VerticalContentAlignment = VerticalAlignment.Center,
                Cursor = Cursors.Hand
            };

            string templateXaml = @"
<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
                 TargetType='{x:Type CheckBox}'>
    <Border x:Name='Pill'
            Background='#0B1120'
            BorderBrush='#334155'
            BorderThickness='1'
            CornerRadius='7'
            Padding='10,5,12,5'>
        <StackPanel Orientation='Horizontal' VerticalAlignment='Center'>
            <Border x:Name='Box'
                    Width='16' Height='16'
                    CornerRadius='4'
                    Background='#111827'
                    BorderBrush='#475569'
                    BorderThickness='1'
                    Margin='0,0,8,0'>
                <Path x:Name='CheckMark'
                      Data='M3.5 8.5L6.5 11.5L12.5 4.5'
                      Stroke='White'
                      StrokeThickness='2'
                      Visibility='Collapsed'/>
            </Border>
            <ContentPresenter VerticalAlignment='Center'/>
        </StackPanel>
    </Border>
    <ControlTemplate.Triggers>
        <Trigger Property='IsChecked' Value='True'>
            <Setter TargetName='Box' Property='Background' Value='#2563EB'/>
            <Setter TargetName='Box' Property='BorderBrush' Value='#60A5FA'/>
            <Setter TargetName='CheckMark' Property='Visibility' Value='Visible'/>
            <Setter TargetName='Pill' Property='BorderBrush' Value='#1E3A8A'/>
            <Setter TargetName='Pill' Property='Background' Value='#0F172A'/>
        </Trigger>
        <Trigger Property='IsMouseOver' Value='True'>
            <Setter TargetName='Pill' Property='BorderBrush' Value='#38BDF8'/>
        </Trigger>
    </ControlTemplate.Triggers>
</ControlTemplate>";

            cb.Template = (ControlTemplate)XamlReader.Parse(templateXaml);
            return cb;
        }

        private static UIElement CreateSvgIcon(string pathData, Color strokeColor, double size)
        {
            System.Windows.Shapes.Path path = new System.Windows.Shapes.Path
            {
                Data = Geometry.Parse(pathData),
                Stroke = new SolidColorBrush(strokeColor),
                StrokeThickness = 2,
                StrokeStartLineCap = PenLineCap.Round,
                StrokeEndLineCap = PenLineCap.Round,
                StrokeLineJoin = PenLineJoin.Round,
                Stretch = Stretch.Uniform,
                Width = size,
                Height = size,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            return path;
        }

        private static UIElement BuildEmptyStateBlock(string title, string subtitle)
        {
            Border box = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(24),
                Margin = new Thickness(4, 16, 4, 4)
            };

            StackPanel sp = new StackPanel { HorizontalAlignment = HorizontalAlignment.Center };
            sp.Children.Add(CreateSvgIcon(SvgSearch, ColTextMuted, 28));
            sp.Children.Add(new TextBlock
            {
                Text = title,
                FontSize = 14,
                FontWeight = FontWeights.SemiBold,
                Foreground = BrushTextPrimary,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 10, 0, 4)
            });
            sp.Children.Add(new TextBlock
            {
                Text = subtitle,
                FontSize = 12,
                Foreground = BrushTextSecondary,
                TextWrapping = TextWrapping.Wrap,
                TextAlignment = TextAlignment.Center,
                MaxWidth = 380
            });

            box.Child = sp;
            return box;
        }

        // ── Navegação de Abas Segmentadas ──────────────────────────────────────────

        private void SwitchLeftTab(bool showCompilables)
        {
            ApplySegmentedTabVisual(_btnTabCompilables, showCompilables);
            ApplySegmentedTabVisual(_btnTabOccurrences, !showCompilables);
            _viewCompilables.Visibility = showCompilables ? Visibility.Visible : Visibility.Collapsed;
            _viewOccurrences.Visibility = showCompilables ? Visibility.Collapsed : Visibility.Visible;
        }

        public void SwitchRightTab(bool showCodePreview)
        {
            ApplySegmentedTabVisual(_btnTabCodePreview, showCodePreview);
            ApplySegmentedTabVisual(_btnTabScriptPreview, !showCodePreview);
            _viewCodePreview.Visibility = showCodePreview ? Visibility.Visible : Visibility.Collapsed;
            _viewScriptPreview.Visibility = showCodePreview ? Visibility.Collapsed : Visibility.Visible;

            if (_findBarBorder != null)
            {
                _findBarBorder.Margin = showCodePreview
                    ? new Thickness(0, 48, 20, 0)
                    : new Thickness(0, 94, 20, 0);

                if (_findBarBorder.Visibility == Visibility.Visible && _txtEditorFind != null && !string.IsNullOrEmpty(_txtEditorFind.Text))
                {
                    ExecuteEditorFind(false);
                }
            }
        }

        // ── Eventos de Busca e Ações ───────────────────────────────────────────────

        private void OnBrowseDirectoryClick(object sender, RoutedEventArgs e)
        {
            using (WinForms.FolderBrowserDialog dlg = new WinForms.FolderBrowserDialog())
            {
                dlg.Description = "Selecione o diretório raiz dos programas Progress Datasul:";
                string currentDir = _txtRootDir.Text.Trim().Trim('"', '\'');
                if (!string.IsNullOrWhiteSpace(currentDir) && Directory.Exists(currentDir))
                {
                    dlg.SelectedPath = currentDir;
                }

                if (dlg.ShowDialog() == WinForms.DialogResult.OK)
                {
                    _txtRootDir.Text = dlg.SelectedPath;
                    AppCacheService.AddRecentDirectory(_cacheData, dlg.SelectedPath);
                    SaveCurrentStateToCache();
                }
            }
        }

        private void OnSearchTermKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                OnSearchClick(sender, new RoutedEventArgs());
            }
        }

        private async void OnSearchClick(object sender, RoutedEventArgs e)
        {
            string rootDir = _txtRootDir.Text.Trim().Trim('"', '\'');
            string searchTerm = _txtSearchTerm.Text.Trim();

            if (string.IsNullOrEmpty(rootDir) || !Directory.Exists(rootDir))
            {
                MessageBox.Show(this,
                    "Selecione um diretório válido onde estão os programas Progress Datasul.",
                    "Diretório Inválido",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show(this,
                    "Informe a palavra ou nome da tabela que deseja buscar (ex: es-teste-123).",
                    "Termo de Busca Obrigatório",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                _txtSearchTerm.Focus();
                return;
            }

            // Registra no cache o diretório, o termo pesquisado e todas as opções atuais
            AppCacheService.AddRecentDirectory(_cacheData, rootDir);
            AppCacheService.AddRecentSearchTerm(_cacheData, searchTerm);
            SaveCurrentStateToCache();

            SearchOptions options = BuildSearchOptionsFromUI(rootDir, searchTerm);
            SetSearchingState(true);

            _cts = new CancellationTokenSource();
            IProgress<SearchProgressInfo> progress = new Progress<SearchProgressInfo>(info =>
            {
                if (info.TotalFiles <= 0)
                {
                    _mainProgressBar.IsIndeterminate = true;
                    _progressBar.IsIndeterminate = true;
                    _lblProgressTitle.Text = "MAPEANDO DIRETÓRIOS PROGRESS...";
                    _lblProgressCounter.Text = string.Format("{0:N0} arquivos localizados", info.ProcessedFiles);
                    _lblProgressPercent.Text = "...";
                    _lblProgressCurrentFile.Text = !string.IsNullOrEmpty(info.CurrentFile)
                        ? "Pasta: " + info.CurrentFile
                        : info.PhaseMessage;
                    _lblKpiScanned.Text = info.ProcessedFiles.ToString("N0");
                    _lblKpiScannedSub.Text = "Mapeando pastas...";
                }
                else
                {
                    int safeProcessed = Math.Min(info.ProcessedFiles, info.TotalFiles);
                    int pct = (int)Math.Round((safeProcessed * 100.0) / info.TotalFiles);

                    _mainProgressBar.IsIndeterminate = false;
                    _mainProgressBar.Maximum = info.TotalFiles;
                    _mainProgressBar.Value = safeProcessed;

                    _progressBar.IsIndeterminate = false;
                    _progressBar.Maximum = info.TotalFiles;
                    _progressBar.Value = safeProcessed;

                    _lblProgressTitle.Text = safeProcessed >= info.TotalFiles
                        ? "RASTREANDO DEPENDÊNCIAS DE INCLUDES (.I)..."
                        : "VARRENDO PROGRAMAS PROGRESS 4GL / ABL...";
                    _lblProgressCounter.Text = string.Format("{0:N0} de {1:N0} arquivos", safeProcessed, info.TotalFiles);
                    _lblProgressPercent.Text = string.Format("{0}%", pct);
                    _lblProgressCurrentFile.Text = !string.IsNullOrEmpty(info.CurrentFile)
                        ? "Analisando: " + info.CurrentFile
                        : info.PhaseMessage;

                    _lblKpiScanned.Text = safeProcessed.ToString("N0");
                    _lblKpiScannedSub.Text = string.Format("{0}% de {1:N0} arquivos", pct, info.TotalFiles);
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
                _mainProgressBar.IsIndeterminate = false;
                _lblProgressTitle.Text = "VARREDURA CANCELADA PELO USUÁRIO";
                _lblProgressCurrentFile.Text = "Operação interrompida.";
                _lblStatus.Text = "Varredura cancelada pelo usuário.";
            }
            catch (Exception ex)
            {
                _mainProgressBar.IsIndeterminate = false;
                _mainProgressBar.Foreground = BrushDanger;
                _lblProgressTitle.Text = "ERRO DURANTE A VARREDURA";
                _lblProgressCurrentFile.Text = ex.Message;
                _lblStatus.Text = "Erro na busca: " + ex.Message;
                MessageBox.Show(this, ex.Message, "Erro durante a varredura", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                SetSearchingState(false);
            }
        }

        private void OnCancelSearchClick(object sender, RoutedEventArgs e)
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
                TrackIncludes = _chkTrackIncludes.IsChecked == true,
                IgnoreComments = _chkIgnoreComments.IsChecked == true,
                WholeWord = _chkWholeWord.IsChecked == true,
                CaseSensitive = _chkCaseSensitive.IsChecked == true
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
            _btnSearch.IsEnabled = !searching;
            _btnSearch.Opacity = searching ? 0.5 : 1.0;
            _btnCancel.IsEnabled = searching;
            _btnCancel.Opacity = searching ? 1.0 : 0.45;
            _btnBrowseDir.IsEnabled = !searching;
            if (_btnRecentDirs != null) _btnRecentDirs.IsEnabled = !searching;
            if (_btnRecentTerms != null) _btnRecentTerms.IsEnabled = !searching;
            _progressBar.Visibility = searching ? Visibility.Visible : Visibility.Collapsed;
            _statusDot.Fill = searching ? BrushBorderFocus : BrushEmeraldHover;
            if (searching)
            {
                _progressBar.IsIndeterminate = true;
                _progressBar.Value = 0;

                _scanProgressBorder.BorderBrush = BrushBorderFocus;
                _mainProgressBar.Foreground = BrushBorderFocus;
                _mainProgressBar.IsIndeterminate = true;
                _mainProgressBar.Minimum = 0;
                _mainProgressBar.Maximum = 100;
                _mainProgressBar.Value = 0;

                _lblProgressTitle.Text = "INICIANDO VARREDURA DE DIRETÓRIOS...";
                _lblProgressTitle.Foreground = BrushTextPrimary;
                _lblProgressCounter.Text = "Localizando arquivos...";
                _lblProgressPercent.Text = "0%";
                _lblProgressPercent.Foreground = BrushBorderFocus;
                _lblProgressCurrentFile.Text = "Mapeando pastas em: " + _txtRootDir.Text.Trim();
            }
        }

        // ── Carregamento de Resultados na UI ───────────────────────────────────────

        public void LoadReportIntoUI(SearchReport report)
        {
            _currentReport = report;
            _txtRootDir.Text = report.Options.RootDirectory;
            _txtSearchTerm.Text = report.Options.SearchTerm;

            PopulateCompilablesListView();
            PopulateOccurrencesTreeView();
            RefreshScriptPreview();
            UpdateKpiCards();

            int totalCompilables = report.CompilableResults.Count;
            int totalIncludes = report.AllResults.Count(r => !r.IsCompilable);

            _btnTabCompilables.Content = string.Format("Programas p/ Compilar ({0})", totalCompilables);
            _btnTabOccurrences.Content = string.Format("Árvore VS Code ({0})", report.AllResults.Count);

            int maxBar = Math.Max(1, report.TotalFilesScanned);
            _mainProgressBar.IsIndeterminate = false;
            _mainProgressBar.Minimum = 0;
            _mainProgressBar.Maximum = maxBar;
            _mainProgressBar.Value = maxBar;
            _mainProgressBar.Foreground = BrushEmeraldHover;
            _scanProgressBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(16, 185, 129));

            _lblProgressTitle.Text = string.Format("VARREDURA CONCLUÍDA COM SUCESSO ({0} ms)", report.ElapsedMilliseconds);
            _lblProgressTitle.Foreground = BrushEmeraldHover;
            _lblProgressCounter.Text = string.Format("{0:N0} / {0:N0} arquivos", report.TotalFilesScanned);
            _lblProgressPercent.Text = "100%";
            _lblProgressPercent.Foreground = BrushEmeraldHover;
            _lblProgressCurrentFile.Text = string.Format(
                "Resultado para '{0}': {1} programas compiláveis (.p/.w/.cls) e {2} includes (.i) impactados.",
                report.Options.SearchTerm,
                totalCompilables,
                totalIncludes);

            _lblStatus.Text = string.Format(
                "Varredura concluída em {0} ms • {1} arquivos analisados • {2} programas compiláveis • {3} includes (.i)",
                report.ElapsedMilliseconds,
                report.TotalFilesScanned,
                totalCompilables,
                totalIncludes);

            if (report.CompilableResults.Count > 0)
            {
                FileSearchResult first = report.CompilableResults.FirstOrDefault(r => r.IsDirectMatch)
                    ?? report.CompilableResults[0];
                ShowFileInCodePreview(first, GetFirstRelevantLine(first));
            }
            else if (report.AllResults.Count > 0)
            {
                FileSearchResult first = report.AllResults[0];
                ShowFileInCodePreview(first, GetFirstRelevantLine(first));
            }
            else
            {
                SetRichTextPlain(_rtbCodePreview, string.Empty);
                _lblCodePreviewFile.Text = "Nenhuma ocorrência encontrada para '" + report.Options.SearchTerm + "'.";
                _lblCodePreviewLineBadge.Text = "0 ocorr.";
                _btnOpenFolder.IsEnabled = false;
            }
        }

        private void UpdateKpiCards()
        {
            if (_currentReport == null)
            {
                _lblKpiScanned.Text = "0";
                _lblKpiCompilables.Text = "0";
                _lblKpiViaInclude.Text = "0";
                _lblKpiSelected.Text = "0";
                return;
            }

            int viaIncludeCount = _currentReport.CompilableResults.Count(r => r.IsIncludeMatch);
            int selectedCount = _currentReport.CompilableResults.Count(r => r.SelectedForCompile);

            _lblKpiScanned.Text = _currentReport.TotalFilesScanned.ToString("N0");
            _lblKpiScannedSub.Text = string.Format("Concluído em {0} ms", _currentReport.ElapsedMilliseconds);
            _lblKpiCompilables.Text = _currentReport.CompilableResults.Count.ToString("N0");
            _lblKpiViaInclude.Text = viaIncludeCount.ToString("N0");
            _lblKpiSelected.Text = selectedCount.ToString("N0");
        }

        private void PopulateCompilablesListView()
        {
            _spCompilableItems.Children.Clear();
            _compilableRenderedCount = 0;
            _selectedProgramCardBorder = null;

            if (_currentReport == null || _currentReport.CompilableResults.Count == 0)
            {
                _spCompilableItems.Children.Add(BuildEmptyStateBlock(
                    "Nenhum programa compilável encontrado",
                    "Verifique o termo pesquisado ou as extensões selecionadas."));
                return;
            }

            string filter = _txtFilterCompilables.Text.Trim();

            foreach (FileSearchResult item in _currentReport.CompilableResults)
            {
                if (!string.IsNullOrEmpty(filter) &&
                    item.RelativePath.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                UIElement rowCard = CreateCompilableProgramRowCard(item);
                _spCompilableItems.Children.Add(rowCard);
                _compilableRenderedCount++;
            }
        }

        private UIElement CreateCompilableProgramRowCard(FileSearchResult item)
        {
            Border rowBorder = new Border
            {
                Background = BrushBgInput,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(10, 8, 10, 8),
                Margin = new Thickness(0, 0, 4, 6),
                Cursor = Cursors.Hand
            };

            Grid g = new Grid();
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Checkbox
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // Info
            g.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Badges

            CheckBox cb = CreateRowCheckBox(item.SelectedForCompile);
            cb.Checked += (s, e) =>
            {
                item.SelectedForCompile = true;
                UpdateKpiCards();
                RefreshScriptPreview();
            };
            cb.Unchecked += (s, e) =>
            {
                item.SelectedForCompile = false;
                UpdateKpiCards();
                RefreshScriptPreview();
            };
            Grid.SetColumn(cb, 0);
            g.Children.Add(cb);

            StackPanel infoStack = new StackPanel { VerticalAlignment = VerticalAlignment.Center };

            StackPanel titleRow = new StackPanel { Orientation = Orientation.Horizontal };
            titleRow.Children.Add(CreateExtensionBadge(item.Extension));
            titleRow.Children.Add(new TextBlock
            {
                Text = item.RelativePath,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                FontWeight = FontWeights.SemiBold,
                Foreground = BrushTextPrimary,
                VerticalAlignment = VerticalAlignment.Center
            });
            infoStack.Children.Add(titleRow);

            string detailText;
            if (item.IsIncludeMatch && item.IncludeMatches.Count > 0)
            {
                detailText = "Cadeia: " + item.IncludeMatches[0].ChainDescription;
            }
            else if (item.DirectMatches.Count > 0)
            {
                detailText = string.Format("Linha {0}: {1}", item.DirectMatches[0].LineNumber, item.DirectMatches[0].LineText.Trim());
            }
            else
            {
                detailText = string.Empty;
            }

            if (!string.IsNullOrEmpty(detailText))
            {
                infoStack.Children.Add(new TextBlock
                {
                    Text = detailText,
                    FontFamily = new FontFamily("Consolas"),
                    FontSize = 11,
                    Foreground = BrushTextSecondary,
                    TextTrimming = TextTrimming.CharacterEllipsis,
                    Margin = new Thickness(0, 3, 0, 0)
                });
            }

            Grid.SetColumn(infoStack, 1);
            g.Children.Add(infoStack);

            // Badges à direita (DIRETO / VIA INCLUDE + Contagem)
            StackPanel rightBadges = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(8, 0, 0, 0)
            };

            bool isViaInc = item.IsIncludeMatch && !item.IsDirectMatch;
            rightBadges.Children.Add(CreateSemanticBadge(
                item.IsDirectMatch && item.IsIncludeMatch ? "DIRETO + .I" : (isViaInc ? "VIA INCLUDE .I" : "DIRETO"),
                isViaInc ? Color.FromRgb(12, 74, 110) : Color.FromRgb(6, 78, 59),
                isViaInc ? Color.FromRgb(2, 132, 199) : Color.FromRgb(5, 150, 105),
                isViaInc ? Color.FromRgb(56, 189, 248) : Color.FromRgb(52, 211, 153)));

            rightBadges.Children.Add(CreateSemanticBadge(
                string.Format("{0}x", item.TotalOccurrences),
                ColBgSurface,
                ColBorderDefault,
                ColTextSecondary));

            Grid.SetColumn(rightBadges, 2);
            g.Children.Add(rightBadges);

            rowBorder.Child = g;

            rowBorder.MouseLeftButtonDown += (s, e) =>
            {
                if (_selectedProgramCardBorder != null)
                {
                    _selectedProgramCardBorder.BorderBrush = BrushBorderSubtle;
                    _selectedProgramCardBorder.Background = BrushBgInput;
                }
                _selectedProgramCardBorder = rowBorder;
                rowBorder.BorderBrush = BrushBorderFocus;
                rowBorder.Background = new SolidColorBrush(Color.FromRgb(15, 23, 42));

                ShowFileInCodePreview(item, GetFirstRelevantLine(item));
            };

            return rowBorder;
        }

        private static Border CreateExtensionBadge(string ext)
        {
            string label = (ext ?? ".p").ToUpperInvariant();
            Color bg = Color.FromRgb(30, 27, 75);
            Color fg = Color.FromRgb(165, 180, 252);

            if (label == ".W")
            {
                bg = Color.FromRgb(59, 7, 100);
                fg = Color.FromRgb(216, 180, 254);
            }
            else if (label == ".CLS")
            {
                bg = Color.FromRgb(69, 26, 3);
                fg = Color.FromRgb(252, 211, 77);
            }
            else if (label == ".I")
            {
                bg = Color.FromRgb(67, 20, 7);
                fg = Color.FromRgb(253, 186, 116);
            }

            return new Border
            {
                Background = new SolidColorBrush(bg),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(5, 1, 5, 1),
                Margin = new Thickness(0, 0, 7, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock
                {
                    Text = label,
                    FontFamily = new FontFamily("Consolas"),
                    FontSize = 10,
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush(fg)
                }
            };
        }

        private static Border CreateSemanticBadge(string text, Color bg, Color border, Color fg)
        {
            return new Border
            {
                Background = new SolidColorBrush(bg),
                BorderBrush = new SolidColorBrush(border),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(7, 2, 7, 2),
                Margin = new Thickness(4, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock
                {
                    Text = text,
                    FontSize = 10,
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush(fg)
                }
            };
        }

        private void PopulateOccurrencesTreeView()
        {
            _spOccurrenceTree.Children.Clear();
            _treeFileNodesCount = 0;

            if (_currentReport == null || _currentReport.AllResults.Count == 0)
            {
                _spOccurrenceTree.Children.Add(BuildEmptyStateBlock(
                    "Nenhuma ocorrência para exibir",
                    "Realize uma busca para visualizar a árvore de arquivos e linhas no estilo VS Code."));
                return;
            }

            foreach (FileSearchResult fileResult in _currentReport.AllResults)
            {
                _treeFileNodesCount++;

                Border fileCard = new Border
                {
                    Background = BrushBgInput,
                    BorderBrush = BrushBorderSubtle,
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10, 8, 10, 8),
                    Margin = new Thickness(0, 0, 4, 8)
                };

                StackPanel fileStack = new StackPanel();

                // Header do Arquivo
                StackPanel headerRow = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(0, 0, 0, 6),
                    Cursor = Cursors.Hand
                };
                headerRow.Children.Add(CreateExtensionBadge(fileResult.Extension));
                headerRow.Children.Add(new TextBlock
                {
                    Text = fileResult.RelativePath,
                    FontFamily = new FontFamily("Consolas"),
                    FontSize = 12.5,
                    FontWeight = FontWeights.Bold,
                    Foreground = BrushTextPrimary,
                    VerticalAlignment = VerticalAlignment.Center
                });
                headerRow.Children.Add(CreateSemanticBadge(
                    fileResult.IsCompilable ? "COMPILÁVEL" : "INCLUDE .I",
                    fileResult.IsCompilable ? Color.FromRgb(6, 78, 59) : Color.FromRgb(69, 26, 3),
                    fileResult.IsCompilable ? Color.FromRgb(5, 150, 105) : Color.FromRgb(217, 119, 6),
                    fileResult.IsCompilable ? Color.FromRgb(52, 211, 153) : Color.FromRgb(251, 191, 36)));

                FileSearchResult capturedFile = fileResult;
                headerRow.MouseLeftButtonDown += (s, e) =>
                {
                    ShowFileInCodePreview(capturedFile, GetFirstRelevantLine(capturedFile));
                    SwitchRightTab(true);
                };
                fileStack.Children.Add(headerRow);

                // Linhas diretas encontradas
                foreach (LineMatch match in fileResult.DirectMatches)
                {
                    int lineNo = match.LineNumber;
                    Border lineBtn = CreateTreeLineItem(
                        string.Format("Linha {0,4}", lineNo),
                        match.LineText.Trim(),
                        Color.FromRgb(56, 189, 248),
                        () =>
                        {
                            ShowFileInCodePreview(capturedFile, lineNo);
                            SwitchRightTab(true);
                        });
                    fileStack.Children.Add(lineBtn);
                }

                // Linhas de Include
                foreach (IncludeChainStep step in fileResult.IncludeMatches)
                {
                    int lineNo = step.LineNumber;
                    Border incBtn = CreateTreeLineItem(
                        string.Format("Linha {0,4} [Include]", lineNo),
                        string.Format("{0}   ({1})", step.LineText.Trim(), step.ChainDescription),
                        Color.FromRgb(129, 140, 248),
                        () =>
                        {
                            ShowFileInCodePreview(capturedFile, lineNo);
                            SwitchRightTab(true);
                        });
                    fileStack.Children.Add(incBtn);
                }

                fileCard.Child = fileStack;
                _spOccurrenceTree.Children.Add(fileCard);
            }
        }

        private static Border CreateTreeLineItem(string lineBadgeText, string codeSnippet, Color badgeColor, Action onClick)
        {
            Border b = new Border
            {
                Background = BrushBgSurface,
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(8, 5, 8, 5),
                Margin = new Thickness(12, 2, 0, 2),
                Cursor = Cursors.Hand
            };

            StackPanel sp = new StackPanel { Orientation = Orientation.Horizontal };
            sp.Children.Add(new TextBlock
            {
                Text = lineBadgeText + " : ",
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11.5,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(badgeColor)
            });
            sp.Children.Add(new TextBlock
            {
                Text = codeSnippet,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11.5,
                Foreground = BrushTextSecondary,
                TextTrimming = TextTrimming.CharacterEllipsis
            });

            b.Child = sp;
            b.MouseEnter += (s, e) => b.Background = BrushBgElevated;
            b.MouseLeave += (s, e) => b.Background = BrushBgSurface;
            b.MouseLeftButtonDown += (s, e) => onClick();
            return b;
        }

        private void SetAllCompilableChecks(bool checkState)
        {
            if (_currentReport == null)
            {
                return;
            }

            foreach (FileSearchResult item in _currentReport.CompilableResults)
            {
                item.SelectedForCompile = checkState;
            }

            PopulateCompilablesListView();
            UpdateKpiCards();
            RefreshScriptPreview();
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

        // ── Visualizador de Código com Destaque de Linha e Termo ──────────────────

        private void ShowFileInCodePreview(FileSearchResult result, int targetLineNumber)
        {
            if (result == null || !File.Exists(result.FilePath))
            {
                return;
            }

            _currentPreviewFilePath = result.FilePath;
            _btnOpenFolder.IsEnabled = true;
            _lblCodePreviewFile.Text = result.RelativePath;
            _lblCodePreviewLineBadge.Text = string.Format("Linha {0}", targetLineNumber);

            string content;
            try
            {
                content = ProgressCodeAnalyzer.ReadFileWithAutoEncoding(result.FilePath);
            }
            catch (Exception ex)
            {
                SetRichTextPlain(_rtbCodePreview, "Erro ao ler arquivo: " + ex.Message);
                return;
            }

            string[] lines = ProgressCodeAnalyzer.SplitLines(content);
            string searchTerm = _currentReport != null ? _currentReport.Options.SearchTerm : string.Empty;
            StringComparison cmp = (_currentReport != null && _currentReport.Options.CaseSensitive)
                ? StringComparison.Ordinal
                : StringComparison.OrdinalIgnoreCase;

            FlowDocument doc = new FlowDocument
            {
                PageWidth = 2400,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                PagePadding = new Thickness(8)
            };

            Paragraph para = new Paragraph { Margin = new Thickness(0), LineHeight = 20 };
            Run targetRunToBringIntoView = null;

            for (int i = 0; i < lines.Length; i++)
            {
                int lineNo = i + 1;
                bool isTargetLine = (lineNo == targetLineNumber);

                Run gutterRun = new Run(string.Format("{0,5} │ ", lineNo))
                {
                    Tag = "GUTTER",
                    Foreground = isTargetLine
                        ? new SolidColorBrush(Color.FromRgb(56, 189, 248))
                        : BrushTextMuted,
                    FontWeight = isTargetLine ? FontWeights.Bold : FontWeights.Normal
                };

                if (isTargetLine)
                {
                    gutterRun.Background = new SolidColorBrush(Color.FromRgb(30, 58, 95));
                    targetRunToBringIntoView = gutterRun;
                }

                para.Inlines.Add(gutterRun);

                string lineText = lines[i];
                AppendLineWithTermHighlight(para, lineText, searchTerm, cmp, isTargetLine);
                para.Inlines.Add(new LineBreak());
            }

            doc.Blocks.Add(para);
            _rtbCodePreview.Document = doc;

            if (targetRunToBringIntoView != null)
            {
                targetRunToBringIntoView.BringIntoView();
            }

            if (_findBarBorder != null && _findBarBorder.Visibility == Visibility.Visible && _txtEditorFind != null && !string.IsNullOrEmpty(_txtEditorFind.Text))
            {
                ExecuteEditorFind(false);
            }
        }

        private static void AppendLineWithTermHighlight(
            Paragraph para,
            string lineText,
            string searchTerm,
            StringComparison cmp,
            bool isTargetLine)
        {
            SolidColorBrush lineBg = isTargetLine
                ? new SolidColorBrush(Color.FromRgb(30, 58, 95))
                : Brushes.Transparent;

            if (string.IsNullOrEmpty(searchTerm) || string.IsNullOrEmpty(lineText))
            {
                Run r = new Run(lineText ?? string.Empty)
                {
                    Foreground = isTargetLine ? Brushes.White : BrushTextPrimary,
                    Background = lineBg
                };
                para.Inlines.Add(r);
                return;
            }

            int idx = 0;
            while (idx < lineText.Length)
            {
                int found = lineText.IndexOf(searchTerm, idx, cmp);
                if (found < 0)
                {
                    Run tail = new Run(lineText.Substring(idx))
                    {
                        Foreground = isTargetLine ? Brushes.White : BrushTextPrimary,
                        Background = lineBg
                    };
                    para.Inlines.Add(tail);
                    break;
                }

                if (found > idx)
                {
                    Run before = new Run(lineText.Substring(idx, found - idx))
                    {
                        Foreground = isTargetLine ? Brushes.White : BrushTextPrimary,
                        Background = lineBg
                    };
                    para.Inlines.Add(before);
                }

                Run matchRun = new Run(lineText.Substring(found, searchTerm.Length))
                {
                    Background = new SolidColorBrush(Color.FromRgb(180, 83, 9)),
                    Foreground = new SolidColorBrush(Color.FromRgb(254, 240, 138)),
                    FontWeight = FontWeights.Bold
                };
                para.Inlines.Add(matchRun);

                idx = found + searchTerm.Length;
            }
        }

        // ── Geração e Exportação do Script .p ─────────────────────────────────────

        private CompileScriptOptions BuildCompileScriptOptions(string targetFilePath)
        {
            CompileScriptOptions opts = new CompileScriptOptions
            {
                ScriptMode = _scriptModeIndex == 0
                    ? CompileScriptMode.WithErrorLog
                    : CompileScriptMode.PureCompileSave,
                PathFormat = _pathFormatIndex == 0
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
                _cachedScriptPreviewText = "/* Realize uma busca para visualizar o script .p de compilacao gerado automaticamente. */";
                SetRichTextPlain(_rtbScriptPreview, _cachedScriptPreviewText);
                return;
            }

            CompileScriptOptions opts = BuildCompileScriptOptions(string.Empty);
            _cachedScriptPreviewText = _scriptGenerator.GenerateScript(_currentReport.CompilableResults, opts);
            SetRichTextPlain(_rtbScriptPreview, _cachedScriptPreviewText);

            if (_findBarBorder != null && _findBarBorder.Visibility == Visibility.Visible && _txtEditorFind != null && !string.IsNullOrEmpty(_txtEditorFind.Text))
            {
                ExecuteEditorFind(false);
            }
        }

        private static void SetRichTextPlain(RichTextBox rtb, string text)
        {
            FlowDocument doc = new FlowDocument
            {
                PageWidth = 2400,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 13,
                PagePadding = new Thickness(8)
            };
            string safeText = text ?? string.Empty;
            string[] lines = ProgressCodeAnalyzer.SplitLines(safeText);
            if (lines.Length == 0)
            {
                lines = new string[] { string.Empty };
            }

            foreach (string line in lines)
            {
                Run r = new Run(line);
                Paragraph p = new Paragraph(r)
                {
                    Margin = new Thickness(0),
                    LineHeight = 20
                };
                doc.Blocks.Add(p);
            }
            rtb.Document = doc;
        }

        private void OnSaveScriptClick(object sender, RoutedEventArgs e)
        {
            if (_currentReport == null || !_currentReport.CompilableResults.Any(r => r.SelectedForCompile))
            {
                MessageBox.Show(this,
                    "Não há programas compiláveis selecionados para gerar o arquivo .p.\nRealize uma busca e marque ao menos um programa.",
                    "Nenhum Programa Selecionado",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }

            string safeTerm = SanitizeFileName(_currentReport.Options.SearchTerm);
            string defaultFileName = string.IsNullOrEmpty(safeTerm)
                ? "compilar-programas.p"
                : string.Format("compilar-{0}.p", safeTerm);

            using (WinForms.SaveFileDialog dlg = new WinForms.SaveFileDialog())
            {
                dlg.Title = "Salvar Script Progress de Compilação (.p)";
                dlg.Filter = "Programa Progress ABL (*.p)|*.p|Todos os Arquivos (*.*)|*.*";
                dlg.FileName = defaultFileName;
                dlg.DefaultExt = "p";
                if (_cacheData != null && !string.IsNullOrWhiteSpace(_cacheData.LastExportDirectory) && Directory.Exists(_cacheData.LastExportDirectory))
                {
                    dlg.InitialDirectory = _cacheData.LastExportDirectory;
                }

                if (dlg.ShowDialog() == WinForms.DialogResult.OK)
                {
                    CompileScriptOptions opts = BuildCompileScriptOptions(dlg.FileName);
                    string finalScript = _scriptGenerator.GenerateScript(_currentReport.CompilableResults, opts);
                    _scriptGenerator.SaveScriptToFile(finalScript, dlg.FileName);

                    if (_cacheData != null)
                    {
                        try
                        {
                            _cacheData.LastExportDirectory = System.IO.Path.GetDirectoryName(dlg.FileName);
                            SaveCurrentStateToCache();
                        }
                        catch (Exception)
                        {
                        }
                    }

                    _cachedScriptPreviewText = finalScript;
                    SetRichTextPlain(_rtbScriptPreview, finalScript);
                    SwitchRightTab(false);

                    _lblStatus.Text = "Arquivo .p salvo com sucesso em: " + dlg.FileName;
                    MessageBox.Show(this,
                        string.Format("Script de compilação salvo com sucesso!\n\nArquivo: {0}\nProgramas incluídos: {1}",
                            dlg.FileName,
                            _currentReport.CompilableResults.Count(r => r.SelectedForCompile)),
                        "Script .p Gerado",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
        }

        private void OnCopyScriptClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_cachedScriptPreviewText))
            {
                return;
            }

            Clipboard.SetText(_cachedScriptPreviewText);
            _lblStatus.Text = "Código do script .p copiado para a área de transferência!";
        }

        private void OnOpenFolderClick(object sender, RoutedEventArgs e)
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
            char[] invalid = System.IO.Path.GetInvalidFileNameChars();
            return new string(input.Trim().Select(c => invalid.Contains(c) ? '-' : c).ToArray());
        }

        // ── Persistência em Cache (Configurações, Diretórios e Termos Recentes) ────

        private void ApplyCacheToUI()
        {
            _isLoadingCache = true;
            try
            {
                if (_cacheData == null)
                {
                    _cacheData = new AppCacheData();
                }

                if (!string.IsNullOrWhiteSpace(_cacheData.LastRootDirectory))
                {
                    _txtRootDir.Text = _cacheData.LastRootDirectory;
                }
                if (!string.IsNullOrWhiteSpace(_cacheData.LastSearchTerm))
                {
                    _txtSearchTerm.Text = _cacheData.LastSearchTerm;
                }
                if (!string.IsNullOrWhiteSpace(_cacheData.Extensions))
                {
                    _txtExtensions.Text = _cacheData.Extensions;
                }

                _chkTrackIncludes.IsChecked = _cacheData.TrackIncludes;
                _chkIgnoreComments.IsChecked = _cacheData.IgnoreComments;
                _chkWholeWord.IsChecked = _cacheData.WholeWord;
                _chkCaseSensitive.IsChecked = _cacheData.CaseSensitive;

                if (!string.IsNullOrEmpty(_cacheData.FilterText) && _txtFilterCompilables != null)
                {
                    _txtFilterCompilables.Text = _cacheData.FilterText;
                }

                int modeIdx = (_cacheData.ScriptModeIndex == 1) ? 1 : 0;
                int pathIdx = (_cacheData.PathFormatIndex == 0) ? 0 : 1; // 1 = Caminho Absoluto por padrão

                SetScriptModeIndex(modeIdx);
                SetPathFormatIndex(pathIdx);
                UpdateRecentButtonsTooltip();
            }
            finally
            {
                _isLoadingCache = false;
            }
        }

        private void HookAutoSaveCacheEvents()
        {
            _txtRootDir.LostFocus += (s, e) => SaveCurrentStateToCache();
            _txtSearchTerm.LostFocus += (s, e) => SaveCurrentStateToCache();
            _txtExtensions.LostFocus += (s, e) => SaveCurrentStateToCache();
            _txtFilterCompilables.LostFocus += (s, e) => SaveCurrentStateToCache();

            _chkTrackIncludes.Checked += (s, e) => SaveCurrentStateToCache();
            _chkTrackIncludes.Unchecked += (s, e) => SaveCurrentStateToCache();
            _chkIgnoreComments.Checked += (s, e) => SaveCurrentStateToCache();
            _chkIgnoreComments.Unchecked += (s, e) => SaveCurrentStateToCache();
            _chkWholeWord.Checked += (s, e) => SaveCurrentStateToCache();
            _chkWholeWord.Unchecked += (s, e) => SaveCurrentStateToCache();
            _chkCaseSensitive.Checked += (s, e) => SaveCurrentStateToCache();
            _chkCaseSensitive.Unchecked += (s, e) => SaveCurrentStateToCache();
        }

        public void SaveCurrentStateToCache()
        {
            if (_isLoadingCache || _cacheService == null)
            {
                return;
            }

            if (_cacheData == null)
            {
                _cacheData = new AppCacheData();
            }

            _cacheData.LastRootDirectory = _txtRootDir != null ? _txtRootDir.Text.Trim().Trim('"', '\'') : string.Empty;
            _cacheData.LastSearchTerm = _txtSearchTerm != null ? _txtSearchTerm.Text.Trim() : string.Empty;
            _cacheData.Extensions = _txtExtensions != null ? _txtExtensions.Text.Trim() : ".p, .w, .i, .cls";
            _cacheData.TrackIncludes = _chkTrackIncludes != null && _chkTrackIncludes.IsChecked == true;
            _cacheData.IgnoreComments = _chkIgnoreComments != null && _chkIgnoreComments.IsChecked == true;
            _cacheData.WholeWord = _chkWholeWord != null && _chkWholeWord.IsChecked == true;
            _cacheData.CaseSensitive = _chkCaseSensitive != null && _chkCaseSensitive.IsChecked == true;
            _cacheData.ScriptModeIndex = _scriptModeIndex;
            _cacheData.PathFormatIndex = _pathFormatIndex;
            _cacheData.FilterText = _txtFilterCompilables != null ? _txtFilterCompilables.Text.Trim() : string.Empty;

            _cacheService.Save(_cacheData);
            UpdateRecentButtonsTooltip();
        }

        private void UpdateRecentButtonsTooltip()
        {
            int dirCount = (_cacheData != null && _cacheData.RecentDirectories != null) ? _cacheData.RecentDirectories.Count : 0;
            int termCount = (_cacheData != null && _cacheData.RecentSearchTerms != null) ? _cacheData.RecentSearchTerms.Count : 0;

            if (_btnRecentDirs != null)
            {
                _btnRecentDirs.ToolTip = string.Format("Diretórios recentes salvos em cache ({0})", dirCount);
            }
            if (_btnRecentTerms != null)
            {
                _btnRecentTerms.ToolTip = string.Format("Palavras-chave e tabelas recentes salvas em cache ({0})", termCount);
            }
        }

        private void OnRecentDirsClick(object sender, RoutedEventArgs e)
        {
            List<string> dirs = (_cacheData != null && _cacheData.RecentDirectories != null)
                ? _cacheData.RecentDirectories
                : new List<string>();

            ShowHistoryPopup(
                _btnRecentDirs,
                "DIRETÓRIOS DE BUSCA RECENTES",
                dirs,
                "Nenhum diretório salvo no histórico ainda.",
                selectedDir =>
                {
                    _txtRootDir.Text = selectedDir;
                    AppCacheService.AddRecentDirectory(_cacheData, selectedDir);
                    SaveCurrentStateToCache();
                },
                () =>
                {
                    if (_cacheData != null)
                    {
                        _cacheData.RecentDirectories.Clear();
                        SaveCurrentStateToCache();
                    }
                });
        }

        private void OnRecentTermsClick(object sender, RoutedEventArgs e)
        {
            List<string> terms = (_cacheData != null && _cacheData.RecentSearchTerms != null)
                ? _cacheData.RecentSearchTerms
                : new List<string>();

            ShowHistoryPopup(
                _btnRecentTerms,
                "PALAVRAS-CHAVE / TABELAS RECENTES",
                terms,
                "Nenhuma palavra-chave salva no histórico ainda.",
                selectedTerm =>
                {
                    _txtSearchTerm.Text = selectedTerm;
                    AppCacheService.AddRecentSearchTerm(_cacheData, selectedTerm);
                    SaveCurrentStateToCache();
                    _txtSearchTerm.Focus();
                },
                () =>
                {
                    if (_cacheData != null)
                    {
                        _cacheData.RecentSearchTerms.Clear();
                        SaveCurrentStateToCache();
                    }
                });
        }

        private void ShowHistoryPopup(
            Button anchorButton,
            string headerTitle,
            List<string> items,
            string emptyMessage,
            Action<string> onSelect,
            Action onClear)
        {
            Popup popup = new Popup
            {
                PlacementTarget = anchorButton,
                Placement = PlacementMode.Bottom,
                StaysOpen = false,
                AllowsTransparency = true,
                VerticalOffset = 4
            };

            Border outer = new Border
            {
                Background = BrushBgSurface,
                BorderBrush = BrushBorderFocus,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(9),
                Padding = new Thickness(8),
                MinWidth = 380,
                MaxWidth = 640,
                MaxHeight = 340
            };

            StackPanel rootStack = new StackPanel();

            Grid headerGrid = new Grid { Margin = new Thickness(4, 2, 4, 6) };
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            TextBlock lblHeader = new TextBlock
            {
                Text = headerTitle,
                FontSize = 10.5,
                FontWeight = FontWeights.Bold,
                Foreground = BrushBorderFocus,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(lblHeader, 0);
            headerGrid.Children.Add(lblHeader);

            if (items != null && items.Count > 0)
            {
                Button btnClear = CreateSmallSecondaryButton("Limpar Histórico");
                btnClear.Height = 24;
                btnClear.FontSize = 11;
                btnClear.Click += (s, ev) =>
                {
                    popup.IsOpen = false;
                    if (onClear != null) onClear();
                };
                Grid.SetColumn(btnClear, 1);
                headerGrid.Children.Add(btnClear);
            }

            rootStack.Children.Add(headerGrid);

            ScrollViewer sv = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                MaxHeight = 270
            };
            StackPanel listStack = new StackPanel();

            if (items == null || items.Count == 0)
            {
                listStack.Children.Add(new TextBlock
                {
                    Text = emptyMessage,
                    FontSize = 12,
                    Foreground = BrushTextMuted,
                    Margin = new Thickness(6, 10, 6, 10)
                });
            }
            else
            {
                foreach (string item in items)
                {
                    string captured = item;
                    Border itemBorder = new Border
                    {
                        Background = BrushBgInput,
                        BorderBrush = BrushBorderSubtle,
                        BorderThickness = new Thickness(1),
                        CornerRadius = new CornerRadius(6),
                        Padding = new Thickness(10, 6, 10, 6),
                        Margin = new Thickness(0, 0, 0, 4),
                        Cursor = Cursors.Hand
                    };

                    TextBlock tb = new TextBlock
                    {
                        Text = captured,
                        FontFamily = new FontFamily("Consolas"),
                        FontSize = 12.5,
                        Foreground = BrushTextPrimary,
                        TextTrimming = TextTrimming.CharacterEllipsis
                    };
                    itemBorder.Child = tb;

                    itemBorder.MouseEnter += (s, ev) =>
                    {
                        itemBorder.Background = BrushBgElevated;
                        itemBorder.BorderBrush = BrushBorderFocus;
                    };
                    itemBorder.MouseLeave += (s, ev) =>
                    {
                        itemBorder.Background = BrushBgInput;
                        itemBorder.BorderBrush = BrushBorderSubtle;
                    };
                    itemBorder.MouseLeftButtonUp += (s, ev) =>
                    {
                        popup.IsOpen = false;
                        if (onSelect != null) onSelect(captured);
                    };

                    listStack.Children.Add(itemBorder);
                }
            }

            sv.Content = listStack;
            rootStack.Children.Add(sv);
            outer.Child = rootStack;
            popup.Child = outer;
            popup.IsOpen = true;
        }

        // ── Métodos Públicos de Verificação Automatizada (Phase3Verifier) ─────────

        public int GetCompilableListViewCount()
        {
            return _compilableRenderedCount;
        }

        public int GetTreeNodesCount()
        {
            return _treeFileNodesCount;
        }

        public string GetGeneratedScriptPreviewText()
        {
            return _cachedScriptPreviewText;
        }

        public int GetPathFormatIndex()
        {
            return _pathFormatIndex;
        }

        public int GetScriptModeIndex()
        {
            return _scriptModeIndex;
        }

        public void SetScriptModeIndex(int index)
        {
            _scriptModeIndex = index;
            ApplySegmentedOptionVisual(_btnModeErrorLog, index == 0);
            ApplySegmentedOptionVisual(_btnModePure, index == 1);
            RefreshScriptPreview();
            SaveCurrentStateToCache();
        }

        public void SetPathFormatIndex(int index)
        {
            _pathFormatIndex = index;
            ApplySegmentedOptionVisual(_btnPathRelative, index == 0);
            ApplySegmentedOptionVisual(_btnPathAbsolute, index == 1);
            RefreshScriptPreview();
            SaveCurrentStateToCache();
        }

        // ── Atalhos Globais de Teclado (Ctrl+F, F3, Esc) ───────────────────────────

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            if (e.Key == Key.F && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                OpenOrFocusEditorFind();
                e.Handled = true;
                return;
            }

            if (e.Key == Key.F3)
            {
                if (_findBarBorder != null && _findBarBorder.Visibility == Visibility.Visible)
                {
                    if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
                    {
                        NavigateEditorFindPrevious();
                    }
                    else
                    {
                        NavigateEditorFindNext();
                    }
                    e.Handled = true;
                    return;
                }
            }

            if (e.Key == Key.Escape && _findBarBorder != null && _findBarBorder.Visibility == Visibility.Visible)
            {
                CloseEditorFind();
                e.Handled = true;
                return;
            }
        }

        // ── Barra Flutuante de Localização no Editor (Ctrl+F) ─────────────────────

        private Border BuildFindBar()
        {
            Border bar = new Border
            {
                Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)),
                BorderBrush = new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(6, 4, 6, 4),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(0, 48, 20, 0),
                Visibility = Visibility.Collapsed,
                Effect = new DropShadowEffect
                {
                    Color = Colors.Black,
                    Direction = 270,
                    ShadowDepth = 3,
                    Opacity = 0.45,
                    BlurRadius = 8
                }
            };

            StackPanel stack = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                VerticalAlignment = VerticalAlignment.Center
            };

            stack.Children.Add(CreateSvgIcon(SvgSearch, Color.FromRgb(148, 163, 184), 13));

            _txtEditorFind = new TextBox
            {
                Width = 200,
                Height = 26,
                Background = BrushBgCanvas,
                Foreground = BrushTextPrimary,
                BorderBrush = BrushBorderSubtle,
                BorderThickness = new Thickness(1),
                FontFamily = new FontFamily("Consolas"),
                FontSize = 12,
                Padding = new Thickness(6, 2, 6, 2),
                Margin = new Thickness(6, 0, 6, 0),
                VerticalContentAlignment = VerticalAlignment.Center
            };
            _txtEditorFind.TextChanged += (s, e) => ExecuteEditorFind(true);
            _txtEditorFind.PreviewKeyDown += OnTxtEditorFindPreviewKeyDown;
            stack.Children.Add(_txtEditorFind);

            _lblFindCount = new TextBlock
            {
                Text = string.Empty,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 11,
                Foreground = BrushTextMuted,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(4, 0, 8, 0),
                MinWidth = 55,
                TextAlignment = TextAlignment.Center
            };
            stack.Children.Add(_lblFindCount);

            _btnFindPrev = CreateFindNavButton("▲", "Ocorrência anterior (Shift+Enter / Shift+F3)");
            _btnFindPrev.Click += (s, e) => NavigateEditorFindPrevious();
            stack.Children.Add(_btnFindPrev);

            _btnFindNext = CreateFindNavButton("▼", "Próxima ocorrência (Enter / F3)");
            _btnFindNext.Click += (s, e) => NavigateEditorFindNext();
            stack.Children.Add(_btnFindNext);

            _btnFindClose = CreateFindNavButton("✕", "Fechar (Esc)");
            _btnFindClose.Margin = new Thickness(4, 0, 0, 0);
            _btnFindClose.Click += (s, e) => CloseEditorFind();
            stack.Children.Add(_btnFindClose);

            bar.Child = stack;
            return bar;
        }

        private static Button CreateFindNavButton(string text, string toolTip)
        {
            Button btn = new Button
            {
                Content = text,
                Width = 24,
                Height = 24,
                Background = Brushes.Transparent,
                Foreground = new SolidColorBrush(Color.FromRgb(203, 213, 225)),
                BorderThickness = new Thickness(0),
                Cursor = Cursors.Hand,
                ToolTip = toolTip,
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Padding = new Thickness(0),
                Margin = new Thickness(2, 0, 2, 0)
            };

            btn.MouseEnter += (s, e) =>
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(51, 65, 85));
                btn.Foreground = Brushes.White;
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.Background = Brushes.Transparent;
                btn.Foreground = new SolidColorBrush(Color.FromRgb(203, 213, 225));
            };

            return btn;
        }

        private void OnTxtEditorFindPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
                {
                    NavigateEditorFindPrevious();
                }
                else
                {
                    NavigateEditorFindNext();
                }
                e.Handled = true;
            }
            else if (e.Key == Key.Escape)
            {
                CloseEditorFind();
                e.Handled = true;
            }
            else if (e.Key == Key.F3)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
                {
                    NavigateEditorFindPrevious();
                }
                else
                {
                    NavigateEditorFindNext();
                }
                e.Handled = true;
            }
        }

        private RichTextBox GetActivePreviewRichTextBox()
        {
            if (_viewCodePreview != null && _viewCodePreview.Visibility == Visibility.Visible)
            {
                return _rtbCodePreview;
            }
            if (_viewScriptPreview != null && _viewScriptPreview.Visibility == Visibility.Visible)
            {
                return _rtbScriptPreview;
            }
            return _rtbCodePreview;
        }

        public void OpenOrFocusEditorFind()
        {
            if (_findBarBorder == null) return;

            bool isCodeTab = _viewCodePreview != null && _viewCodePreview.Visibility == Visibility.Visible;
            _findBarBorder.Margin = isCodeTab
                ? new Thickness(0, 48, 20, 0)
                : new Thickness(0, 94, 20, 0);

            _findBarBorder.Visibility = Visibility.Visible;

            RichTextBox rtb = GetActivePreviewRichTextBox();
            if (rtb != null && !string.IsNullOrEmpty(rtb.Selection.Text) && !rtb.Selection.Text.Contains("\n") && !rtb.Selection.Text.Contains("\r"))
            {
                _txtEditorFind.Text = rtb.Selection.Text;
            }

            _txtEditorFind.Focus();
            _txtEditorFind.SelectAll();
            ExecuteEditorFind(true);
        }

        public void CloseEditorFind()
        {
            if (_findBarBorder != null)
            {
                _findBarBorder.Visibility = Visibility.Collapsed;
            }
            RichTextBox rtb = GetActivePreviewRichTextBox();
            if (rtb != null)
            {
                rtb.Focus();
            }
        }

        private void ExecuteEditorFind(bool selectFirst)
        {
            _activeFindMatches.Clear();
            string query = _txtEditorFind != null ? _txtEditorFind.Text : string.Empty;

            RichTextBox rtb = GetActivePreviewRichTextBox();
            if (rtb == null || rtb.Document == null || string.IsNullOrEmpty(query))
            {
                _currentFindIndex = -1;
                UpdateFindCounterUI();
                return;
            }

            CollectMatchesFromDocument(rtb.Document, query);

            if (_activeFindMatches.Count == 0)
            {
                _currentFindIndex = -1;
                UpdateFindCounterUI();
                return;
            }

            if (selectFirst || _currentFindIndex < 0 || _currentFindIndex >= _activeFindMatches.Count)
            {
                _currentFindIndex = 0;
            }

            UpdateFindCounterUI();
            HighlightAndNavigateCurrentMatch();
        }

        private void CollectMatchesFromDocument(FlowDocument doc, string query)
        {
            if (doc == null || string.IsNullOrEmpty(query)) return;

            foreach (Block block in doc.Blocks)
            {
                Paragraph p = block as Paragraph;
                if (p == null) continue;

                foreach (Inline inline in p.Inlines)
                {
                    Run run = inline as Run;
                    if (run == null) continue;

                    // Ignorar runs marcados como numeracao de linhas da gutter
                    if ("GUTTER".Equals(run.Tag as string, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    string text = run.Text;
                    if (string.IsNullOrEmpty(text)) continue;

                    int idx = 0;
                    while (idx < text.Length)
                    {
                        int found = text.IndexOf(query, idx, StringComparison.OrdinalIgnoreCase);
                        if (found < 0) break;

                        try
                        {
                            TextPointer startPtr = run.ContentStart.GetPositionAtOffset(found);
                            TextPointer endPtr = run.ContentStart.GetPositionAtOffset(found + query.Length);
                            if (startPtr != null && endPtr != null)
                            {
                                _activeFindMatches.Add(new TextFindMatch
                                {
                                    Start = startPtr,
                                    End = endPtr,
                                    Paragraph = p,
                                    OwnerRun = run,
                                    MatchIndex = _activeFindMatches.Count
                                });
                            }
                        }
                        catch (Exception)
                        {
                        }

                        idx = found + Math.Max(1, query.Length);
                    }
                }
            }
        }

        private void HighlightAndNavigateCurrentMatch()
        {
            if (_activeFindMatches == null || _activeFindMatches.Count == 0 || _currentFindIndex < 0 || _currentFindIndex >= _activeFindMatches.Count)
            {
                return;
            }

            TextFindMatch match = _activeFindMatches[_currentFindIndex];
            RichTextBox rtb = GetActivePreviewRichTextBox();
            if (rtb == null) return;

            try
            {
                rtb.Selection.Select(match.Start, match.End);
                if (match.OwnerRun != null)
                {
                    match.OwnerRun.BringIntoView();
                }
                else if (match.Paragraph != null)
                {
                    match.Paragraph.BringIntoView();
                }
            }
            catch (Exception)
            {
            }
        }

        private void NavigateEditorFindNext()
        {
            if (_activeFindMatches == null || _activeFindMatches.Count == 0)
            {
                return;
            }

            _currentFindIndex = (_currentFindIndex + 1) % _activeFindMatches.Count;
            UpdateFindCounterUI();
            HighlightAndNavigateCurrentMatch();
        }

        private void NavigateEditorFindPrevious()
        {
            if (_activeFindMatches == null || _activeFindMatches.Count == 0)
            {
                return;
            }

            _currentFindIndex--;
            if (_currentFindIndex < 0)
            {
                _currentFindIndex = _activeFindMatches.Count - 1;
            }
            UpdateFindCounterUI();
            HighlightAndNavigateCurrentMatch();
        }

        private void UpdateFindCounterUI()
        {
            if (_lblFindCount == null) return;

            string query = _txtEditorFind != null ? _txtEditorFind.Text : string.Empty;
            if (string.IsNullOrEmpty(query))
            {
                _lblFindCount.Text = string.Empty;
                _lblFindCount.Foreground = BrushTextMuted;
                if (_btnFindPrev != null) _btnFindPrev.IsEnabled = false;
                if (_btnFindNext != null) _btnFindNext.IsEnabled = false;
                return;
            }

            if (_activeFindMatches == null || _activeFindMatches.Count == 0)
            {
                _lblFindCount.Text = "0 de 0";
                _lblFindCount.Foreground = new SolidColorBrush(Color.FromRgb(248, 113, 113));
                if (_btnFindPrev != null) _btnFindPrev.IsEnabled = false;
                if (_btnFindNext != null) _btnFindNext.IsEnabled = false;
            }
            else
            {
                _lblFindCount.Text = string.Format("{0} de {1}", _currentFindIndex + 1, _activeFindMatches.Count);
                _lblFindCount.Foreground = new SolidColorBrush(Color.FromRgb(56, 189, 248));
                if (_btnFindPrev != null) _btnFindPrev.IsEnabled = true;
                if (_btnFindNext != null) _btnFindNext.IsEnabled = true;
            }
        }

        // ── Métodos Públicos de Localização no Editor (Ctrl+F) ─────────────────

        public void OpenEditorFind()
        {
            OpenOrFocusEditorFind();
        }

        public void SetEditorFindText(string text)
        {
            if (_txtEditorFind != null)
            {
                _txtEditorFind.Text = text;
            }
        }

        public int GetEditorFindMatchesCount()
        {
            return _activeFindMatches != null ? _activeFindMatches.Count : 0;
        }

        public int GetCurrentFindIndex()
        {
            return _currentFindIndex;
        }

        public void TriggerFindNext()
        {
            NavigateEditorFindNext();
        }

        public void TriggerFindPrevious()
        {
            NavigateEditorFindPrevious();
        }

        public bool IsEditorFindVisible()
        {
            return _findBarBorder != null && _findBarBorder.Visibility == Visibility.Visible;
        }
    }
}
