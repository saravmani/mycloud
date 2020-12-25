#### Add Logging functionality to Entity Framework Core Project
###### Easy steps to add logging mechanism to Entity framework core project

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
      public DbSet<UserDetail> UserDetails { get; set; }
      public static readonly ILoggerFactory objLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseLoggerFactory(objLoggerFactory);
          optionsBuilder.UseSqlite(@"Data Source=DBLayer\MyDB.db");
          base.OnConfiguring(optionsBuilder);
      }
  }
```

[//]: # (Tags: EFCore, EFcore Logging, EntityFrameworkCore Logging)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 1)
[//]: # (ReadyState:Publish)
