# Reproduction of issue #148
Trying to reproduce the issue [#148](https://github.com/microsoft/durabletask-dotnet/issues/148) in a clean repo. 

## Run to reproduce error
```shell
cd DurableFunctionsRepro && func start
```

## Fix for error
Comment in _Target_ group with name _CopyGrpcNativeAssetsToOutDir_ and run from root
```shell
cd DurableFunctionsRepro && func start
```

## Steps taken to create repository
1. Install Jetbrains Rider (presumably no effect)
2. Install .NET (https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.300-macos-arm64-installer) with default settings
3. Install _mono-libgdiplus_ via brew (see https://learn.microsoft.com/en-us/dotnet/core/install/macos why)
   ```shell
   brew install mono-libgdiplus
   ```
4. Install Azure Functions Core Tools 
   ```shell
   brew tap azure/functions && brew install azure-functions-core-tools@4
   ```
5. Create Functions app via Rider 
6. Execute following actions in [DurableFunctionsRepro.csproj](DurableFunctionsRepro/DurableFunctionsRepro.csproj)
   1. Replace all with code from https://github.com/microsoft/durabletask-dotnet/issues/148#issuecomment-2047844215
   2. Upgrade _Contrib.Grpc.Core.M1_ to 2.46.7
   3. Comment out _Target_ group with name _CopyGrpcNativeAssetsToOutDir_
7. Install Azurite via NPM (Node 18.14.2 & NPM 9.5.0)
   ```shell 
   npm install -g azurite
   ```
8. Run azurite
   ```shell
   azurite --silent --location c:\azurite --debug c:\azurite\debug.log
   ```
9. Run following command from root of project
   ```shell
   cd DurableFunctionsRepro && func start
   ```
   
## Extra information
Committed my [local.settings.json](DurableFunctionsRepro/local.settings.json) as well to ensure you can run project fully.