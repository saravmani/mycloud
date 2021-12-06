#### Docker Commands
###### Frequently used docker commands
>
```powershell
docker -version #to Get installed docker version
docker pull <image name>
```
<u>For Under Line Text</u>


##### To Add splittor line
---
##### To Add References
>Document ref
>Refer- [Frequently used Docker commands](../Docker/Containers/Docker-Frequently-Used-Comments.md)

- Display Image from local
![](RefImages/PCF_PaaS.PNG)
![](../../../../../RefImages/DIPrinciple_Example1.PNG)
![](../../../../../RefImagesPrivate/EFCoreGenericDBOperations.PNG)


- Display Image Reference
![](http://www.google.com.au/images/nav_logo7.png)


- Image link
[![Optional Text](http://www.google.com.au/images/nav_logo7.png)](http://google.com.au/)

###### Mermaid
* Flowchart
```mermaid
flowchart LR
  A(Microservice1 - With GRPC Server)
  B(Microservice12 - With GRPC Server)
  C(Aggregator - With GRPC Client)
  D(Api Gateway)
  E[End User]

subgraph MicroServices
  A
  B
end
E--->D
D --> C

C --> A
C --> B
```
* Graph
```mermaid
graph LR
  A --- B
  B--->C[fa:fa-ban forbidden]
  B-->D(fa:fa-spinner);
```



[//]: # (Tags: Frequently Used Docker Commands, Docker with interactive Mode, Docker)
[//]: # (Type: Docker - Commands) --Here - is important otherwise my code gives error :-)
[//]: # (Rating: 2)
[//]: # (Languages:powershell,powershell,ini)
[//]: # (ReadyState:Inprogress|Publish)
