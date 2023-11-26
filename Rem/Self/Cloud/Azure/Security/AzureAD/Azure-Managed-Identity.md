#### Managed Identity
- This eliminates the need for developers to manage these credentials
- Lifecycle tied with the resource
- Identity name is same as resource name
  - Ex: If is for VM then the VM name is same as identity name
- No credentials in code

> ***Internally, managed identities are service principals of a special type, which are locked to only be used with Azure resources. When the managed identity is deleted, the corresponding service principal is automatically removed***

#### Types of Managed Identity

- **System-assigned**
  - identities are created and deleted automatically with the Azure resource that uses them.
  - They are tied to the lifecycle of that resource and can only be used by that resource.
  - Ex:virtual machine can have a system-assigned identity that is deleted when the virtual machine is deleted
- **User-assigned**
  - identities are standalone Azure resources that can be created and deleted independently of the resources that use them.
  - They can be assigned to one or more Azure resources and can be reused across different resources
  - This is manually created by us

---

> In below example applicaiton will connect to Azure AD using endpoint hosted in VM and get the token

![](../../../../RefImagesPrivate/Azure/ManagedIdentityFlow.jpg)

[Refer For More](https://learn.microsoft.com/en-us/training/modules/implement-managed-identities/3-managed-identities-auzre-virtual-machines)

> **Your code that's running on the virtual machine can request a token from the Azure Instance Metadata service endpoint, accessible only from within the virtual machine: http://169.254.169.254/metadata/identity/oauth2/token**
---

##### Create Managed identity
>*Most of the services you can find the Identity Menu at left*

![](../../../../RefImagesPrivate/Azure/ManagedIdentity_Create.jpg)




#### Azure managed identities can be used to authenticate to a variety of Azure services, including:

Azure Key Vault
Azure Storage
Azure SQL Database
Azure Cosmos DB
Azure App Service
Azure Functions
