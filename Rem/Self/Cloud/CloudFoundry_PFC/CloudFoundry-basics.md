

MY IBM Cloud
API endpoint:   https://api.cf.ap21.hana.ondemand.com
API version:    3.101.0
user:           saravmani.techlab@gmail.com
org:            14cfbbb8trial
space:          dev

Credentials
saravmani/C-stdpwd

1. Within organisation splitup the teams with cleane boundary


Support containers
supports .Net
Tasks, and continues running applicaitons (IIS)


revisions - to roleback the changes
Diego - Archestration tool (like Kubernetes)

It has market place from where we can use anything ex: Kafka

---

in Cloud controller we have to create Namespace for our project


###### Diego
Diego is a self-healing container management system that attempts to keep the correct number of instances running in Diego cells to avoid network failures and crashes. Diego schedules and runs Tasks and Long-Running Processes (LRP)


Multiple infra providers for Cloud foundry including
Azure, Amazon, Google cloud platform (GCP), AliCloud, Vmware


###### Cloud foundry components
1. Routing (Entry point .. act as load balancer also)
2. Authentication (UAA service)
3. Execution
4. Services (Like DB services)
5. Messaging (Communicaiton)
6. Logs and Metrics

##### Cloud Controller
Cloud Controller is responsible complete management of applicaiton lifecycle
Here lifecycle is - Pusing -> Staging ->Running


##### Best practices for cloud native applicaiton
  Local file system should not be used. Try to use standard file system (cloud based is best)
  Dont use domain level cookies


###### Manifest.yaml
This is the file used by Cloud foundry to proceed with deployment and run the applicaiton.
Keep Manifest.yaml as the name of the manifest file, because by default CF will look for this name

```ini
applications:
- name: my-first-app
  disk_quota: 1G
  memory: 1G
  instances: 2
  routes:
  - route:hostname.cfapps.io
  host: host-name
  domain: domain-name
  path: .
  buildpack: https://github.com/<build_pack_path>.git
  stack: cflinuxfs3
  #indicates linux based file system
```


###### Buildpacks
Build pack service - Takes care of building the applicaion.
While doing CF push it will detect the type of applicaiton by using config files and check the buildpacks for compatibility.
We can also provide a build pack expilicitly.


###### What CF push command do
- run push command with run pack
- Uploades the files
- then creates deployment artifact by combining buildpack+source code+dependencies+configuration
- Then container will be created for the applicaiton then pushed
- And app started

###### Routes
1. we can create internal domains to communicate the applications between them


###### Scalling Vertically and Horizontally
In terms of PCF Horizontal scallaing means - Increasing number of process
Vertical scale means - Increase Core and memory
Autoscalling is possible by defining Auto scale policy

> *By default CF do round rboin between the instances*

##### Autoscale policy
we can abe to define autoscale policy like below
throughput >=3 req/sec +2 instances
(i.e if traffic increases >=3 req/ sec then it will add 2 more instances)
This threashould is the average of all the instances

**Sample Autoscale policy (autoscale-policy.json)**
```json
{
  "instance_min_count": 1,
  "instance_max_count": 5,
  "scaling_rules": [
    {
      "metric_type": "throughput",
      "operator": ">=",
      "threshold": 30, // 30 seconds
      "adjustment": "+2",
      "breach_duration_secs": 120, // How long required to execute the threashould. Or How much time we have to wait to do autoscale
      "cool_down_secs": 120
    },
    {
      "metric_type": "throughput",
      "operator": "<=",
      "threshold": 10,
      "adjustment": "-1",
      "breach_duration_secs": 120,
      "cool_down_secs": 120
    }
  ]
}
```

###### Revisions (i.e Deployment versions)
We can relate Revisions to applicaiton versions. If we want to reverse back to old version
of the deplyment we can use this revisions to rollback.
A revision represents code and configuration used by an app at a specific time.
This allows you to deploy a version of the app that you had running previously without needing to track that previous state yourself or have multiple apps running.
> **Even if we update the environment variable this will create a new revision**
