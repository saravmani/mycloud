#### Docker Commands
###### Frequently used docker commands
>
```csharp
docker -version //to Get installed docker version
docker pull <image name>
docker run -it -d <image name> //Creates container from image
docker log <container id>
docker compose up // to run multiple containers
docker logs -t {container name} //to get the logs
```

> To Remove
```csharp
docker stop $(docker ps -aq) //to stop all containers
docker rm $(docker ps -a -q) // to remove all stopped CONTAINERS
docker rmi $(docker images -q) //to remove all IMAGES
docker rmi <image id> // to remove image from local storage
docker rm <container id> //to remove stopped container
```

> To listdown

```csharp
docker images   //to get list of images
docker container list // lists the containers with running status
docker container list -a //lists the containers with or without running status
docker ps //shows running list of running images
docker ps -a //shows running list of running and exited containers

```

> To Start and Stop containers

```csharp
docker stop $(docker ps -aq) //to stop all containers

docker start <container id>

docker stop <container id>
```

###### To Run Container with interactive mode
> Note: With interactive mode we can able to execute the commands in our system's terminal and the command actually executes in container

###### Command to run bash in docker

```csharp
docker run -it ngnix:1.13.8 /bin/bash
```
Two switches are there for this command
* i - to run container interactively mode
* t - commands typed in our terminal, will get executed within container's terminal and produces output in outside


[//]: # (Tags: Frequently Used Docker Commands, Docker with interactive Mode, Docker)
[//]: # (Type: Docker - Commands)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Publish)
