

```powershell
CF API # provides api details
cf target # provides api and user details
cf orgs
cf spaces # to list the available spaces
cf target -s <spacename> # to switch to another space

cf apps # to listdown the apps
cf apps <appname> # To give app specific informations
cf quotas # provide resource , quota details
cf stop <appname> # To stop the specific applicaiton
cf start <appname>
cf restart <appname> # will re create the applicaiton with latest env variables
cf stacks # provides list of available file system (i.e linux file system cflinuxfs3)
#Ex - cflinuxfs3

cf push <appname> -p <applicaiton path> # app name should be unique
cf map-route <app-name> -d <domainname.net> --port 5001 # To map the application with specific port or specific domain
cf create-app-manifest <appname> manifest.yml # To create sample manifest file with default parameters

cf plugins # lists all the installed pluggins
cf install-plugin <plugin-name> # To Install the plugin
cf marketplace # List the services provided by the cloud foundry provider
# Ex: mongo db, redis cache

cf services # list of available services to my APP
cf domains # To get the list of available domains and domain types (We can check if TCP protocol enabled )
```

###### To view logs
```powershell
cf logs <appname> #To monitor the REAL time logs from developper machine's console. This will print the logs which are written in console by the applicaiton
cf logs --recent <appname> #To view logs that have already been written (histoy)
cf events --recent <appname> # Displays major events , errors  Ex. app crash
```



###### Work with environment variables
```powershell
cf env <app_name> # To get  System and User defined environment variables
cf set-env <APP_NAME> <ENV_VAR_NAME> <ENV_VAR_VALUE>
cf unset-env <APP_NAME> <ENV_VAR_NAME> # To Remove the env variable

```


###### To setup Worker applicaion (Like windows services)
```powershell
cf push <worker_app_name> --no-route --health-check-type=process
# --health-check-type=process this indicates CF will continuously monitor  health of the applicaiton
```


###### Commands to scale the applicaiton
```powershell
cf scale <appname> -i 2 # To Increase the number of instances
cf scale <appname> -m 250M # To Increase the ram
cf scale <appname> -k 10G # To Increase the local storage size
```
