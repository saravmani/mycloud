#### CQRS - Discussion
###### CQRS Architectural design pattern stands for Command and Query Responsibility Segregation
>

Architectural design pattern which seperates read and Write operations seperatly.
This is mostly suitable for Domain centric Architecture

###### Command
1. Change the state
2. Should not read the data

###### Query
1. Read the data
2. Should not modify the state

> *Note Allways we cannot achive this seperation. Ex: When we create a new record then we may return the recordid. But we have to try to  minimise this as much as possible*

###### Advantages
* Maximize its performance, scalability, and security
* Application flexibility increased  (Modification in applicaiton will be easy)
* Seperating the responsibility of reading and writting increases the flexibility of the system

###### Cons
* Increases complexity
*


###### 3 Types of CQRS pattern implementations
1. Single database model
2. Two database model (one for read and another for write)
3. Event sourcing CQRS

[//]: # (Tags: CQRS,  CQRS Architectural design pattern )
[//]: # (Type: software Architecture  - CQRS)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Inprogress)
