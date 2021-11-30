



###### TCP Routing

To check TCP enabled we can use below Command

```powershell
cf domains # To get the list of available domains and domain types (We can check if TCP protocol enabled )
```

Below command is to push the application binded to tcp domain
```powershell
cf push <app-name> -d <tcpdomainname.net> --random-route
cf map-route <app-name> -d <tcpdomainname.net> --port 5001 # To map the application with specific port
```
