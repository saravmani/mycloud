#### Steps to use SQLite with .Net Core
###### Simple steps to install and use SQLite & Entity framework Core along with .net core applicaiton


1. Create new .net Core project

2. Open Package manager console (Tools->Nuget Package Manager->Package Manager Console) and  Run below-mentioned commands to install the required packages

```powershell
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools
```

3. Create POCO class (Modal) which is equal to the table in DB

```csharp
//Sample Model Class
 Public class StudentDetails
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
        public DbSet<LockerItem> LockerItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=DBFileName.db");
}
```
5. Run below-mentioned commands to Create SQLLite db *(Run this in package manager console)*

```powershell
add-migration <MigrationName>  //Ex: add-migration IntialMigration
update-database
```

6. Now database file get generated root folder and ready for usage


Sample code to access db:

```csharp
using (var objDBContext = new StudentManagerContext())
{
     objDBContext.LockerItems.Add(objStudent);
     objDBContext.SaveChanges();
}
```


[//]: # (Tags: SQLite, EF Core, EF Core Migration)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 1)
[//]: # (ReadyState:Publish)
