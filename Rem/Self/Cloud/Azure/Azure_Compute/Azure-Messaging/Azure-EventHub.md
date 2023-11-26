#### Azure Event Hub
> ***It is like Kafka (But both are different :-. Event hub also provides similar protocols of Kafka))***

- It is event streaming
- Uses Http, Https, AMQP
- Easier to interact with third parties and apps
- Data stored in to partitions
- It can be configured to retain data from 1 to 7 days
  - if more thn 7 days required then we can store it in Azure blob storage and Azure data lake (Gen1/2). We can store them in periodically based on siz or interval
- Cost calculated with throughput units

#### Throughput Units (TUs)
In Azure Event Hubs, the throughput capacity is controlled by Throughput Units (TUs). These are pre-purchased units of capacity.

- A single throughput unit allows you to:
  - Ingress: Up to 1 MB per second or 1000 events per second (whichever comes first).
  - Egress: Up to 2 MB per second or 4096 events per second1
- Beyond the capacity of the purchased throughput units, ingress is throttled and a ServerBusyException is returned.
- Egress does not produce throttling exceptions, but is still limited to the capacity of the purchased throughput units



We can generate SAS key  to connect with below policies
1. Manage
2. Send
3. Listen
