### Azure storage account
AZ storage account contains different types of storages
 - Blobs, files, queues and Tables.
 - Azure Storage is automatically encrypted using Storage Service Encryption (SSE).





#### Storage account name
Storage Account name must contain only lowercase and numbers. length 3 - 24.
It should universally unique

#### Types of Storage accounts
- **Standard Storage** *(Uses Hard Disk (HDD))*
    - General-purpose-v2 - Recomended type which covers more scenarios. This is type for all storage types ( Blobs, files, queues and Tables)
    - General-purpose-v1 - This is like V2. But used for legacy services. For new applicaitons dont choose this.
- **Premium Storage** *(Uses SSD)*
    - low-latency performance    
     - BlockBlobs - Optimized for Block and Append blobs for larger amount. Not usable with other storage type. Not frequently used data we can store
     - FileStorage account - Supports only File Store. This can be acced by SMB (Server Message Block) protocol
     - Page Blobs - Used for random read/write operations and are ideal for storing virtual hard drive files (Max size 8 TB). AZ SQL, VMs uses page blobs as underlying storage

![](../../../RefImagesPrivate/Azure/Azure-Storage-AccountTypes.jpg)

---
#### Where to select Block Blobs, Append Blobs, Page Blobs

![](../../../RefImagesPrivate/Azure/Azure_BlobTypes.jpg)

---
##### Storage Tiers (Costing)
**Azure Storage Premium tier does not support the Cool and Archive tiers**

* **Hot tier** -  Default Tire. Optimized for storing data that is accessed or modified frequently. The Hot tier has the highest storage costs, but the lowest access costs.
* **Cool tier** - Optimized for storing data that is infrequently accessed or modified. Best for Data accessed ONCE in 30 + days. This has Lower storage costs and Higher access costs compared to the Hot tier.
* **Cold tier** - Optimized for storing data that is infrequently accessed and stored for a minimum of 90 days. The cold tier has lower storage costs and higher access costs compared to the cool tier.
* **Archive tier** (180+)
  - An offline tier optimized for storing data that is rarely accessed, and that has flexible latency requirements, on the order of hours. Data in the Archive tier should be stored for a minimum of 180 days. Only available for individual Block blobs. we can use it to store the data for audit or complaince purpose.
  * accessing that data is more expensive than accessing data in the hot or cool tiers.
  * While a blob is in the Archive tier, it can’t be read or modified , you must first rehydrate it to an online tier, either Hot or Cool. It may take several hours based on amount of data stored there

>***you can set the access tier at the individual blob level when you UPLOAD a file. This setting overrides the default access tier for the storage account. But this only applicable for block blobs not for append blob and page blob***
>We can switch btn these tiers anytime.

Only the hot and cool access tiers can be set at the account level.
The archive access tier can only be set at the blob level

---
#### Azure Storage security features
- Azure Storage is automatically encrypted using Storage Service Encryption (SSE).
- You can rely on Microsoft-managed keys for the encryption of your storage account or you can manage encryption with your own keys


<details>
   <summary>Customer-managed key and  customer-provided key</summary>

[Ref: More](https://learn.microsoft.com/en-us/training/modules/explore-azure-blob-storage/4-blob-storage-security)

- You can specify a customer-managed key to use for encrypting and decrypting all data in the storage account. A customer-managed key is used to encrypt all data in all services in your storage account.

- You can specify a customer-provided key on Blob storage operations. A client making a read or write request against Blob storage can include an encryption key on the request for granular control over how blob data is encrypted and decrypted.
  </details>


![](../../../RefImagesPrivate/Azure/AzureStorage_Security.jpg)


---
---
##### Storage Types
Blob storage
Table storage - it is key value pair
Queue
File storage

Desk Storage

>**Data stored in storage account will automatically have 3 Copies (Synchronously). Minimum Replication option is LRS - Locally reduntant Storage. LRS is the default option**


> **In GRS (Geo-redundant-Stroage) Data will have 3 copies (Synchronously) in Primary. Then replicated ASYNCHRONOUSLY to Secondary region**
###### Storage redundancy options
Zone-redundant storage
Geo-redundant storage
Geo-zone-redundant storage
Read-access geo-redundant storage
Read-access geo-zone-redundant storage
Locally redundant storage


>*Storage will have unique address*
Ex: https://myaccount.blob.core.windows.net/mycontainer/myblob
>*A storage account provides a unique namespace in Azure for your data. Every object you store in Azure Storage has an address that includes your unique account name. The combination of the account name and the Azure Storage service endpoint forms the endpoints for your storage account.*

---

###### Blob storage
IT is similar to directories in a file system.
Deal for storing data for backup and restore, disaster recovery, and archiving.
Optimized for storing massive amounts of unstructured data
Store the data in a container. Blog storage account can have multiple containers
Ex: - Archive files, Backup files, Images, Log files,
Blob Storage Types
1. Append Storage - Ex: Log files can be appended. This optimized for append operations
2. Page Storage - 8TB. random read/write operations. It is like page in our hard disk. Serve as disks for Azure virtual machines
3. Block storage - 4TB. For large amounts of data .Store text and binary data. Block blobs are made up of blocks of data that can be managed individually.


---
###### Desk Storage
Azure will manage and alocate the disk.
**Primary use case is this can be used for VMs**
HDD - Low cost. Suitable for less important data ex: backup or log files
SSD- Mostly used in production
Premium SSD - For data intensive work loads
Ultra Desk - Suitable for data intensive work loads. 64TB (Gaming, )

---

###### File storage
- Alternative for on-premises file servers, SMB or NAS devices. Windows, mac, and Linux can directly mount Azure file shares.
- Works with Network File System (NFS), Server Message Block (SMB)
- User can Store their files in cloud instead of own hard disk
Easy accessible. Other cloud high availability options are optible.
- Lift and Shift scinarios - Moving existing onpromise system to cloud


---
#### Azure Data Lake
- It is the Hadoop Distributed File System (HDFS) as a service
- It is a scalable data storage and analytics service
- It can accommodate all types of data from any source, from structured (database tables, Excel sheets) to semi-structured (XML files, webpages) to unstructured (images, audio files, tweets)
- Azure Data Lake Storage Gen2 supports both Azure role-based access control (Azure RBAC) and POSIX-like access control lists (ACLs)
---

#### Network preference for storage account
1. Microsoft network routing
2. Internet routing
- Microsoft network routing - In this option both ingress and egress traffic remain on the Microsoft global network whenever possible, ensuring low-latency and good performance
-  Internet routing - This is a cost-optimized method where traffic minimizes travel on the Microsoft global network and uses the transit ISP network to route your traffic, entering the Microsoft network closest possible to the hosted service region.

---
I
