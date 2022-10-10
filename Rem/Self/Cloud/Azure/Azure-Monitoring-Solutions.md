

### Platform logs

###### 1. Azure Activity log
Find events such starting stopping VMs, Subscription level events etc.,
There's a single activity log for each Azure subscription.

###### 2. Resource logs
- Provide insight into operations that were performed within an Azure resource (the data plane).
Examples might be getting a secret from a key vault or making a request to a database.
- Resource logs were previously referred to as diagnostic logs.

###### 3. Azure AD Logs
Contain the history of sign-in activity and audit trail of changes made in Azure AD for a particular tenant.

> *Log data collected by Azure Monitor (formerly Azure Log Analytics) is stored in a Log Analytics workspace, which is based on Azure Data Explorer. It collects telemetry from a variety of sources*

---

#### Telemetry
- It is data about How devices, systems, applications, services are performing. This will be passed to Azure Monitor.
Azure monitor provides dashboard to monitor all Telemetry data
Cloud services, on-premises service also send telemetry data to Az Monitor.
- Also we able to query the data by query Language
- Also we can use **built-in Machine Learing** to predict any problems

---
### Azure Monitoring provides 3 tools  (UI dash board like ITRS tool)
#### Log Analytics
- Stores and queries data, Combine different type of logs.We can query and get the insights like - Desk space, errors, CPU usage etc,.
- Pre built queries also provided by azure.
- This query language called ***Kusto Query Language (KQL)***. Similar to SQL query

#### Monitor Alerts
- Sends notification un unexpected event.
- We have to create alert rule + Set Action group (email, sms, or trigger Other app (ex trigger function))
- Alert rule contains - Resource to monitor + Telemetry To monitor (Ex: CPU) + Condition (Ex: CPU>95%) + Severity level
- Ex: Application is unresponsive, Low CPU or RAM

#### Applicaiton Insights
- This works with web applicaiton only
- Web application can be App service, VM , On premise host etc.,
- Info about web applicaiton performance, User Usage, Failed request, availability.


### Service health portal
It is free service.  shows insights of the service. Custom alerts
