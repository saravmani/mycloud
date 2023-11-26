### Role Based Access Control
1. It is Authrozation Mechanism
2. This helps to manage who has access to Azure resources, what they can do with those resources, and what areas they have access to

>  ***A role assignment consists of three elements:***
*** Security principal, Role definition, and Scope***


#### Security principal
1. It is an object that represents a user, group, service principal, Managed identity
2. You can assign a role to any of these security principals

***Service Principal Object*** - This  represents an application in Az-AD. This created when an application is registered in Azure AD. Service principal objects are also used to authenticate to Azure resources. For example, an Azure VM can use a service principal object to authenticate to Azure Storage to access its data.

***Managed Identity***
Can be used to authenticate to Azure services.
They are tied to the lifecycle of the Azure resource that they are assigned to. When the Azure resource is deleted, the managed identity is also deleted.
Automatically authenticated. But Service principal require secret

#### Role definition
It is a collection of permissions.
It's typically just called a role.
A role definition lists the actions that can be performed, such as read, write, and delete.
Azure includes several built-in roles. For example, the **Virtual Machine Contributor** role allows a user to create and manage virtual machines. If the built-in roles don't meet the specific needs, you can create your own roles
```json
{
  "roleName": "MyCustomRole",
  "description": "Some Description",
  "type": "CustomRole",
  "roleDefinitionId": "/subscriptions/{SUBSCRIPTION_ID}/providers/Microsoft.Authorization/roleDefinitions/{ROLE_DEFINITION_ID}",
  "permissions": [
    {
      "actions": [
        "Microsoft.Compute/virtualMachines/write",
        "Microsoft.Compute/virtualMachines/read",
        "Microsoft.Compute/virtualMachines/delete"
      ],
      "notActions": [],
      "dataActions": [],
      "notDataActions": []
    }
  ]
}

```


#### Scope
A scope is a set of resources that a role assignment applies to. When you assign a role to a user, group, or service principal, you must also specify the scope of the role assignment.
You can also use scopes to restrict the permissions that a user has on a resource

you can specify a scope at four levels: management group, subscription, resource group, or resource. Scopes are structured in a parent-child relationship.



#### ACL - Access Control List
- List of rules that specifies which users or systems are granted access to a particular object or system resource. ACLs are typically used to control access to files, directories, and network resources.

 - Each ACL entry associates a ***Security Principal*** with an access level. A security principal can be a user, group, service principal, or managed identity that is defined in Azure Active Directory.
