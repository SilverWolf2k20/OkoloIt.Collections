# Clear Release folder
$packagePath = "..\src\bin\Release\*.nupkg";
$projfilePath = "..\src\OkoloIt.Collections.csproj";

Remove-Item -Path $packagePath;
dotnet clean $projfilePath -c Release;

# Build Project
dotnet build $projfilePath -c Release;
dotnet pack  $projfilePath -c Release;