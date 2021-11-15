

Client Types - Public or Confidential
Flow Types  -  How the tokent returned to the client
Endpoints

---

> *For OpenId - TLS is must*



###### Autherisation Endpoints
Client applicaiton uses this enpoint to get Authentication/Autherisation via redirection

##### Redirection Endpoints (Client provides)
Identiy provider uses this endpoint to send the code back to the client via redirection

##### Tokent Endpoint
Client applicaiotn uses this endpoint to get the token via api calls


###### Flow Types
1. authorisation Code Grant - Access tokent return from autherisaion endpoint. identity token will return from tokent end point. USed by Confidential clients
2. Implicit Grant - For NON-Confidential clients.
      Access token and identity token return from autherisaion endpoint
3. Hybrid

> Identity server 4 is opensource
