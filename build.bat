cd Generator
start /wait mono Jenny/Jenny.exe gen
cd ..
dotnet run -p RLSetup/RLSetup.csproj -c Release