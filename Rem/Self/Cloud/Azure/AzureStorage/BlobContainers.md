
#### What is blob container?
- Blob containers are used to store blobs, which are unstructured object data
- A container organizes a set of blobs, similar to a directory in a file system
- A storage account can include an unlimited number of containers, and a container can store an unlimited number of blobs
- All blobs stored in a container share the same level of sharing, either private or public³.
- Blob Storage is optimized for storing massive amounts of unstructured data
- Users or client applications can access objects in Blob Storage via HTTP/HTTPS, from anywhere in the world
- We can store complete website in blob storage

#### Types of blobs
- **Block Blobs**: Ideal for storing text or binary files and uploading large files efficiently (Max size 4 TB)
- **Append Blobs**: Optimized for append operations, making them ideal for logging scenarios (Max size 4 TB) - logging data from virtual machines
- **Page Blobs**: Used for random read/write operations and are ideal for storing virtual hard drive files (Max size 8 TB). AZ SQL, VMs uses page blobs as underlying storage

> Sample Url for blob https://myaccount.blob.core.windows.net/mycontainer/myblob

#### Azure Blob Container
- It organizes a set of blobs, similar to a directory in a file system.
- A storage account can include an unlimited number of containers, and a container can store an unlimited number of blobs.


#### Page Blobs vs Az File Storage
Azure File Storage is similar to normal file storage on a computer. Here, we can create directories, copy, delete, etc. It also supports the SMB protocol and provides an interface that we can access from anywhere. For example, in your organization, if you want to share files among your employees, you can use it.

On the other hand, with Page Blobs, we have to write code to access them. They are commonly used as virtual hard disks for Virtual Machines.

> ***Once a blob is created, its type cannot be changed***

##### Blob Lifecycle Management
This offers a rule-based policy that you can use to transition blob data to the appropriate access tiers  (Hot to Cool, Hot to Archive, or Cool to Archive) or delete blobs altogether

A lifecycle management policy is composed of one or more rules that define a set of actions to take based on a condition being met. For a base blob, you can choose to check one of the following conditions
- The number of days since the blob was created
- The number of days since the blob was last modified
- The number of days since the blob was last accessed

Ex : - If you have defined an action to move a blob from the hot tier to the cool tier if it has not been modified for 30 days, then the lifecycle management policy will move the blob 30 days after the last write operation to that blob

**Rule Example**
The filter can be set to match a prefix. This is useful if you want the rule to apply only to blobs whose names begin with certain characters. For example, if you have blobs named "ContainerName/summer/img1”, "ContainerName/winter/img2”  you could create a rule with a filter set to “ContainerName/summer/”
**Rule will always starts with container name**


---



##### AzCopy Command
AzCopy is a command-line utility that you can use to copy files to or from a storage account
```dos
azcopy make 'https://<storage-account-name>.file.core.windows.net/<file-share-name><SAS-token>'
```
