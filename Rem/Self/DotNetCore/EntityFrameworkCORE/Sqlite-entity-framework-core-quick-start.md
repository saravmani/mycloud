# Steps to use SQLite with Entity Framework Core - A quick start guide
###### Simple steps to install and use SQLite & Entity framework Core along with .Net core application

>

1. Create new .net Core project

2. Open Package manager console (Tools->Nuget Package Manager->Package Manager Console) and  run the below-mentioned commands to install the required packages

```powershell
PM> Install-Package Microsoft.EntityFrameworkCore

PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite

PM> Install-Package Microsoft.EntityFrameworkCore.Tools
```

3. Create POCO class (Modal) which is equal to the table in DB

```csharp
//Sample Model Class
 public class StudentDetails
 {
    [Key]
    public int RecordId { get; set; }
    public string StudentName{ get; set; }
 }
```

4. Create DB Context Class

```csharp
//Sample DBContext Class
public class StudentManagerContext : DbContext
{
        public DbSet<StudentDetails> StudentDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=DBFileName.db");
}
```



5. Run the below-mentioned commands to Create SQLLite db *(Run this in package manager console)*

```csharp
PM> add-migration <MigrationName>  //Ex: add-migration IntialMigration
PM> update-database --verbose // Note: Here verbose switch helps us to se generated sql
```

6. Now database file get generated root folder and ready for usage


Sample code to access DB:

```csharp
using (var objDBContext = new StudentManagerContext())
{
     objDBContext.StudentDetails.Add(objStudent);
     objDBContext.SaveChanges();
}
```

---


###### Best practices to create DB Context object and configure it
Instead of creating the object directly we can use dependency injection.
Microsoft.EntityFrameworkCore.Sqlite package provides extension methods to register DB context and configure.
```csharp
// Startup.cs file under ConfigureServices() method add below code
  services.AddDbContext<StudentManagerContext>(opt=>opt.UseSqlite("Data Source=DBFileName.db"));

```


---

###### Advantages of SQLite
1. Lightweight
2. No Installation required. With help of Nuget Package, we can use this with .Net applications
3. Options to use it as in-memory database

###### Disadvantages
1. Memory size limited
2. It cannot handle a huge volume of requests
3. Less tooling

---
###### Use cases of SQLite
1. We can use it for simple Desktop applications, Mobile applications
2. Use it for Caching purpose



[//]: # (Tags: SQLite with Entity Framework Core, SQLite with .Net Core, EF Core Migration)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 1)
[//]: # (Languages:C#,powershell)
[//]: # (ReadyState:Publish)
