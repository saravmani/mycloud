# Entity Framework Core Migration Commands
###### Frequently used EF Core migration related commands and their purpose

```powershell
PM> add-migration <MigrationName>  #Creates new migration

PM> remove-migration #Removes last migration and also reverts the related cs files

PM> remove-migration -force #Removes last migration when migration has update in db

PM> update-database #Applies migration on Database
PM> update-database --verbose #Note: Here verbose switch helps us to se generated sql

PM> Script-Migration #Generates SQL script based on all migration snapshots
```



[//]: # (Tags: EFCore, Migration Commands, Entity Framework Core Migration Commands)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 3)
[//]: # (Languages:C#,powershell)
[//]: # (ReadyState:Publish)
