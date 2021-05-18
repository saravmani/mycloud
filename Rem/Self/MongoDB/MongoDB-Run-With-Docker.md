#### Mongo DB Run With Docker
###### Download docker image of MongoDB

>Refer- [Frequently used Docker commands](../Docker/Containers/Docker-Frequently-Used-Comments.md)
>Refer- [Frequently used MongoDB commands](MongoShellCommands/Mongo-DB-Commands-Frequently-Used.md)

```
docker pull mongo
```

> Note: Standard port for MongoDB - 27017

```powershell
docker run -d -p 27017:27017 --name microserices-test mongo

# This command will star tht container with name of "microserices-test"
# Opening 27017 port and forwad the same
```

###### Run Mongo DB commands against docker container
```powershell
docker exec -it microserices-test /bin/bash
# -it switch for interactive
```
> With this command we can able to access docker containers terminal and execute the commands interactively. Now type *mongo* in command prompt to interact with mongo db

```powershell
> mongo # To interact with Mongo DB. Now mongo CLI started

```


[//]: # (Tags: Mongo DB Run With Docker, Docker)
[//]: # (Type: MongoDB - Environment-Setup)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Inprogress)
