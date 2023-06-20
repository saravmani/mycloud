7 Layers of security
1. Physical
2. Identity and Access - Using Active Directory
3. Perimeter - To avoid DDOS attacks, protocol attack etc.,
4. Network
5. Compute - protects to access VMs
6. Firewall and gateways
7. Data - encryption

### Network security
1. Firewall
2. DDOS Protection service - Azure will detect this type of attack and stop it. This contains multiple levels
3. Network Security Group (NSG) - this is a set of rules and can be attached to Virtual network for a VM. I tcan filter the n/w traffic to and from resources. **NSG can only be associated to a subnet or virtual machine instance, not a whole network.**
4. Application Security Group - We can able to define n/w security, component security based on application .. not IP levels

Azure services by default publically accessible.
To add security for that we have two options
1. Service endpoints -  Allow traffic from service-endpoint enabled subnet
2. Private endpoints


### Service endpoint
Service endpoint having some limitations
we cannot create secure channel to on-promisses.If needed we need to explicitly mention the IP to be allowded.
Service endpoint provide access to entire service

### Private endpoints
Provides VPN to on promise or hybrid environments
private connectivity to single service instance / single storage account, single sql instance


### Azure security center
- It is a portal. provides set of tools for monitoring and managing the security of  cloud resources within the Microsoft Azure public cloud.
- Shows threat alerts.
- It can watch hybrid resources also
- Each VM installed the agent and sends the data to Security center
- Policy and complaince metrics widget,
- security score widget
- Able to integrate with othere security providers.
- We can integrate Azure Sentinal
- This only raises the alerts but we have to act on that
- Resource security hygine  - check the security standards and best practices for
- Regulatory complaince dashboard - it will look for standards, policies for compliances

#### Security Policy in Security Center
- We can configure our own security policy/ rules. Azure also provides predefined policies


### Sentinal -  SIEM (Security Information and Event Management)
- Microsoft Sentinel is your birds-eye view across the enterprise. widly used tool.
- AI based - Behavioural analytics
It will collect data from all the resources and analyse the data and if it found any threat/ attacks then will notify to us. and we have to take action.
- We can integrate this with Azure Security Center so that we can view the alert in one place
- AWS integration available







### Azure Key Vault
We can save passwords and other secrets in Key Vault. And provide the access to applications.
Applications will identify in azure key valut and azure key vault provide the acess to the resource

### Azure information protection
help to secure the docuemnts, securly share the documents to others. Also we can classify the sensitive data.
Ex: Email attachment can be secured and sent. The user have to authenticate themself before opening it

We can abel to define the policies


#### Microsoft defender for identify
Monitor user activity, permissions and memberships and logs if it found any suspicious.
Also it provides suggestion to security practices

##### Cyper attack kill chain
It is a intelligence framework identification and prevention of cyber intrusions activity
Microsoft defender will identify
1. Brute force attempt
2. Reconnaissance - If one user search other user information, ip etc.,
3. Elivate/ increasing privileges - if user tries to attempt to elivate his privileges




#### Dedicated host
- It is like VM. But we can own the Hardware.
- It is like we are renting the Physical hardware to run our VM, so that we will have more controll over there.
- But still Cloud benefits can be used
- It is costly

**Usecases:**
1. we can schedule our own maintanence hours
2. we can sensure the CPU/RAM availability
