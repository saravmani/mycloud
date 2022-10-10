* Azure App Services
* Virtual machines
* Scale sets
* Azure Functions
* Azure Container services
* Azure Kuberneties Services (AKS)
* Azure Virtual Desktop




###### Scale sets (IaaS)
- Allow automatic scaling of virtual machines
- based on metrics which we configure.
- Ensure high availability. Manage VMs. Pay only for added VMs.
- Scale sets are identical VMs. Base VM is required to take a copy

###### App Services
1. Web Apps
2. Web apps for containers (create container in local and deploy in Azure)
3. API Apps

### Azure container service
###### ACI (Azure container instance)
It is serverless concept. Execute container without Orchestration.
Runs docker container on-demand

###### Azure Kuberneties Services
ACR - Azure container registry is manages container images
POD - Pods are simply the smallest unit of execution in Kubernetes. And it is a VM which hosts multiple containers

---
#### Azure Virtual Desktop
Windows 10 license can be reused
Access any where and any device. Uses azure security

#### Spot VM
- Azure spot VMs allow customers to purchase VMs from a pool of unused spare capacity at a significantly lower price—up to 90% less—than pay-as-you-go.
- Comes with discout
- we can use it for non critical Tasks
- we can able to use scale sets
- within 30 sec notification azure can get back the VM


### Serverless
- It is a PaaS
###### Azure Functions
Single function which should do Single function

###### Logic Apps
No coding required. Connect different systems, Services, DataFlows, Apps etc., From Outside or inside Azure.
Schedule, Trigger, Automate, Orchestrate Tasks.
Ex: If any event occus if we want to tirgger some process

###### Event Grid
It is a routing service which receives the event from source and deistribute to all connected applicaitons
