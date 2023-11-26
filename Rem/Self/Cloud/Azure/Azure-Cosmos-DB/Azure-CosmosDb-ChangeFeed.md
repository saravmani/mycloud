 Change feed support in Azure Cosmos DB works by listening to an Azure Cosmos DB container for any changes.
 It then outputs the sorted list of documents that were changed in the order in which they were modified

 ##### The monitored container
 The monitored container has the data from which the change feed is generated. Any inserts and updates to the monitored container are reflected in the change feed of the container.

 ##### The lease container
 The lease container acts as a state storage and coordinates processing the change feed across multiple workers. The lease container can be stored in the same account as the monitored container or in a separate account.

 ##### The compute instance
 A compute instance hosts the change feed processor to listen for changes. Depending on the platform, it could be represented by a VM, a kubernetes pod, an Azure App Service instance, an actual physical machine

 ##### The delegate
 It is the code that defines what the developer want to do with each batch of changes that the change feed processor reads
