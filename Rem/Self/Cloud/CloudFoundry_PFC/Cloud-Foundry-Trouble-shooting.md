
1. View logs by CF logs command

```powershell
> CF logs <appname>
```

2. Log the entries to splunck like services
3. Connect to the remote server using SSH conneciton (helpful to find system level exceptions)


To Check the permission for SSH connection run below command
> *Note SSH can be disabled at Org level, Space level, App level. Higher will take more precedence. Ex: If ssh disabled at space level, then Enabling at app level  will not give SSH access*
```powershell
> CF space-ssh-allowed <spacename>
> CF space-ssh-allowed <appname> # to check ssh support at applicaiton level
```


###### Steps to Make SSH Connection with container
> *Make shure you have SSH support*
1. Get GUID by running below command
```powershell
> CF app <appname> --guid
```
2. Fetch applicaiton SSH endpoint by running below command
```powershell
> CF curl /v2/info
```
3. Get one time password by running below command
```powershell
> CF ssh-code
```
4. Now connect with ssh with below command. We need to mention GUID, Port number and ssh endpoint to make SSH tunnel
```powershell
> ssh -p 2222 cf:<guid>/0@<ssh endpoint>
```

> *Cloud Foundry allows us to connect service's container also (Ex: SQL server instance)*
