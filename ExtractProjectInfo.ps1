# Trova il file della soluzione (.sln) nella directory corrente
$solutionFile = Get-ChildItem -Path "." -Filter "*.sln" | Select-Object -First 1

if ($null -eq $solutionFile) {
    Write-Host "Nessun file .sln trovato nella directory corrente."
    exit
}

$solutionPath = $solutionFile.FullName

# Legge il contenuto del file della soluzione
$solutionContent = Get-Content $solutionPath

# File dove salvare l'output
$outputFile = "RiepilogoProgetti.txt"

# Inizializza/Cancella il contenuto del file di output se già esiste
if (Test-Path $outputFile) {
    Clear-Content $outputFile
}

# Estrae i percorsi dei progetti
$projectPaths = $solutionContent | Where-Object { $_ -match 'Project\("\{[A-Fa-f0-9\-]*\}"\) = "[^"]*", "([^"]*)"' } | ForEach-Object {
    $matches[1]
} | Where-Object { $_ -like "*\CleanCore*" }

"Progetti nella soluzione:" | Add-Content -Path $outputFile
foreach ($relativePath in $projectPaths) {
    $projectPath = Join-Path (Split-Path $solutionPath) $relativePath
    $projectDir = [System.IO.Path]::GetDirectoryName($projectPath)
    $readmePath = Join-Path $projectDir "README.md"

    if (Test-Path $readmePath) {
        $line = "Progetto: $relativePath ha un README in $readmePath"
    } else {
        $line = "Progetto: $relativePath NON ha un README"
    }
    Add-Content -Path $outputFile -Value $line
}

Write-Host "Output salvato in $outputFile"
