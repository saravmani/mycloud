#### RabbitMQ
###### RabbitMQ - Lightweight, Open source message broker.
>

Basically it is a message queue system and it uses FIFO algorithm (i.e first in first out).
It is Lightweight, Open source message broker and It can be deployed in distributed and federated configurations to meet high-scale.
We know Queue system will use FIFO algorithm (i.e first in first out)).

###### Protocols used in RabbitMQ
RabbitMQ supports multiple messaging Protocols directly or through pluggins
* AMQP - Advanced Message Queuing Protocol
* STOMP - Text based Lightweight Protocol
* MQTT - Lightweight binary Protocol

RabbitMQ supports **HTTP and WebSockets** also through some pluggins. But those are really not messaging Protocol

```
Other few message queue systems similar to RabbitMQ
- Appachi Kafka
- Azure Service Bus
- MSMQ
```

###### Diagram to understand about RabbitMQ
```mermaid
graph LR
A(Publisher) --> B(Exchange)  --> C(Message Queue) --> D(Subscriber)
subgraph RabbitMQ
           B
           C
          end
```
Queue    -  This stores the messages and pass it to Subscriber using FIFO algorithm
Exchange -  Based on routing cases it decides to which Queue it needs to send/broadcast the messages

---


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


// Which creates new channel and New Queue on RabbitMQ;
// To create a new queue you have create a model

[//]: # (Tags: Connect Asp.net core with RabbitMQ, What is RabbitMQ, Run RabbitMQ with docker)
[//]: # (Type: RabbitMQ - Asp.net)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Publish)
