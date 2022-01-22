# Log SQL Queries in EntityFramework Core
###### Steps to add logging mechanism to EF Core project to log SQL queries to console/ file/ debug window

1. Install nuget package  - Microsoft.Extensions.Logging

```powershell
PM> Microsoft.Extensions.Logging
```
2. In DbContext class add below code to create logger factory

```csharp
 public static readonly ILoggerFactory objLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
```
3. Configure LoggerFactory in OnConfiguration method of dbcontext class

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
  optionsBuilder.UseLoggerFactory(objLoggerFactory);
  //.. Other configurations
}
```
---

###### Full DbContext Class Code with logging
```csharp
public class MyDbContext : DbContext
  {
      public DbSet<UserDetail> UserDetails { get; set; } // DB Model
      public static readonly ILoggerFactory objLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseLoggerFactory(objLoggerFactory);
          optionsBuilder.UseSqlite(@"Data Source=DBLayer\MyDB.db");
          base.OnConfiguring(optionsBuilder);
      }
  }
```

[//]: # (Tags: Add Logging in Entity Framework Core, EFcore Logging, Entity Framework Core Logging)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 1)
[//]: # (Languages:C#,powershell)
[//]: # (ReadyState:Publish)
