#### Discussion on Docker File and Docker Compose File
###### Discussion on Docker File and Docker Compose File


###### Docker File
- It basically a configuration file. Which contains information about
*Dependences, What to do? How to do etc.,*. We can say Docker file helps to dockerize a given applicaiton
- Mostly It contains 2 parts
  * Building the applicaiton
  * Run the applicaiton



To Orchestrate we need docker-compose file
  - docker-compose.yml
  - docker-compose.override.yml
    *It can contain configuration overrides for existing services or entirely new services. Use case for multiple files is based on envrionment we can have multiple override files*

  ###### Sample docker-compose.yml file for .net core WebApi project
  ```ini
  version: '3.4'

services:
    bloggerDocDB:
        image: mongo

    bloggerservice:
        image: ${DOCKER_REGISTRY-}bloggerservice
        build:
          context: .
          dockerfile: BloggerService/Dockerfile
volumes: # it specifies the storage outside of container. In our case if container restarts then mongo db data or other data will get lost.
            #if it needs be persisted the we can use volumes. This data will get stored in hosting machine. Even if image has removed and recreated this data will be availabe in host machine
    mongo_data:
  ```

  ###### Sample docker-compose.override.yml file for .net core webapi project
 ```ini
version: '3.4'
services:
    bloggerdb:
        container_name: bloggerdb
        restart: always
        #Always restarts the applicatoin in case of ERROR
            volumes:
                - ${WEBAPP_STORAGE_HOME}/SITE:/data/db
                # Store the data which is generated by container. It is a permenant storage
            ports:
               -"27017:27017"

    bloggerservice:
        environment:
          - ASPNETCORE_ENVIRONMENT=Development
          -"DBSettings:ConnectionString=mongodb://bloggerdb:27017"
          # Note here *bloggerdb* is actually a container name
          # Within docker env. we have to use container name and *Actual* port
        depends_on:
           - bloggerdb
           # Which means the second container WILL NOT wait till first container started completely. it just say the order
         volumes:
            - ${HOME}/.microsoft/usersecrets/:/root/.microsoft/usersecrets
            - ${HOME}/.aspnet/https:/root/.aspnet/https/
        ports:
          - "5000:80"


  ```


```ini
docker-compose -f docker-compose.yml  -f docker-compose.override.yml up -d
# -d to run in background
# Here based on env we can pass the override filename
```


[//]: # (Tags: About dockerfile, docker-compose file, containerize )
[//]: # (Type: Docker - containerize)
[//]: # (Rating: 2)
[//]: # (Languages:ini)
[//]: # (ReadyState:Publish)