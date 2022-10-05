1. Load balancer
2. VPN
3. Virtual Network (VNet)
4. Application Gateway
5. Express Route
6. Content delivery Network (CDN)

###### Application Gateway
It is like Loadbalancer, but more than that.
In application gateway we can able to configure the routing based on multiple parameters .. ex Http headers, Url part, Data in the request etc.,
We can encrypt Appgateway -> VM or applicaiton
up to 100 websites to the same instance of an Application Gateway

##### Virtual Network (VNet)
it uses CIDR notation to create a IP range
Address Space - Range of address.
Adderass space will be assigned to VNet and individual services within VNet will get their own address automatically.
All the services on VNet should be on Same REGION physically.
VNet belongs to single subscription. But subscription can have multiple VNets
Vnets are easily scallable and High Available.

###### VNet Pearing
Help to connect multiple VNets within Azure


###### Subnet
Split the VNet as multiple subnets by splitting he IP ranges. So each subnet we can cotroll .
We can assign Security Groups to individual subnet.
Group resources to same subnet


###### VPN
VPN network is encrypted.
Mostly used in Hybrid env to connect On-Promise and Cloud.
VNET gateway is a specific Subnet. If VNET gateway uses Secure tunnel then it is called VPN gateway

###### CDN
Contents can be cached in Edge nodes (servers which are close to the user). Cache can have expiry time

###### Express Route
 It is a private connections between Azure datacentres and on premises.
 It Don't route through the public internet.More reliable, Faster,High Bandwidth ,lower latency
