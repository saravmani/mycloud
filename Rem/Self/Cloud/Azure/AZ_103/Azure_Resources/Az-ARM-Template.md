##### Contains
- parameters
- Variables
- Outputs


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
  "outputs": {  } // I Assume that what we things needs to be return in output window
}
```

> ***$Note:$ We should take care of order of the resource creation. Some times resources may be depends on another resource***

>***Refer-*** [Sample ARM template form the cloud guru ConfigureServices](
https://github.com/BrentenDovey-ACG/AZ-104_Azure_Administrator/edit/master/S02_Basic_Prerequisites_of_Azure_Administration/L04_Using_ARM_Templates/azuredeploy.json)
