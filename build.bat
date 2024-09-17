@echo off

set "PATH=C:\Windows\System32\;C:\Windows\Microsoft.NET\Framework64\v4.0.30319\;"

if not exist build mkdir build

csc.exe /nologo /out:build\HelloWorld.exe Program.cs

echo Build completed. Output: build\HelloWorld.exe