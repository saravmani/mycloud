
we can call openshift is as PaaS. 
because it is sitting on top of kuberneties and we will interact with openshift apis and openshift will interact with kuberneties 


Openshift = Kuberneties+ Support + Other tools (Build , deployment, Security, Lifecycle management ,  Monitoring etc.,)


## Openshfit flavers
Openshift origin ()
openshift online
Openshift Enterpirce  (on-premise private PaaS)
Openshift dedicated



Openshift cluster contains - Data plane and Control plane
Control plane (Master node) - API server, etcd (a distributed key-value store), Scheduler, and Controllers
Data plane  (worker node) - (execute the work loads, Kubelet). actually running your application

What is new in openshift when compare to kuberneties
1. integrated image registry
2. Monitoring
3. Web UI
4. Git integration
5. CICI pipeline
6. Provides RBAC
7. Security 
    - Restricts root containers
    - By default containers cannot access the OC APIs. if needed then we have to setup service accoutns for that
8. able to integrate other identiy providers like LDAP

## Resource Types (around 15 Resource types)

deploymentconfig
    -   manage the pods, deploying the pods
    -   this resource is specific to openshift. not specific to kuberneties
## pod(K8)
    - Group of containers (main containers, logging , proxy). mostly it will be single containers
    - OCP tereat pod as single unit scale up    
configmaps(K8) - 
services
    -   for networking

replicationcontroller 
    - this will maintain the number of pods configured
    - DC will create Replicaton Controller and RC will take care of the rest
    - this will manage different application versions

--------------


## Namespaces
Namespaces provide a way to divide a cluster into multiple virtual clusters, allowing teams, projects, or applications to share the same physical cluster while maintaining separation and control over their resources.
namespace will prefix all the resource with the project name


## Users
Regular user - Developers
system user - system:admin , system:master
service account - system:serviceaccount:proj1:db_user


## netowkring
openshift software networking
In openshift the virtual network called Overlay network created usig open V-Switch standard which is a distributed switch
OS contains built in DNS which help to connect ip addess with pods. so instead of ip the pods communicate wiht podname to communicate
openshift uses skydns for dns 


## replicas
scalling config will be saved in to services config. and it will take care of increasing the pods


## Routing tehnique
by default it uses sticky session. i think it uses cookies to track
we can able to change it to round robin or least..


## storage
OS will use the Persistant Volume Framework to provision the persistant storage.
And we can use the pluggings to attache the volume. 
Plugging ex : Azure Desk, Azure File, NFS etc.,


## config map (K8)
not for sensitive data. for sensitive data we should use secrets
1MB Limit

oc create configmap config_map_name  \
    --from-literal kename123="valuexyz"
oc create configmap config_map_name  \
    --from-file=keyame123=filename123.txt    //in this method entire content of the file is a value for the givenkeyname
oc get configmap
oc get -o yaml cm/config_map_name

oc set env dc/deploymentconfigname  --from cm/config_map_name   // to directly update the environment variable to pod
 //i think it will not rquire restart



## Secrets
###### Types of secrets 
1. Opaque secrets or generic secrets - general key value pair like Config Map
2. service account secrets
3. container registry secrets - ex: docker hub secret

oc create secret generic secretname123 \ 
        --from-literal keyname123=keyvalue  // here generic menas type .. i.e Opque


// To access secret as environment variable
oc get o yaml secret/secretname123
oc set env dc/deploymentconfigname --from secret/secretname123



## imagestream

## imagestreamtag