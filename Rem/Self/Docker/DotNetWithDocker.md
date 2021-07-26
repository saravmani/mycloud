
Docker Desktop - Used in local machine (Developer system, Laptop), to build solutions based on docker and test it
Docker Engine - Used in Server to run the produciton applicaitons


###### Docker registeris
There are multiple registeries are available from where we can download existing images.
Ex:
  hub.docker.com
  mcr.microsoft.com -- Microsoft's official

###### Docker benefits
1. Scaling up is easly
2. Rollbacks are easy
3. we can try the images in local without installing anything on local machine


 Official .NET Docker images are Docker images created and optimized by Microsoft.
 They are publicly available in the Microsoft repositories on
 [Docker Hub](https://hub.docker.com/u/microsoft/)


###### Microsoft provides 3 base OS images
1. **Nano Server** - (suitable for .net core,5,6 applications). Microsoft created .net core runtime, aspnet, sdk images on top of this Nano server. *Note-This nano server will only support 64bit applicaitons*. This will not contain PS, so we cannot run ps scripts. Very less in size. No powershell.

2. **Windows-Server Core** -  (suitable for .net full framework applicaitons). Microsoft created full framework images (ex: 4.8) on top of Windows/Servercore image.
This like normal windows OS but without UI. Also most of the windows features are not enabled by default. Can run x86 and x64 bit applications. Powershell available.

3. **Windows** - This contains full Windows 10 OS. Suitable for some legacy applicaitons which requires full OS. But microsoft not provides any images for .net with full windows as base container. We have to build as per the requirement. Contains UI and GPU so if any applicaiton uses libraries related to UI dlls then we can use full windows image as base image

Docker images for .Net Framework (.net full framework like .Net 4.8)
Base image for .net Framework is - *mcr.microsoft.com/windows/servercore:lts2019*


> Note: All the Microsoft Official image names are starts with **mcr**
> *Ex: - mcr.microsoft.com/dotnet/aspnet:5.0*


Containers will share the base image. For example if we install below images, then Aspnet and SDK images will share the Servercore image. So it will not consume more memory. Also down time will be less.
1. Windows server core
2. Dotnet-Framework-Aspnet
3. Dotnet-Framework-SDK


#### Docker compose Vs Kubernetes
###### Docker
Docker compose suits for dev
used for single host envrionment .. not suits for cluster



###### Logging in dockererised applicaitons
Docker by default watch console application's prints and stores that as container logs.
This works with console applicaitons which are doing Console.WriteLine or console.Error
But other types of logs will not be part of container logs.
Docker by default watch stdoutput of applicaiton which is running in  foreground  (ex: console application).
we can able to access those container logs even after container stopped .
Docker can work with other standard logging systems like Splunk, Event Viewer , Graylog (of the host system) etc.,
