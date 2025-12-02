param (
    [string]$localSourcesDir = "D:/nuget.local",
    [string]$buildType = "Release"
)

function Push-NuGetPackages {
    [CmdletBinding(SupportsShouldProcess = $true)]
    param(
        [string]$PackagePath = "../output/Nuget",
        [Parameter(Mandatory = $true)]
        [string]$Source
    )

    # Get all NuGet packages
    $packages = Get-ChildItem -Path $PackagePath -Filter *.nupkg -Recurse -File

    if (-not $packages) {
        Write-Warning "No .nupkg files found"
        return
    }

    # Process each package
    foreach ($pkg in $packages) {
        if ($PSCmdlet.ShouldProcess($pkg.Name, "Push and delete")) {
            try {
                # Push package
                dotnet nuget push $pkg.FullName --source $Source

                if ($LASTEXITCODE -eq 0) {
                    # Delete successfully pushed packages
                    Remove-Item $pkg.FullName -Force
                    Write-Host "✓ Success: $($pkg.Name)" -ForegroundColor Green
                } else {
                    Write-Warning "Push failed: $($pkg.Name) (Exit code: $LASTEXITCODE)"
                }
            }
            catch {
                Write-Error "Error processing $($pkg.Name): $_"
            }
        }
    }
}

dotnet build -v diag --configuration $buildType ../src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj
dotnet pack --no-build --configuration $buildType ../src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj
Push-NuGetPackages -Source $localSourcesDir