### Azure Functions Development

##### References
1. [Complete Reference](https://learn.microsoft.com/en-us/training/paths/implement-azure-functions/)

2. [How to Develop Azure Functions](https://learn.microsoft.com/en-us/training/modules/develop-azure-functions/5-create-function-visual-studio-code)

- Every function has  only one trigger
- Triggers have associated data, which is a payload for the function
- function.json file used for config
  - This Contains  trigger, bindings, and other configuration settings

---
<details>
<summary>Sample function.json file</summary>

>*Write a new row to Azure Table storage whenever a new message appears in Azure Queue storage. This can be implemented using an Azure Queue storage trigger and an Azure Table storage output binding*

 [Refer](https://learn.microsoft.com/en-us/training/modules/develop-azure-functions/3-create-triggers-bindings)


```json

{
  "bindings": [
    {
      "type": "queueTrigger",
      "direction": "in",
      "name": "order", //  function parameter that receives the queue message content
      "queueName": "myqueue-items",
      "connection": "MY_STORAGE_ACCT_APP_SETTING"
    },
    {
      "type": "table",
      "direction": "out",
      "name": "$return",
      "tableName": "outTable",
      "connection": "MY_TABLE_STORAGE_ACCT_APP_SETTING"
    }
  ]
}

```
###### C# script example
```csharp
// From an incoming queue message that is a JSON object, add fields and write to Table storage
// The method return value creates a new row in Table Storage
public static Person Run(JObject order)
{
  return new Person()
    {
        PartitionKey = "Orders",
        RowKey = Guid.NewGuid().ToString(),
        Name = order["Name"].ToString(),
        MobileNumber = order["MobileNumber"].ToString()
      };
}
```
</details>

---

#### Function app
 - A function app is composed of one or more individual functions that are managed, deployed, and scaled together.
 - All of the functions in a function app share the same pricing plan, deployment method, and runtime version.


 The code for all the functions in a specific function app is located in a root project folder
**host.json** file contains runtime-specific configurations and is in the root folder of the function app

Your local functions can connect to live Azure services, and you can debug them on your local computer using the full Functions runtime



Triggers and bindings are defined differently depending on the development language.
For - C#  class library	decorating methods and parameters with C# attributes
For C# Script we have configure it in funciton.json
For otherthan C# and Java - we have to use funciton.json


>*Unlike the queue trigger, the timer trigger doesn't retry after a function fails. When a function fails, it isn't called again until the next time on the schedule.*

#### Function Folder structure
MyFunctionApp/
├── host.json //contains runtime specific config
├── MyFunction_1/
│   ├── function.json
│   ├── index.js
│   └── node_modules/
├── MyFunction_2/
│   ├── function.json
│   └── ...
└── shared/
    ├── mySharedModule.js
    └── node_modules/
