dotnet build  --configuration release ..\EdiEngine.sln
nuget.exe pack config.nuspec -Symbols -SymbolPackageFormat snupkg
