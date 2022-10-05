

### Platform logs

###### 1. Azure Activity log
Find events such starting stopping VMs, Subscription level events etc.,
There's a single activity log for each Azure subscription.

###### 2. Resource logs
Provide insight into operations that were performed within an Azure resource (the data plane).
Examples might be getting a secret from a key vault or making a request to a database. The content of resource logs varies by the Azure service and resource type.
Resource logs were previously referred to as diagnostic logs.

###### 3. Azure AD Logs
Contain the history of sign-in activity and audit trail of changes made in Azure AD for a particular tenant.

> *Log data collected by Azure Monitor (formerly Azure Log Analytics) is stored in a Log Analytics workspace, which is based on Azure Data Explorer. It collects telemetry from a variety of sources*
