
##### What is Cloud foundry
Cloud Foundry is open-source PaaS (Platform as a service). We can think CF is a abstraction layer on top of Infra+OS+RunTime.
Cloud Foundry can run on Onproimise or on IaaS like vSphere, AWS, Azure, GCP, or OpenStack. We can call it Vendor Neutral. CF is independent of any cloud provider.


Cloud foundry readily provides - VM, OS, N/W + Runtime

##### Infra stack for PCF
In Cloud Foundry we can focus only on application and data. rest of the items will be taken case by Cloud Foundry

![](../../RefImages/PCF_PaaS.PNG)

---

##### Cloud Foundry Isolation Levels
Orgs and spaces are used to isolate the spaces within Cloud Foundry



###### Orgs
Org is a development Account that an individual or multiple collaborators can own and use. Org contain multiple spaces

###### Spaces
- Applicaiton will be deployed at space level. An org can contain multiple spaces - Ex: Dev, UAT ,PROD etc.,. Every app, service, and route is scoped to a space.
- Space can host multiple apps. 




In Cloud controller we have to create Namespace for our project

###### Diego ..  (i.e TKGI is container)
Diego is a self-healing container management system that attempts to keep the correct number of instances running in Diego cells to avoid network failures and crashes. Diego schedules and runs Tasks and Long-Running Processes (LRP)


Multiple infra providers for Cloud foundry including
Azure, Amazon, Google cloud platform (GCP), AliCloud, Vmware


##### Best practices for cloud native applicaiton
  Local file system should not be used. Try to use standard file system (cloud based is best)
  Dont use domain level cookies



###### What CF push command do
- Check YML file in local directroy (we can able to pass non standard YML file path as parameter to the command)
- Cloud controller get intimation about new applicaion and CC will stores the meta data of the applicaition
- run push command with run pack
- Uploades the files
- then creates deployment artifact by combining buildpack+source code+dependencies+configuration
- Then container will be created for the applicaiton then pushed
- And app started

###### Routes
1. we can create internal domains to communicate the applications between them
