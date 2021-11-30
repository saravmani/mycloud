
###### What is Cloud foundry
Cloud Foundry is opensource PaaS(Platform as a serivice) and it can run on Azure, OpenStack, Onprimise, AWS etc.,. We can call it as Vendor Neutral.
CF is independent of any cloud provider.

> *CF is best for microservices Architecture. It can run multiple runt times, handle different type of work loades, can use different OS*

Cloud foundry readily provides - VM, OS, N/W + Runtime


###### Orgs
Org is a development Account that an individual or multiple collaborators can own and use

###### Spaces
- Where we deploy the app
- A space provides users with access to a shared location for app development, deployment, and  -maintenance.
- An org can contain multiple spaces - Ex: Dev, UAT ,PROD etc.,
- Every app, service, and route is scoped to a space




In Cloud controller we have to create Namespace for our project

###### Diego ..  (i.e TKGI is container)
Diego is a self-healing container management system that attempts to keep the correct number of instances running in Diego cells to avoid network failures and crashes. Diego schedules and runs Tasks and Long-Running Processes (LRP)


Multiple infra providers for Cloud foundry including
Azure, Amazon, Google cloud platform (GCP), AliCloud, Vmware


###### Cloud foundry components
1. Routing (Entry point .. act as load balancer also)
2. Authentication (UAA service)
3. Execution
4. Services (Like DB services)
5. Messaging (Communicaiton)
6. Logs and Metrics


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



###### Revisions (i.e Deployment versions)
We can relate Revisions to applicaiton versions. If we want to reverse back to old version
of the deplyment we can use this revisions to rollback.
A revision represents code and configuration used by an app at a specific time.
This allows you to deploy a version of the app that you had running previously without needing to track that previous state yourself or have multiple apps running.
> **Even if we update the environment variable this will create a new revision**
