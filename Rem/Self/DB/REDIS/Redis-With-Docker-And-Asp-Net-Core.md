# Redis With Docker And Asp.net Core
###### Simple steps to host Redis With Docker and Connect with Asp.net Core application
>
>Refer- [Frequently used Docker commands](../../Docker/Containers/Docker-Frequently-Used-Comments.md)


* To run Redis in docker container run below containers

```powershell
    docker pull Redis # pulls the docker image
    docker run -d -p 6379:6379 --name my-redis redis
    # Creates container from image and run the container
```
 * Now Redis is running in a docker environment

 * To check the Redis running status we can check the logs
 ```powershell
      docker logs -f my-redis
 ```

> *Alpine Linux is much smaller than most distribution base images (~5MB), and thus leads to much slimmer images in general.  So try to use Alpine-based images. For Redis also we are having alpine version*

* To Pull the Alpine version of Redis use the below command
```powershell
  docker pull redis:alpine
```

>*Note: Default port for Redis is  - 6379*

---

###### How to run Redis Commands
* Run below mentioned commands in powershell to access container's terminal
```powershell
    docker exec -it <container_name> /bin/bash
    # For Linux Container
    docker exec -it <container_name> cmd.exe
    # For Windows Container
```
* Once entered into the terminal, run the below command to interact with Redis
```powershell
    redis-cli # this command will start interactive terminal with redis cache
```


###### Some of the useful and frequently used Redis commands
```powershell
    > ping  # To test Redis running status. If this comand returns PONG then Redis working fine
    > set SomeKeyName SomeSampleValue # To save some value in Key Value format
    > get SomeKeyName
```

---

###### Steps to connect with Redis from Asp.net Core application
Install NuGet StackExchange.Redis package on your .Net Core project
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


[//]: # (Tags: Redis With Docker, Docker, Redis With Asp.net Core, Connect Asp.net core application with docker, Usefull redis comments)
[//]: # (Type: DB - Redis)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Publish)
