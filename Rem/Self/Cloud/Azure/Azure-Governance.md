### Governance
mechanisms and processes to maintain control over your applications and resources in Azure

This contains - Azure policy, Rolebased Access control (RBAC), Resource locks and blueprints.

---

### Key Elements
#### Policy
organization level to achieve its goal
Set of Rules and agreements. Ex. We can set the budget limit for the resources

#### Role-based access control
Ensure only the correct set of users can access the resources. It is like our current applications role management. we can create the roles with granular level permisssions and assign to resource groups, or users

#### Locks
* Delete Lock - which will not allow us to delet the resource. but we can use and modify
* Read-only lock - we cannot perform any modification
* Lock can be applied Resource, Resource group , subscription level



#### Azure Blue prints
Templates for creating standard Azure environment.
Azure Blue prints consists set of resource groups, policies, role assignments, and ARM template deployments.
ARM template is a document that doesn't exist natively in Azure - each is stored either locally or in source control. But blue print exists in azure and linked to the deployment and monitor it



#### Cloud Adoption framework
Provides Tools guidance, best practices, documents for cloud adoption.
Also it provides the same for Business, people and process change

#### Azure advisor for security assistance
It is par of Azure security center

---


#### Features
1. Do inventory management - visibility into all your resources fast
2. Analyse costs and monitor usage from a single dashboard
3. Apply policies -   Set of Rules and agreements
4. Apply policies with flexible hierarchies to multiple subscriptions.
5. Easily create fully compliant environments and apply group policies to new Azure subscriptions.
