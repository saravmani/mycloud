
###### Add New configration section in appsettings.json
```js
//example
{
  "MongoDBSettings":{
    {
      "ConnectionString":"mongodb://localhost:27017",
      "DatabaseName":"db_name",
      "CollectionName":"Students"
    }
  }
}
// ... Other settings
```

###### Strongly Typed Configuration
```csharp
  var configObject = config.GetSection(nameof(TypedClassName)).Get<TypedClassName>();
  // Try to use nameof(TypedClassName) instead of string. This approch will ensure type safety
```

###### Create equalent model class
```csharp
public class MongoDBSettings
{
  public string ConnectionString { get; set; }
  public string DatabaseName { get; set; }
  public string CollectionName { get; set; }
}
```

###### Configure the new section in Startup.cs file
```csharp
service.Configure<MongoDBSettings> (Configuration.GetSection(nameof(MongoDBSettings)));

services.AddSingleton<MongoDBSettings>(
      sp=>sp.GetRequiredService<IOptions<MongoDBSettings>>().Value
  );
//Where ever framework fineds MongoDBSettings in constructure then it will inject the object of MongoDBSettings
```

```csharp
var client = new MongoCLient("connectionstring");
var db = client.GetDatabase("my-db");
var students = database.GetCollection<Students>("Students");
students.InsertMany(..);
students.InsertOne(..)

students.Find(a=>true).Any();// to find is there any record in the collection

//To filter by name
FilterDefination<Student> filter = Builders<Student>.Filter.ElemMatch(p=>p.Name, "somename");
students.Find(filter).ToList();

//To UPdate
var response = students.RepoaceOneAsync(filter:a.Id=>"someid",replacement:newStudentObject);
// rsponse.ModifiedCount
// rsponse.IsAcknowledged

//To Delete
var rsponse = students.DeleteOneAsync(..);
// rsponse.ModifiedCount
// rsponse.IsAcknowledged

```
