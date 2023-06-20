###### ARM - Azure resource Manager
>*Azure Resource manager will not directly will interact with resources. But resources will have **resource provider** and ARM will interact with Resource Provider and Resource provider will perfrom the action on the resource*
>*ARM itself a Resource. We consider it as a top level resource*
- This is deployment and management service for Azure
 - It is known as Infrastructure as code to manage your Azure resources.
 - Manage your Azure using a simple configuration language. Deploy your resources in parallel to speed up your deployment process. Create and update any Azure resource declaratively.
- ARM will be used to Create|Delete|Manage the resources.



> Each resource can be part of Single Resource Group at a given time


We can delete resource group any time.
###### We cannot Delete Resource group in below scenarios
* If any resource locked within a resource group
* If any resource used by another resource in another resource group. (Ex: virtual network in another resource group used by a virtual machine in anohter group)


## Resource Locks

* It helps to override permissions for the resources
* **This will applied to all users and Roles**
* We can lock Subscriptins, RG and Resources

> ***If we apply the locks at parent level then child resources will inherit the lock from the parent.Note - This is the exact opposite of how Tags work, as Tags are not inherited by child resources.***


###### Resource lock types
1. Readonly
2. CanNotDelete



## Moving Resource
* We can move resources from RG to RG or One Subscription to an another subscription
