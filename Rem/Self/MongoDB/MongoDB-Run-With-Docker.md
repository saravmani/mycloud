#### Mongo DB Run With Docker
###### Download docker image of MongoDB

```
docker pull mongo
```

> Standard port for MongoDB - 27017

```csharp
docker run -d -p 27017:27017 --name microserices-test mongo

/*  This command will star tht container with name of "microserices-test"
    opening 27017 port in my machine
    and forwading the same
    MongoDB's Default port fromt he container
*/

```

###### Run Mongo DB commands agains docker container
```csharp
docker exec -it microserices-test /bin/bash
// -it switch for interactive
```
> Whith this command we can able to access docker containers terminal and execute the commands interactively

```csharp
mongo // to interact with Mongo DB. Now mongo CLI started

```


[//]: # (Tags: Mongo DB Run With Docker, Docker)
[//]: # (Type: MongoDB - Environment-Setup)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Inprogress)
