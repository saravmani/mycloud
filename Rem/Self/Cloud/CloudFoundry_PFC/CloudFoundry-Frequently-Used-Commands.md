

```powershell
cf target # provides api details
cf orgs
cf spaces # to list the available spaces
cf apps # to listdown the apps
cf apps <appname> # to give app specific informations

cf push <appname> -p <applicaiton path> # app name should be unique

cf create-app-manifest <appname> manifest.yml # To create sample manifest file with default parameters

cf stacks # provides list of available file system (i.e linux file system cflinuxfs3)

cf logs <appname> #To monitor the logs fromt the developper machine's console. This will print the logs which are written in console by the applicaiton
cf logs --recent hello-spring-cloud #To view logs that have already been written (histoy)

cf plugins # lists all the installed pluggins
cf install-plugin <plugin-name> # To Install the plugin
```

###### Work with environment variables
```powershell
cf env <app_name> # To get  System and User defined environment variables
cf set-env <APP_NAME> <ENV_VAR_NAME> <ENV_VAR_VALUE>
```


###### To setup Worker applicaion (Like windows services)
```powershell
cf push <worker_app_name> --no-route --health-check-type=process
# --health-check-type=process this indicates CF will continuously monitor  health of the applicaiton
```
