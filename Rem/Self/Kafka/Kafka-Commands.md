
```powershell
# To create new consumer group
> kafka-console-consumer --topic myactual-toppics --bootstrap-server localhost:9092 --group kafkasharp-subscriber

>  kafka-consumer-groups --list --bootstrap-server localhost:9092

kafka-console-consumer --topic myactual-toppics  --bootstrap-server localhost:9092 --group myroupidd

kafka-console-consumer -bootstrap-server localhost:9092 -topic -group myroupidd

# To List topics
> kafka-topics --list --bootstrap-server localhost:9092
```

###### To Produce Messages
```powershell
kafka-console-producer --broker-list localhost:9092 --topic  myactual-toppics
```
