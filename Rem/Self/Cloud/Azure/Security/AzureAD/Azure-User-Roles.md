#### User Access Administrator
He can assign access and policies only on atmanagement groups level. he can do any other stuff


#### Owner
He is the Administrator of subscription. He can do anything view anything

#### Contributor or Management Group Contributor
Can create all type of resources but cannot grant access to others

#### Reader
Can view existin azure resources


#### Resource Policy Contributor
Only can assign policies. Can assign access




Azure Role Name             | Create | Rename | Move** | Delete | Assign Access | Assign Policy | Read
-----------------------------|--------|--------|--------|--------|---------------|---------------|------
Owner                       | X      | X      | X      | X      | X             | X             | X
Contributor                 | X      | X      | X      | X      |               |               | X
MG Contributor*             | X      | X      | X      | X      |               |               | X
Reader                      |        |        |        |        |               |               | X
MG Reader*                  |        |        |        |        |               |               | X
Resource Policy Contributor |        |        |        |        |               | X             |
User Access Administrator   |        |        |        |        | X             | X


---
