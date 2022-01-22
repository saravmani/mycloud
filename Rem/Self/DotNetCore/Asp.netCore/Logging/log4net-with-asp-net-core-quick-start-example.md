#  Use Log4Net in Asp.Net Core
###### Quick steps to add Log4Net in Asp.net Core application with Sample code
>
> Note: Below steps i've tried with Asp.net Core 3.1 and it works fine


1. Create new .net Core project

2. Open Package manager console (Tools->Nuget Package Manager->Package Manager Console) and  Run below-mentioned commands to install the required packages

```powershell
Install-Package log4net
Install-Package Microsoft.Extensions.Logging.Log4Net.AspNetCore
```

3. Configure Log4Net in *Startp.cs* file's Configure Method

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
{
   loggerFactory.AddLog4Net();
   // Dont forget to add - using Microsoft.Extensions.Logging;
   //.. Other configuration code
}
```

4. In Project root folder create log4net.config file and add required log4net configurations
  > Sample Log4Net configuration

```XML
<log4net>
	<appender name="FileAppender" type="log4net.Appender.FileAppender">
		<file value="logfile/allMessages.log" />
		<appendToFile value="true" />
		<layout type="log4net.Layout.PatternLayout">
			<conversionPattern value="%date  %-5level %logger  - %message%newline" />
		</layout>
	</appender>

	<appender name="ErrorsFileAppender" type="log4net.Appender.FileAppender">
		<file value="logfile/errorsLog.log" />
		<appendToFile value="true" />
		<layout type="log4net.Layout.PatternLayout">
			<conversionPattern value="%date  %-5level %logger  - %message%newline" />
		</layout>
		<filter type="log4net.Filter.LevelRangeFilter">
			<levelMin value="ERROR" />
			<levelMax value="FATAL" />
		</filter>
	</appender>

	<root>
		<level value="ALL" />
		<appender-ref ref="FileAppender" />
		<appender-ref ref="ErrorsFileAppender" />
	</root>
</log4net>
```


>> Now your Asp.net Core application is ready to use log4net logging

Sample Code for logging

```csharp
public class MyController : Controller
{
   private readonly ILogger<BloggerClientController> _logger;
   public MyController(ILogger<MyController> logger)
   {
       _logger = logger;
   }
   public IActionResult Index()
   {
       _logger.LogInformation("Index Action Called");
   }
}
```



[//]: # (Tags: Asp.Net Core, Log4Net, Logging, Add Log4Net to Asp.net Core)
[//]: # (Type: Asp.Net Core - Logging)
[//]: # (Rating: 1)
[//]: # (Languages:C#,XML,powershell)
[//]: # (ReadyState:Publish)
