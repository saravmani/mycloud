
###### Storage
Blob storage - we have to create it separately
Table storage - it is key value pair
File storage
Desk Storage
Archive Storage - Very low cost

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
Ex: https://domainname.<StorageType>.co.in
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


##### Blob Storage Costing
* **Hot tier** - An online tier optimized for storing data that is accessed or modified frequently. The Hot tier has the highest storage costs, but the lowest access costs.
* **Cool tier** - An online tier optimized for storing data that is infrequently accessed or modified. Data in the Cool tier should be stored for a minimum of 30 days. The Cool tier has lower storage costs and higher access costs compared to the Hot tier.
* **Archive tier** - An offline tier optimized for storing data that is rarely accessed, and that has flexible latency requirements, on the order of hours. Data in the Archive tier should be stored for a minimum of 180 days.
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
