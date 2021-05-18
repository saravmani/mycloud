
##### Steps to install and run mongodb
> #Refer - [Steps to install and run mongodb](MongoDB-Run-With-Docker.md)


##### Handy Frequently Used MongoDB Commands
> #Refer - [MongoDB Commands](MongoShellCommands/Mongo-DB-Commands-Frequently-Used.md)

##### Install required nuget packages
```powershell
PM> Install-Package MongoDB.Driver #For latest driver

PM> Install-Package MongoDB.Driver -Version {version number} #For specific version
```

###### Connecting to Mongo DB
> In appsettings.json file specify the MongoDB connection string
```js
{
  "myMongoDBSettings":{
    {
      "ConnectionString":"mongodb://localhost:27017",
      "DatabaseName":"db_name",
      "CollectionName":"Students"
    }
  }
}
```



Model Class for MongoDB

```csharp
public class Student
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)] // Says this is identity column. And this value automatically assigned
  //This will have 24 Characters
  public string Id{get;set;} // NOTE - we are using STRING as type. Because MongoDB will generate BSON Id as string
  [BsonElement("SomeOtherNameInMongo")]
  public string StudentName{get;set;}
  public string ClassSection{get;set;}
  // As this is NoSQL DB this property will be JSON data
  public int Rank {get;set;}
  // NOTE - this is an integer
  //.. More properties
}
```



###### CRUD Operations
```csharp
var client = new MongoCLient("connectionstring");
var db = client.GetDatabase("my-db");
var studentsDB = database.GetCollection<Students>("Students");
studentsDB.InsertMany(/*<list of student object>*/);
studentsDB.InsertOne(objStudent)

studentsDB.Find(a=>true).Any();// to find is there any record in the collection

//To filter by student id
FilterDefination<Student> objFilter = Builders<Student>.Filter.Eq(p=>p.StudentId, "ID-STD1");
studentsDB.Find(objFilter).ToList();

//To UPdate
var response = studentsDB.RepoaceOneAsync(filter:a.Id=>"someid",replacement:newStudentObject);
// rsponse.ModifiedCount
// rsponse.IsAcknowledged

//To Delete
var rsponse = studentsDB.DeleteOneAsync(..);
// rsponse.ModifiedCount
// rsponse.IsAcknowledged
```
