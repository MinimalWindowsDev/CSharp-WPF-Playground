@echo off

REM Set the path to include the .NET Framework directory
set "PATH=C:\Windows\Microsoft.NET\Framework64\v4.0.30319;%PATH%"

REM Build the project using msbuild
msbuild.exe SimpleWPFApp.csproj /p:Configuration=Release /p:Platform="AnyCPU"

if %ERRORLEVEL% EQU 0 (
    echo Build successful. Running the application...
    start "" "bin\Release\SimpleWPFApp.exe"
) else (
    echo Build failed.
)