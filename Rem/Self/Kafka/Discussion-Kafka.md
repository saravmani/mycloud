

Initially Developed by Linked in 2010 and now it is Open source
Developed Java


There is no serialization and Deserialization. It will transmit the data in bite format

/// - Kafka sample code https://stackoverflow.com/questions/66924801/kafka-net-consumer-that-consumes-new-messages-from-a-multi-partitioned-topic-b




##### Components
Brokers - Receives and store and transmitting data
Zoo Keeper - All the brokers connected to Zookeeper. Zookeeper will manage the Broker clusters (Loadbalancing, distributing the messages etc., )


##### Brokers
This will receive and store and transmitting the data. Think that this is a process which will run on particular machine. In production environment we will host multiple brokers to increase throughput.



##### Zoo Keeper
Zoo keeper will listent to particural port. All the brokers should be registered usingu  Zookeeper's port



Install steps
1. Install docker image - Zookeeper
```powershell
  docker pull confluentinc/cp-zookeeper
```
2. Install docker image for Kafka
```powershell
  docker pull confluentinc/cp-kafka
```
3. Create network - docker network create kafka
4. docker run -d --network=kafka --name=zookeeper


Install *Confluent.Kafka* & *kafka-sharp* Nuget packages
``` powershell
# for producer
PM> Install-Package  Confluent.Kafka

# For consumer
PM> Install-Package  kafka-sharp

```
###### Setup
``` powershell
docker network create kafka

docker run -d --network=kafka --name=zookeeper -e ZOOKEEPER_CLIENT_PORT=2181 -e ZOOKEEPER_TICK_TIME=2000 -p 2181:2181 confluentinc/cp-zookeeper

docker run -d --network=kafka --name=kafka -p 9092:9092 -e KAFKA_ZOOKEEPER_CONNECT=zookeeper:2181 -e KAFKA_ADVERTISED_LISTENERS=PLAINTEXT://LOCALHOST:9092 confluentinc/cp-kafka
```
>**conduktor** *Is a utility tool provides interface to work with the Apache Kafka. It is free for personal use. But paied for business*
