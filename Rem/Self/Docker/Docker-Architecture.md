---
tags: ['Docker','Architecture','Container']
---
# Docker Architecture

### Short Discussion on Docker Architecture

###### Docker Architecture from docker official website
![](https://docs.docker.com/engine/images/architecture.svg)

- In windows docker can able to run windows container and linux containers.

:::note
*So using this we can able to run windows software and linux software on windows* :-)
:::

- Docker image files are actually very small

- Docker provides isolated complete environment. Application will have all the items within this container
  > Ex: if it is a node js application then docker image has
Application + nodejs. If we deploy this image in any machine, that machine no need to have NodeJS into it. Because docker image has

- Docker can able to share the base libraries
  > ex: if we want to run node js application on 3 containers, then all those containers no need to have NodeJS copy. And that container can share this



:::caution Install Docker on Windows 10
To install docker on windows 10 it needs hyper-v enabled.
But windows 10 home edition not having hyper-v option.
so we need to update windows home edition to windows 10 professional
:::



[//]: # (Tags: About docker, docker Architecture)
[//]: # (Type: Docker - Architecture)
[//]: # (Rating: 2)
[//]: # (Languages:ini)
[//]: # (ReadyState:Publish)
