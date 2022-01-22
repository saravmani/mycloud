# What is Shadow Property Foreign Key in Entity Framework Core
###### Entity framework Core uses shadow foreign key property, When there is no actual foreign key property defined ..

  > In entity framework if foreign key property is NOT defined, a shadow foreign key property will be introduced by default.

  > Note - But it is not recomended to not create foreign key property. We should define foreign key in dependent class

  > Ex:
```csharp
 Public class StudentDetails // Principle entity
 {
    [Key]
    public int StudentId { get; set; }
    public string StudentName{ get; set; }
 }
 Public class StudentAttendance // Dependent entity
 {
    [Key]
    public int AttendanceId { get; set; }
    public string SubjectName{ get; set; }
    public StudentDetails StudentDetails {get;set;}
      //Note here we have not defined foreign key for student id
      //In this case shandow foreign key will get generated automatically
    ...
 }
```

[//]: # (Tags: Shadow Foreign Key - Entity Framework Core, Shadow Property Foreign Key)
[//]: # (Type: Asp.net Core - EntityFrameworkCore)
[//]: # (Rating: 2)
[//]: # (Languages:C#,powershell)
[//]: # (ReadyState:Publish)
