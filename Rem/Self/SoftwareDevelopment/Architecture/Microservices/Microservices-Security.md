

Best practices
* Avoid exposing internal MicroServices to external world (Only API Gateway can reachout the service)
* Microservices protected by network. Those should beside the firewall in most cases



###### Typical Security for MicroServices
![](../../../RefImages/MicroServices-Security-1.jpg)


###### Authentication mechanisms
* Client Id and Client Secret
* Basic Authentication (username and password based)
* Static API Key
* OpenId Connect
* Certificates
* SAML
* Finger print


###### Rate Limiting / Throttling
  To protect microservices from DDoS Attacks we can use AspNetCoreRateLimit package.
Normally cloud providers providing DDoS protection. But in some cases we may need to implement ratelimiting at service level.
AspNetCoreRateLimit package addes the protection at pipeline level.
It limits requests based on the client's IP address. We can implement custome rules also.

```powershell
PM> Install-Package AspNetCoreRateLimit
```
