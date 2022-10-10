
## Pricing
##### VM
Calculated Hourly. More resources (ram, cpu, HD) then more price. GPU also available for VMs

#### On-Premises
Large initial cost. No monthly cost for resource usate because theose are our servers :-)
But we need to pay for utilities


#### On Azure
- pay only what we use.
- Hourly based
- More pay for high resources (Ex: More CPU)
- Payments are tiered (SSD is costly when compare to Archieve store)
- Based on location
- Bandwidth size also decides the price

---

## Billing
- Billing cycle 30 days or 60 days
- Subscription is the base for billing
- Billing Admin is the role, can manage the billing

- Group subscriptinons helpful for Large organisation. Using this we can perform bulk operations accross subscriptions
- We can have management group based on any criteria - Ex: Country level, Department
level etc.,
- Hierarchy also possible in management group. With parent child relation

### Zone base billing for data transfer
>***Availability Zone is different from Zone. Zone is a geographical grouping of Azure Regions for billing purpose. Data transfer pricing is based on the Zones***
- Data transfer withing billing zone  is free. but outside zone is cost.
- Ingress - Data transfer within Zone
- Outgress - Data transfer within Zone



#### Azure Cost Management portal
- End-to-End multi-cloud cost monitoring, usage monitoring, and cost forecasting
- Includes Azure service and third-party Azure Marketplace usage, and purchases including reservations
- we can  view AWS cost also from here

#### Pricing Calculator
- Tool in azure portal help to calculate the expected cost.
- Also we can estimate monthly cost
- We can add the resources, regionn OS etc to calculator then it will show the amount

#### Total cost of ownership Calculator
This will provide you the cost btn Azure Vs On-Premise cost saving details

#### Spending Limit
 - The spending limit is equal to the amount of credit. You can't change the amount of the spending limit. For example, if you signed up for Azure free account, your spending limit is $200.
 - Like this we can set the limit
 - Over spending limit we can't use the resource
 - **PayAsGo doesn't have spending limit functionality**


 #### Quotas
- Quotas define the limits of resources that a user subscription can provision or consume.
- Each resource can have its own types of quotas
- For example, a quota might allow a user to create up to five virtual machines (VMs).
- For Event hub 100 namespaces allowed persubscription


#### Reserved capacity
We can reserve the capacity for a particular period of time to get the bettor offer

#### Reserved instances
We can reserve the instances for a particular period of time to get the bettor offer


#### Azure hybrid benefit
If we have own licence we can use it on azure to save cost
