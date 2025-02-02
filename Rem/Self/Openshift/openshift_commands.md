oc whoami # to see the login details

oc logout


oc projects #to view list of projects

oc project <project name>


without pod we cannot run the ccontainer
we can able to group the containers and MAKE sure to run in single container


oc explain <resource name> ## to view the documentation of the current version of the openshift. but it need n/w connection
# in response we will the label called version. if it V1 then the resources is from kuberneties and if the word not contains the word called openshift then it is related to kuberneties directly
(i.e open shift built on top of kuberneties and it is having its own tools on top of that)
Host means Nodes .. 

ex: 
oc explain pod
oc explain pod.spec
oc explain pod.spec.containers


## pods
oc get pods
oc get pods --watch //to watch current state and lifecycle events
oc rsh <podname> // to run the commands in pod. within this you can run curl commands
oc delete pod/<podname>





------------
### To deploy with deployment config
#### To deploy from image registry
oc new-app <image-name with registry path> --as-deployment-config  --name <app name>
#### To deploy from git url. openshift will create an image out from the code. openshift will create build POD to build the image and it will delete the build pod
oc new-app <gitbub url> --as-deployment-config  --name <app name>

oc get <resouce type>
oc get svc  //to view service
oc get dc //deployment config
oc get istag // image stream


oc describe dc/<image name>

delete all the resources with label
oc delete all -l app=<label>




--------
oc get rc //deloyment configuration



oc expose service/nameoftheservice // to expose service from outside





## Terminal commands
-------------------------

ls  
ls -I (im not sure on this command . need to explore)
