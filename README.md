# Reproduction of issue #148
Trying to reproduce the issue [#148](https://github.com/microsoft/durabletask-dotnet/issues/148)
in a clean repo (and even laptop).

## Steps
1. Install Jetbrains Rider (presumably no effect)
2. Install .NET (https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.300-macos-arm64-installer) with default settings
3. Install Azure Functions Core Tools (brew tap azure/functions
   brew install azure-functions-core-tools@4)
4. Create Functions app via Rider 
5. Execute following actions in [DurableFunctionsRepro.csproj](DurableFunctionsRepro/DurableFunctionsRepro.csproj)
   1. Replace all with code from https://github.com/microsoft/durabletask-dotnet/issues/148#issuecomment-2047844215
   2. Comment out _Target_ group with name _CopyGrpcNativeAssetsToOutDir_
6. Build project
7. Install Azurite via NPM (Node 18.14.2 & NPM 9.5.0)
   1. `npm install -g azurite`
8. Run azurite
   1. `azurite --silent --location c:\azurite --debug c:\azurite\debug.log`
9. Install _mono-libgdiplus_ via brew (see https://learn.microsoft.com/en-us/dotnet/core/install/macos why)