
#### SAS - Shared Access Signature
- A Shared Access Signature (SAS) is a URI that grants restricted access rights to Azure Storage resources.
- It is essentially a token that provides time-limited access to a resource or a set of resources within an Azure Storage account.
- The SAS is appended to the URI and contains a special set of query parameters that indicate how the resources may be accessed by the client

Sample URI:
https://myaccount.blob.core.windows.net/mycontainer/myblob.txt?st=2018-03-28T00%3A00%3A00Z&se=2018-03-29T00%3A00%3A00Z&sp=r&sv=2017-11-09&sr=b

#### Types Of Shared Access Signatures (SAS)
1. Account SAS - is secured with the storage account key. An account SAS delegates access to resources in one or more of the storage services.
2. Service SAS -  is secured with the storage account key. A service SAS delegates access to a resource in only one of the Azure Storage services: Blob storage, Queue storage, Table storage, or Azure Files.
3. User Delegation SAS  - is secured with Azure AD credentials and also by the permissions specified for the SAS. This applies Blob storage only.


The blob service is the only one that supports user delegation shared access signatures.
The file,table, queue supports account and service shared access signatures 
