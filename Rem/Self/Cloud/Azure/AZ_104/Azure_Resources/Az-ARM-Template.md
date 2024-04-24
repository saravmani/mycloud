##### ARM Templates
Azure Resource Manager Templates
It is IaC - Infrastructure as a Code


in AZ portal search for "Deploy a custom template"


###### ARM structure
```json
{
  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
  "contentVersion": "",
  "apiProfile": "",
  "parameters": {  },
  "variables": {  },
  "functions": [  ],
  "resources": [  ],
  "outputs": {  } // return values from the deployed resources
}
```

##### functions
* Used to manipulate values during deployment
* ARM provides range of functions ex: date functions, logic functions , array functions



##### outputs Tag
Helps us return values from the deployed resources.
Ex: Deployment status, Resource Properties, resource ID
```json
"outputs": {
    "hostname": {
        "type": "string",
        "value": "[reference(resourceId('Microsoft.Network/publicIPAddresses', variables('publicIPAddressName'))).dnsSettings.fqdn]"
    }
}

```





> ***$Note:$ Order of the resources are important. Some times resources may be depends on another resource***

>***Refer-*** [Sample ARM template form the cloud guru ConfigureServices](
https://github.com/BrentenDovey-ACG/AZ-104_Azure_Administrator/edit/master/S02_Basic_Prerequisites_of_Azure_Administration/L04_Using_ARM_Templates/azuredeploy.json)
