###### High Level Cloud Foundry Components and Artifacts
* Diego
* Cloud Controller
* GoRouter
* Blob Store
* Auth Service (UAA)
* Services (Like DB services)
* Logs and Metrics


###### Router
The router routes incoming traffic to the appropriate component, either a Cloud Controller component or a hosted application running on a Diego Cell. The router periodically queries the Diego Bulletin Board System (BBS) and udates it's database

Below are some of the Router components
* GoRouter - Routes HTTP traffic
* TCP Router - Routes TCP Traffic
* Routing Database

---
##### Cloud Controller
Cloud Controller is responsible deployment lifecycle. To push an app we have to target the Cloud Controller.
###### Cloud Controller Roles
* Handles the Deployment
* Handle Scaling requests

---
#### Blobstore
To Store large binary files like
* Droplets
* Packages required for applications
* Build packs
 ---


###### Diego
Diego is a Container management system  used in Cloud Foundry


###### Diego Cells
Used to run the droplet. Diego cells scheduled and managed by Diego.



###### What is buildpack
Buildpacks used to create a runnable image.
Buildpack contains executables which inspects applicaiton source code and create a plan to Build and Run your application.  provides feedback metadata to Cloud Foundry indicating how the app should be executed.
Buildpacks contains scripts which helps CF to indentify runtime or framework for the application


Typical buildpacks consist of at least three files:
  buildpack.toml – provides metadata about your buildpack
  bin/detect – determines whether buildpack should be applied
  bin/build – executes build logic



###### Buildpacks
Build pack service - Takes care of building the applicaion.
While doing CF push it will detect the type of applicaiton by using config files and check the buildpacks for compatibility.
We can also provide a build pack expilicitly.

###### Droplet
Executable unit with ready to run state and Meta data. This droplets directly runnable on Diego cell. Droplet will be created when staging process completes
