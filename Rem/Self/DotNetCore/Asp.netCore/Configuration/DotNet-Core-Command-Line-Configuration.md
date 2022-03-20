

###### Provide Alias keys to complex configuration keys
```csharp
var switchMappings = new Dictionary<string, string>()
          {
              { "--alias1", "sectionName:key1" },
              { "-alias2", "sectionName:key2" },
              //--
          };
          var builder = new ConfigurationBuilder();
          builder.AddCommandLine(args, switchMappings);

          var config = builder.Build();
```

###### Execute the application with new alias keys
```powershell
> applicaiton.exe --alias1 <value> -alias2 <value>
```
