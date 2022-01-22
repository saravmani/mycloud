#### How To Use Automapper
######  How To Use Automapper
>

###### Required Nuget Packages to use Automapper in Asp.net Core application
```powershell


PM> Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection

```

###### To Map the source object to **EXISTING** destination object
```csharp
objMapper.Map(objStudentVm,objStudentEntity,typeof(StudentVm),typeof(StudentEntity))
```


[//]: # (Tags: Automapper)
[//]: # (Type: Asp.NetCore - Automapper)
[//]: # (Rating: 2)
[//]: # (Languages:csharp)
[//]: # (ReadyState:Inprogress)
