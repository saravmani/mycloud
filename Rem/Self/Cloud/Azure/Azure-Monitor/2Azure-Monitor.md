
#### Inputs for azure monitor
Applications
Virtual machines
Guest operating systems
Containers including Prometheus metrics
Tenant Monitoring - Tenant level services such as AD
Subscription Monitoring
Resource monitoring
App monitoring
...

>***we can use the Azure Monitor REST API to send data to Azure Monitor from a REST client ***


#### Type of data collected in Azure Monitor
1. Metrics data -  It is numeric and time dependent. This collected regular interval.
Ex: CPU Utilisation, Traffic, Free space in Storage account, Server response time etc.,
2. Log Data

#### Tool - Log Analytics
This is avalilable in AZ portal used to run the queries agains logs
This uses Kusto Query Language - KQL

---

This data can be used by other services for visualize, analyze, respond etc.,
Ex:
Application insights
Visualize - Dashvboards, Bower BI
Analyse - Log Analytics
Respond - Alerts and Autoscale
Monitoring - Logic Apps


#### Alerts types
- Metric alerts
- Log alerts
- Activity Log Alerts
