

1. Management Groups -> Subscriptions-> Resource Groups -> Resources

2. Region -> Availablity Zone - > Data center

> NOt all regions supports Availability Zones

###  Management Groups -> Subscriptions-> Resource Groups -> Resources

###### Management Groups
Will not cover payment options

#### Subscriptions
***Subscripts are billing entities***
Single Tenant can have multiple subscription groups.
A subscription is an agreement with Microsoft to use one or more services. Charges accrued.
Ex: For one applicaiton we can have one subscription, so that pricing will be calculated for that app


An Azure Resource Manager template is the framework by which resources are created. They can be used to define and automate the creation of similar resources.


#### Resource Groups
Resource Groups are mandatory. A resouce can be part of single resource group at a given time.
Resource from one RG can interact with resource in another RG. RG has location bcs RG meta data should be stored in a particular location's data center
we can move resource from one group to another. REsource group can contain resources from different regions.



### Region -> Availablity Zone - > Data center
> Minimum 3 zone per region
> Zone can have one or more data centers

###### Region
One or more datacenters which somewhat closer in that region and connected with fiber cables.
Pricing may differe region to region. some features may not available in one region.
Ex: Central US, West Europe, East Asia
- Currently there are 55 regions available 

##### Region pair
Regions paired with another region.
Uses - > Failover, At a time one region may goes to maintanence, data recovery

###### Availablity Zone
  Groups of datacenters within a region, have their own isolated power, cooling, and networking.
Minimum 3 Zone per Region

>***Availability Zone is different from Zone. Zone is a geographical grouping of Azure Regions for billing purpose. Data transfer pricing is based on the Zones***
