#### RabbitMQ
###### RabbitMQ - Host RabbitMQ in Docker and consume from Asp.net Core application
>



###### Run RabbitMQ with Docker
To Run RabbitMQ with Docker follow below simple stelps.
1. Download official RabbitMQ Image from Docker hub and run using below Command
```csharp
docker run -d --hostname first-rabbit --name test-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
// Port - 15672 for RabbitMQ administration dashboard
// Port - 5672 Actually used by RabbitMQ
```
2. Now RabbitMQ should be running in your local system
3. Browse the URL - http://localhost:15672/ to access RabbitMQ's admin dashboard
   - default credentials - guest/guest

---
###### Connect Asp.Net Core with RabbitMQ
To Connect/ Use Rabbit MQ in Asp.net Core applicaiton follow below mentioned steps
1. Install RabbitMQ.Client using nuget package manager
```powershell
PM> Install-Package RabbitMQ.Client
// By default it will use standard ports. so we no need to provide any connection details
```

1. Create Connection *IConnectionFactory.Connect()*
2. Create Model *IModel.CreateModel()*-- Which creates new channel and New Queue on RabbitMQ
3. Now Queue is ready to use



##### Another way to connect RabbitMQ with asp.net core
1. Create 2 projects. One for producer and another for consumer
2. Create a Model project. which is common for Producer and consumer
3. Install MassTransit nuget package in prod and consumer projects
4. Configure Asp.net serviceconfiguration to make producer project as a Producer
   Check the course notes
5. Configure Asp.net serviceconfiguration to make consumer project as a consumer
      Check the course notes
      1. AddConsumer
      2. add recive endpoint


// Which creates new channel and New Queue on RabbitMQ;
// To create a new queue you have create a model

[//]: # (Tags: Connect Asp.net core with RabbitMQ, What is RabbitMQ, Run RabbitMQ with docker)
[//]: # (Type: RabbitMQ - Asp.net)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Inprogress)
