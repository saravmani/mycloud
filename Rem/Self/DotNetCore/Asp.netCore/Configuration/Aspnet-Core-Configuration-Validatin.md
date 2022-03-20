

###### Validate configuration values while applicaiton initiating
```csharp
public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)

               .ConfigureServices((hostContext, services) =>
               {
                   services.AddOptions<MyAppDBConfigurations>()
                   .Bind(hostContext.Configuration.GetSection(nameof(MyAppDBConfigurations)))
                    .Validate(a => a.ConnectionString != null,"should not be null")
                    .Validate(a => a.DBTimeOut >0,"Should be > 0");
                    ;
                    //Validation rules

                   //.ValidateDataAnnotations();

                   services.AddSingleton<Extractor>();
                   services.AddHostedService<Worker>();
               });
```
