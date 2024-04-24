
#### Management groups
* Manage subscriptions by logically grouping them to management groups
* Which means Management groups are one level above then subscripts
* Management group can contain other management groups as child. It can be multiple levels (**Max SIX Level**)
* Root Management group is at top level
* If we apply Policies and RBAC (roll based access controll) at root level then it will be applied to all the childs like water fall
* We can provide role-access to specific Management group / Subscriptions for the users.
* If the user has role-access to specific management group then they will have access to all the child levels on that particular group


#### Root Management Group
* Root Management group acess will not be given by default
* This cannot be deleted or moved
* Global administrator must be elevated to user Access-Administrator of root group
