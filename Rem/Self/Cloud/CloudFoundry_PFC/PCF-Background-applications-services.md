
###### Run task
```powershell
> cf run-task <app-name> <command> # This should trigger the runnable (ex: Exe)
```



```ini
---
applications:
- name: my-first-app
  command:node app.js
  memory: 1G
  instances: 2
  no-route:true
  # Note no-route attribute. this will tell cloud foundry that the app should run in  background
  Services :
    - SomeRabbitMQ
# Below env section used to set env variable at applicaiton level
  env:
      ENV_VARIABLE_NAME: Some Value
      EnvVariableName2: 123
```
