@echo off
echo Press any key to publish
pause
"..\.nuget\NuGet.exe" push Ladon.Net.1.0.2.nupkg -Source https://api.nuget.org/v3/index.json
pause