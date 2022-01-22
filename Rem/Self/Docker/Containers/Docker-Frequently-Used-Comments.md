# Useful Docker Commands
###### Frequently used docker commands


```powershell

docker -version #to Get installed docker version
docker pull image-name
docker run -it -d image-name #Creates container from image
          # -it means interactive mode.
          # --rm if we add this switch then container will get removed once its work done
          # -e ENVIRNMENT_VARIABLE_NAME=SOMEVALUE

docker run -e ENVIRNMENT_VARIABLE_NAME=SOMEVALUE image-name # To set the environment variable for the container
docker log container-id
docker compose up # to run multiple containers
```

###### To Remove Containers and Images
```powershell
docker stop $(docker ps -aq) # to stop all containers
docker rm $(docker ps -a -q) # to remove all stopped CONTAINERS
docker rmi $(docker images -q) #to remove all IMAGES
docker rmi <image id> # to remove image by image id
docker rm <container id> #to remove stopped container
docker system purne # will remove stopped containers, not used networks, Cache  etc.,
```

###### To listdown

```powershell
docker images   #to get list of images
docker container list # lists the containers with running status
docker container list -a #lists the containers with or without running status
docker ps #shows running list of running images
docker ps -a #shows running list of running and exited containers
docker port <container name>  # To listdown list ports used by the container
docker logs <conainer name> # To read the Container logs. This will get the logs even if the container in not running state

```

###### To Start and Stop containers

```powershell
docker stop $(docker ps -aq) #to stop all containers
docker start <container id>
docker stop <container id>
```

###### To Run Container with interactive mode
> Note: With interactive mode we can able to execute the commands in our system's terminal and the command actually executes in container

###### Command to run bash in docker

```powershell
docker exec -it bloggerDocDB /bin/bash
# Interact with Linux containers
docker exec -it microblogger_bloggerservice_1 cmd.exe
# Interact with Windows containers
```
Two switches are there for this command
* i - to run container interactively mode
* t - commands typed in our terminal, will get executed within container's terminal and produces output in outside

###### Debugging/ View logs in docker
```ini
docker logs -f <Contianer_Name>
# To view the Image Running Status, Logs  and Live Logs
```

###### Docker Compose

```powershell
docker-compose -f docker-compose.yml  -f docker-compose.override.yml up -d
# up -  To up the Containers
# down -  To stop the Containers

```

[//]: # (Tags: Frequently Used Docker Commands, Docker with interactive Mode, Docker)
[//]: # (Type: Docker - Commands)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Publish)
