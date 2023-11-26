

## Azure Cosmos DB APIs

1. **NoSQL API**
   - Stores data in document format.
2. **MongoDB API**
   - Best suited for existing MongoDB applications.
3. **PostgreSQL API**
   - Ideal for existing PostgreSQL applications.
4. **Cassandra API**
   - Good choice for existing Cassandra applications.
5. **Gremlin API**
   - Suitable for graph data modeling and querying.
6. **Table API**
   - Used for key-value data modeling and querying.


> *It Supports an API for SQL and this stores data in document format.This will be helpful to migrate the applications from SQL platform. Note there are minor changes in sql queries*


Cosmos DB supports stored procedures written in JavaScript that can perform various operations on the data in a collection. However, you should not use stored procedures for queries, as they only run on the primary partition and have limited throughput



 #### Capacity Modes
 Azure Cosmos DB offers two capacity modes: **Provisioned Throughput** and **Serverless**. Provisioned Throughput is for predictable, sustained workloads, while Serverless is for intermittent or unpredictable traffic.

 1. **Provisioned throughput**
- Provisioned Throughput in Azure Cosmos DB is a mode where you allocate a specific amount of Request Units (RUs) per second.
- This capacity is available every second for your database operations, providing predictable performance.
- Request Units (RUs) in Azure Cosmos DB are a performance currency that abstract the system resources, such as CPU, IOPS, and memory, required to perform database operations. The cost of all database operations is normalized and expressed in terms of RUs

2. **Serverless**
- Serverless mode in Azure Cosmos DB is a capacity mode designed for workloads with intermittent or unpredictable traffic.
- Pay-As-You-Go Model.
- You can run your database operations without having to configure any previously provisioned capacity.
- Billing is based on the number of Request Units (RUs) consumed by your database operations, calculated on a per-hour basis.

Note -  By default, Azure stores four copies of your data in the source region if you do not opt for any replication


## Consistancy models
- Azure Cosmos DB offers five well-defined consistency levels: Strong, Bounded staleness, Session, Consistent prefix, and Eventual.
- The default is Session

**Strong Consistency**
- Writes made to all regions
- The reads are guaranteed to return the most recent committed version of an item.
- The data is synchronously replicated to all the replicas in real-time.
- This mode of consistency is useful for applications that cannot tolerate any data loss in case of downtime


**Bounded Staleness Consistency**
- There is be small delay in additional region.
- But data is readily available in same region

**Session Consistency**
- It provides strong consistency for the session, ensuring the data stays up to date for any active read-write session. Within a single client session, reads are guaranteed.
- Session consistency is ideal for scenarios where a single user's session needs to be scoped to a single region.

**Consistent Prefix Consistency**
- This guarantees that reads never see out-of-order writes.
- The writes will be in order. But reads are not always current record
- ensures that updates made as a batch within a transaction
- Write operations within a transaction of multiple documents are always visible together


**Eventual Consistency**
- data may be inconsistent
- There's no ordering guarantee for reads
