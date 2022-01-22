
###### Types of health check
* Liveness health Check - Used tind applications liveness
* Readiness health check - used to check application is ready to perform (Ex check thirdparty connectivities)

We can use simple endpoint to get the health status

we can add multiple endpoints depends on health check type


By default .net core provides health check options. Based on need we can include external healthc providers.
For example if we want to check health of dependent CosmoDB health then we can use respective below packate
```powershell
PM> Install-Package AspNetCore.HealthChecks.CosmosDb -Version 6.0.1
```
> *Note: You can find more health check packages in nuget store. AspNetCore.HealthChecks%*


###### Check other api health
Install AspNetCore.HealthChecks.Uris package to monitor other apis
1. Install AspNetCore.HealthChecks.Uris
```powershell
PM> Install-Package AspNetCore.HealthChecks.Uris
```
2. below lines of code in ConfigureServices method of startup.cs class
```csharp
services.AddHealthChecks()
  .AddUrlGroup(new Uri("https://domainname.com/api/student"),"Student Management API",HealthStatus.Degraded)
```
