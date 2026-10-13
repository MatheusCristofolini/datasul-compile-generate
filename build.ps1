$ErrorActionPreference = "Stop"

$fwDir = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319"
if (-not (Test-Path (Join-Path $fwDir "csc.exe"))) {
    $fwDir = "C:\Windows\Microsoft.NET\Framework\v4.0.30319"
}

$cscPath = Join-Path $fwDir "csc.exe"
$wpfDir = Join-Path $fwDir "WPF"

if (-not (Test-Path $cscPath)) {
    throw "Compilador C# nativo do Windows (csc.exe) nao encontrado em C:\Windows\Microsoft.NET."
}

$rootDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$distDir = Join-Path $rootDir "dist"
if (-not (Test-Path $distDir)) {
    New-Item -ItemType Directory -Force -Path $distDir | Out-Null
}

$outRootExe = Join-Path $rootDir "DatasulCompileGen.exe"
$outDistExe = Join-Path $distDir "DatasulCompileGen.exe"

$sources = @(
    (Join-Path $rootDir "src\Core\SearchModels.cs"),
    (Join-Path $rootDir "src\Core\AppCacheService.cs"),
    (Join-Path $rootDir "src\Core\ProgressCodeAnalyzer.cs"),
    (Join-Path $rootDir "src\Core\ProgressSearchEngine.cs"),
    (Join-Path $rootDir "src\Core\CompileScriptGenerator.cs"),
    (Join-Path $rootDir "src\UI\MainForm.cs"),
    (Join-Path $rootDir "src\Program.cs")
)

$iconIco = Join-Path $rootDir "resources\app.ico"
$iconPng = Join-Path $rootDir "resources\app.png"

$resourceArgs = @()
if (Test-Path $iconIco) {
    $resourceArgs += "/win32icon:$iconIco"
}
if (Test-Path $iconPng) {
    $resourceArgs += "/res:$iconPng,DatasulCompileGen.app.png"
}

Write-Host "Compilando executavel portatil WPF (UI/UX Pro Max) DatasulCompileGen.exe com icone incorporado..." -ForegroundColor Cyan

if (Test-Path $outRootExe) {
    try {
        Remove-Item $outRootExe -Force -ErrorAction Stop
    } catch {
        $oldBackup = "$outRootExe.old"
        if (Test-Path $oldBackup) { try { Remove-Item $oldBackup -Force -ErrorAction SilentlyContinue } catch {} }
        Move-Item $outRootExe $oldBackup -Force -ErrorAction SilentlyContinue
    }
}

& $cscPath /nologo /target:winexe /optimize+ /platform:anycpu `
    "/out:$outRootExe" `
    /r:System.dll `
    /r:System.Core.dll `
    /r:System.Xaml.dll `
    /r:System.Drawing.dll `
    /r:System.Windows.Forms.dll `
    "/r:$wpfDir\PresentationFramework.dll" `
    "/r:$wpfDir\PresentationCore.dll" `
    "/r:$wpfDir\WindowsBase.dll" `
    $resourceArgs `
    $sources

if ($LASTEXITCODE -ne 0) {
    throw "Falha ao compilar DatasulCompileGen.exe."
}

Copy-Item -Path $outRootExe -Destination $outDistExe -Force

$fileInfo = Get-Item $outRootExe
Write-Host ("Build concluido com sucesso! Arquivo: {0} ({1:N1} KB)" -f $fileInfo.FullName, ($fileInfo.Length / 1KB)) -ForegroundColor Green
