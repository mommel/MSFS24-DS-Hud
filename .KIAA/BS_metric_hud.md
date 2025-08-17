```yaml
steps:
  - task: UseDotNet@2
    inputs: { packageType: 'sdk', version: '8.x' }
  - script: dotnet restore
  - script: dotnet build -c Release -warnaserror
  - script: dotnet test -c Release --no-build
```
