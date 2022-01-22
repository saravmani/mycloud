# Dapper Vs EntitiyFramework
##### Discussion on advantages of Dapper and practical scenario where we can use Dapper
>

###### About Dapper
  Dapper is not a full ORM framework like EntitiyFramework. It acts as a simple object mapper for the dataset. Also we call it as Micro ORM :-).
It is very lightweight and it is not having many features which are owned by EntitiyFramework
* Ex: Dapper does not have below features
  * Caching
  * SQL Query generation
  * Managing Unit of Work

Dapper provides a set of extension methods for ADO.NET's Connection object. Dapper doesn't have a query generator, it will work with raw queries

> *Dapper available for .net 4.6.1+ and .net Core*

###### Sample code for with dapper
```csharp
var sqlQuery = "Select StudentName, StudentAddress from Students";
using (var objConnection = new SqlConnection("Connection String"))
{
    var studentsList = objConnection.Query<Students>(sqlQuery);
}
```
###### NuGet  package for Dapper
```powershell
PM> Install-Package Dapper -Version 2.0.90
```

###### Where to use dapper?
As we know EntitiyFramework is full ORM and it has a lot more functionalities than Dapper. As Dapper is lightweight it gives better performance over ORM.
From my point of view, Dapper will fit for the projects where performance is the key. For example, if we are working with a huge volume of data then we can choose Dapper over EntitiyFramework


[//]: # (Tags: Dapper, Advantages of Dapper, Use cases for Dapper, where to use Dapper)
[//]: # (Type: Dapper - Discussion)
[//]: # (Rating: 2)
[//]: # (Languages:csharp)
[//]: # (ReadyState:Publish)
