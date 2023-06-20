##### Azure Policy
![](../../../../RefImagesPrivate/AzurePolicy.jpg)

1. Helps to Enforce complaince to achieve organisational standards
2. Ex - Control Max Memory limit, cost etc, restrict service access (ex. Limit Azure congnitive service to certain MG )
3. We can able to do bulk remediation and automatic remediation for the resources


Components of policy
1. **Policy defenation** - Evaluation criteria for complaince and Action to be performed if the policy not then Audit or Deny the action
2. **Policy assignment** - Assign the policy to specific sope (Management Group, Subscription level, Resource group, Resource level)
3. **Initiative defenation** - collection of policies to achieve singular goal

```
Ex:
Initiative Defenation - Meet Production environment standards
  Policy1 - Max Ram Size 2GB for VMs
  Policy2 - VMs Should be in North location
```

> ***Note: If we enable POLICY ENFORCEMENT (it is a control in UI) then resource creation will be denied if policy is violated. If POLICY ENFORCEMENT is disabled then it will allow to create the resource but in Complaince assesment result will be available***


![](../../../../RefImagesPrivate/Azure-Policy.jpg)
