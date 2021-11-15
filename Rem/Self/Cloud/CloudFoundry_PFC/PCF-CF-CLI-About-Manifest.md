
###### Manifest.yaml
This is the file used by Cloud foundry to proceed with deployment and run the applicaiton.
Keep Manifest.yaml as the name of the manifest file, because by default CF will look for this name

```ini
---
applications:
- name: my-first-app
        #Note - The Name Should be unique
  domain: domain.com
        #Optional
  hostname:<subdomain Name>
  command:node app.js
        #We can execute the commands with this attribute
  disk_quota: 1G
  memory: 1G
  instances: 2
  routes:
  - route:hostname.cfapps.io
  host: host-name
  domain: domain-name
  timeout:60
  #Default is 60 sec. If applicaiton require more startup time then we can increase
  no-route:true
  # This can be true for background apps/jobs/engines
  path: .
      #Tells CF CLI where my applicaiton on my local machine
  buildpack: https://github.com/<build_pack_path>.git
          #Note-This is optional. CF will automatically detect build back based on applicaiton config files
  stack: cflinuxfs3
  #cflinuxfs3 - Indicates linux based file system
  Services :
    - SomeRabbitMQ
      # Helps to bind service name to the application

# Below env section used to set env variable at applicaiton level
  env:
      ENV_VARIABLE_NAME: Some Value
      EnvVariableName2: 123
```

>*Note- To know availbale build packs use belwo command*
```powershell
> CF Stack
```


1. We can nest multiple applications in single manifest file
2. Withing single manifest file multiple applicaiotns can share the same configuration
3. We can have parent manifest file
