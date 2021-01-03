
Swagger is a webapi documentation tool and it is widly accepted. This will generat the UI to test the webapi 

Swagger provides nuget package for .net and .net core

```
PM > Install-package Swashbuckle.AspNetCore
```

```csharp
services.AddSwaggerGen("v1", new OpenApiInfo{Title = "MyWebAPi", Version = "v1"})
```

###### To add Swagger UI


```csharp
public void Configure(IApplicaitonBuilder app, IWebHostEnvironment env)
{
  // .. Other HTTP pipeline configuration
  app.useSwagger();
  app.useSwaggerUI(a=>a.SwaggerEndPoint("swagger/v1/swagger.json","My WebAPI V1"));
  // .. Other HTTP pipeline configuration
}
```
