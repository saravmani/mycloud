#### Redis With Docker
###### Redis With Docker
>
Note: Default port for REDIS is  - 6379
* To run redis in docker container run below containers
```powershell
    docker pull redis
    docker run -d -p 6379:6379 --name my-redis redis
```
 * Now redis is running in docker environment

 * To check the Redis running status we can check the logs
 ```powershell
      docker logs -f my-redis
 ```

###### To Run redis commands we have to connect with container's terminal
```powershell
    docker exec -it my-redis redis /bin/bash
```
Once entered into terminal, type below command to interact with Redis
```powershell
    redis-cli # this command will start interactive terminal with redis cache
```

###### Some of the usefull REDIS commands
```powershell
    > ping  # To test redis running status. If this comand returns PONG then redis working fine
    > set SomeKeyName SomeSampleValue # To save some value in Key Value format
    > get SomeKeyName
```
---
#### Steps to connect with REDIS from Asp.net Core application
###### Install nuget package on your .Net Core project
```powershell
PM> Install-Package StackExchange.Redis
```

```csharp
//To Connect with Redis cache
ConnectionMultiplexer objConnetionMultiplexer = ConnectionMultiplexer.Connect("localhost:6379");
IDatabase objDatabase = objConnetionMultiplexer.GetDatabase();


// To Save / Update Data
bool isSavedOrUpdated = objDatabase.StringSet("SomeKeyName","SomeSampleValue");
// Note we convert complex objects in to JSON fromat  and then save it

// To Fetch data from cache
var data = objDatabase.StringGet("SomeKeyName");

//To Delete
bool isDeleted = objDatabase.KeyDelete("SomeKeyName");
```


[//]: # (Tags: Redis With Docker, Docker)
[//]: # (Type: DB - Redis)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:InProgress)
