1. Load balancer
2. VPN
3. Virtual Network (VNet)
4. Application Gateway
5. Express Route
6. Content delivery Network (CDN)

###### Application Gateway
- web traffic load balancer
- It is like Loadbalancer, but more than that.
- high-level layer 7 in the OSI model
- In application gateway we can able to configure the routing based on multiple parameters .. ex Http headers, Url part, Data in the request etc.,
- We can encrypt Appgateway -> VM or applicaiton
- up to 100 websites to the same instance of an Application Gateway.


Trafic Manager - Provides Loadbalancing, Routing






##### Virtual Network (VNet)
it uses CIDR notation to create a IP range
Address Space - Range of address.
Adderass space will be assigned to VNet and individual services within VNet will get their own address automatically.
All the services on VNet should be on Same REGION physically.
VNet belongs to single subscription. But subscription can have multiple VNets
Vnets are easily scallable and High Available.

###### VNet Pearing
- Help to connect multiple VNets within Azure
- No Down time
- Can be used to transfer data btn Azure AD Tenants
- Tthis creates Low latency , High bandwidth connection


###### Subnet
Split the VNet as multiple subnets by splitting he IP ranges. So each subnet we can cotroll .
- We can assign Security Groups to individual subnet.
- Group resources to same subnet
- All the services , Subnets on Single VN can automatically connect each other. If u dont need connection to particular service then create separate VN fot that


###### VPN
VPN network is encrypted.
Mostly used in Hybrid env to connect On-Promise and Cloud.
VNET gateway is a specific Subnet. If VNET gateway uses Secure tunnel then it is called VPN gateway

###### CDN
Contents can be cached in Edge nodes (servers which are close to the user). Cache can have expiry time

###### Express Route
 It is a private connections between Azure datacentres and on premises.
 It Don't route through the public internet.More reliable, Faster,High Bandwidth ,lower latency


 ##### Azure traffi manager
- It will not filter any traffic
- It can distribute the traffic accross global Azure regions
- It can distribute the traffic accross global Azure regions


##### NSG
- Specialized packet-filtering filrewalls that le you define security rules to controll traffice ina nd out of vnet, subnet, VM level.
- An NSG works much like a firewall. While an Azure Firewall monitors traffic at more of a global level, an NSG is more defined and is applied to specific subnets and/or network interfaces.
- Both firewall and NSG allow you to apply rules based on IP addresses, port numbers, networks, and subnets.


##### ASG
ASGs are used to protect groups of servers with a common function, such as web servers or database servers.
ASGs are used within a NSG to apply a network security rule to a specific workload or group of VMs - defined by ASG
