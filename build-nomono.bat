cd Generator
start /wait Jenny/Jenny.exe gen
cd ..
dotnet run -p RLSetup/RLSetup.csproj -c Release