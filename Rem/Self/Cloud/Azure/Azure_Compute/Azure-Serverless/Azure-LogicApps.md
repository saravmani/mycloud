#### Azure Logic Apps
This helps in scheduling, task orchestration, work flow, automation
Azure Logic Apps helps to create and run automated workflows with little to no code. By using the visual designer and selecting from prebuilt operations, you can quickly build a workflow that integrates and manages your apps, data, services, and systems.

##### Key Features
- **Visual Designer**: By using the visual designer and selecting from prebuilt operations, you can build a workflow that integrates and manages your apps, data, services, and systems.
- **Connectivity**: Azure Logic Apps simplifies the way that you connect legacy, modern, and cutting-edge systems across cloud, on premises, and hybrid environments.


#### **Examples of Tasks**
1. Schedule and send email notifications using Office 365 when a specific event happens.
2. Route and process customer orders across on-premises systems and cloud services.
3. Move uploaded files from an SFTP or FTP server to Azure Storage.
4. Monitor tweets, analyze the sentiment, and create alerts or tasks for items that need review.

#### **Structure of a Logic App**
Each Logic App starts with a single trigger, after which you must add one or more actions. A trigger is always the first step

---

 > ***It considered as - iPaaS (Integration Platform as a Service)***


#### CLI Command for Azure logic App creation
```powershell
az logicapp create --name --resource-group --storage-account [--app-insights] [--app-insights-key] [--deployment-container-image-name] [--deployment-local-git] [--deployment-source-branch] [--deployment-source-url]

```
