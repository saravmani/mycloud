#### Entity Framework Core Migration Commands
###### Frequently used Entity Framework Core migration related commands

```csharp
PM> add-migration <MigrationName>  //  Creates new migration

PM> remove-migration //  Removes last migration and also reverts the related cs files

PM> remove-migration -force //  Removes last migration when migration has update in db

PM> update-database //  Applies migration on Database
```



[//]: # (Tags: EFCore, Migration Commands, Entity Framework Core Migration Commands)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 3)
[//]: # (Languages:C#,powershell)
[//]: # (ReadyState:Publish)
