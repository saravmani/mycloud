#### Ocelot - API Gateway
###### Discussion on Ocelot - API Gateways
>


For bigger applications there can be multiple API Gateways. Some times based on, client application's need we can have different API Gateways to satisfy the client needs


###### Benefits of API Gateway
* Audit logs
* QOS Checks
* Throttling
* DOS Prevention
* Requests Aggregation
* We can implement Cross-Cutting features at single place
* Authentication
* Security - Ex: SSL implementation at single place
* Rounting
* Load Balancing
* Act as reverse proxy
* Service Discovery


It is opensource and lightweight
Scalable and .Net core based.

###### Disadvantage
It is designed For ASP.NET core applications only

---

###### Simple steps to implement API Gateway in Asp.net Core using Ocelot Api Gateway
* Install Ocelot Nuget package
 ```powershell
 PM> Install-Package Ocelot
 ```
* In Startup.cs file Import below mentioned namespaces
```csharp
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
```
* In Startup.cs file add below lines under ConfigureServices Method
```csharp
services.AddOcelot();
```
* In Startup.cs file add below line in Configure Method
```csharp
await app.UseOcelot();
```
* Add ocelot.json file at root level (i.e you can add this file environment specific ex: ocelot.uat.json)
* Configure internal api urls in ocelot.json file
Sample Ocelot config file
```json
//ocelot.localenv.json
{
  "Routes": [
      {
          "DownstreamPathTemplate": "/api/v1/Student",
          "DownstreamScheme": "https",
          "DownstreamHostAndPorts": [
              {
                  "Host": "localhost",
                  "Port": 7001
              }
          ],
          "UpstreamPathTemplate": "/Student",
          "UpstreamHttpMethod": [ "POST", "PUT", "GET" ]
      },

      {
          "DownstreamPathTemplate": "/api/{version}/{otherpart}",
          "DownstreamScheme": "https",
          "DownstreamHostAndPorts": [
              {
                  "Host": "localhost",
                  "Port": 7001
              }
          ],
          "UpstreamPathTemplate": "/api/{version}/{otherpart}",
          "UpstreamHttpMethod": [ "POST", "PUT", "GET" ]
      }
  ],
  "GlobalConfiguration": {
      "BaseUrl": "http://localhost:9000"
  }
}

```
* Configure newly added ocelot.json file with help of below code
```csharp
//program.cs file
public static IHostBuilder CreateHostBuilder(string[] args) =>
  Host.CreateDefaultBuilder(args)
      .ConfigureAppConfiguration((hostingContext, config) =>
      {
          //config.AddJsonFile("ocelot.json");
          config.AddJsonFile($"ocelot.{hostingContext.HostingEnvironment.EnvironmentName}.json", true);
      })
      .ConfigureWebHostDefaults(webBuilder =>
      {
          webBuilder.UseStartup<Startup>();
      });
```


###### To Support Swagger
```powershell
PM> Install-Package MMLib.SwaggerForOcelot
```


---

[//]: # (MyRef: MYNOTE-OCILOT-AUTHENTICATION : How we can implement the authentication in microservices)



[//]: # (Tags: Ocelot, Microservices, API Gateway)
[//]: # (Type: Microservices - Ocelot)
[//]: # (Rating: 1)
[//]: # (Languages:c#)
[//]: # (ReadyState:Inprogress)
