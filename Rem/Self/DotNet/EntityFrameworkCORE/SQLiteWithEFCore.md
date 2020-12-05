#### Steps to use SQLite with .net core

1. Create new .net Core project

2. Open Package manager console (Tools->Nuget Package Manager->Package Manager Console) and  Run below-mentioned commands to install the required packages

```
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools
```

3. Create POCO class (Modal) which is equal to the table in DB
  > Ex:
```csharp
 Public class StudentDetails
 {
        [Key]
        public int RecordId { get; set; }
        public string StudentName{ get; set; }
 }
```

4. Create DB Context Class
     > Ex:
```csharp
public class StudentManagerContext : DbContext
{
        public DbSet<LockerItem> LockerItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=DBFileName.db");
}
```
5. Run below-mentioned commands to Create SQLLite db
    > Ex:
```
add-migration <MigrationName>  //Ex: add-migration IntialMigration
update-database
```

6. Now DB file will get created in the root and Based on model tables will be created

#### Now DB is ready and we can able to access the database
Sample code to access db:
```csharp
using (var objDBContext = new StudentManagerContext())
{
     objDBContext.LockerItems.Add(objStudent);
     objDBContext.SaveChanges();
}
```


[//]: # (Tags- SQLite, EF Core, EF Core Migration)
[//]: # (ReadyState:Publish)
