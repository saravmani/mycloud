###### ARM - Azure resource Manager
- This is deployment and management service for Azure
 - It is known as Infrastructure as code to manage your Azure resources.
 - Manage your Azure using a simple configuration language. Deploy your resources in parallel to speed up your deployment process. Create and update any Azure resource declaratively.
 - Use one of many sample templates or build one from scratch using native tooling in Visual Studio or Visual Studio Code.


- ARM will be used to Create|Delete|Manage the resources.
- All the interactions to the resources will go through ARM


> Each resource can be part of Single Resource Group at a given time


We can delete resource group any time.
###### We cannot Delete Resource group in below scenarios
* If any resource locked within a resource group
* If any resource used by another resource in another resource group. (Ex: virtual network in another resource group used by a virtual machine in anohter group)
