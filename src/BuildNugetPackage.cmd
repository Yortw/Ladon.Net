del /F /Q /S *.CodeAnalysisLog.xml

"..\.nuget\NuGet.exe" pack -sym Ladon.Net.nuspec -BasePath .\
pause

copy *.nupkg C:\Nuget.LocalRepository\
pause
