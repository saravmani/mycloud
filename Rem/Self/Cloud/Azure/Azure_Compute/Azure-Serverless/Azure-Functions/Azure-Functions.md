
### Azure Functions

##### Create App functions
![](../../../../RefImagesPrivate/Azure/AppFunctionCreateUI.jpg)

---

#### Azure Functions - Hosting plans

1. **Consumption plan**:
- Pure serverless
- This is the default hosting plan.
- It scales automatically and you only pay for compute resources when your functions are running.
- This plan is ideal if your functions are not running continuously

2. **Premium plan**:
- This plan automatically scales based on demand using **pre-warmed** workers, which run applications with no delay after being idle, runs on more powerful instances, and connects to virtual networks. **Supports VNet**
- This plan is ideal if your function apps run continuously or nearly continuously, you need more CPU or memory options than what is provided by the Consumption plan, your code needs to run longer than the maximum execution time allowed on the Consumption plan

3. **Dedicated (App Service) plan**:
- This plan allows you to run your functions within an App Service plan at regular App Service plan rates.
- This is best for long-running scenarios where Durable Functions can't be used
- Not a serverless. Ability to use underutilized AppService to host the functions
- **Supports VNet**

In addition to these plans, you can also host containerized function apps in containers which can be deployed to Kubernetes clusters and to Azure Container Apps.
Hosting Azure Functions containers on both Azure Arc-enabled Kubernetes clusters and Azure Container Apps is currently in preview


#### Durable Functions
 - It is an extension of Azure Functions that lets you write stateful functions in a serverless environment.
 - The extension lets you define stateful workflows by writing orchestrator functions
 - Behind the scenes, the extension manages state, checkpoints, and restarts
---

 >*Azure Functions, Azure App Service WebJobs with the WebJobs SDK is a code-first integration service that is designed for developers. **Both are built on Azure App Service***

 Azure Functions is built on the WebJobs SDK, so it shares many of the same event triggers and connections

 Azure Functions offers more developer productivity than Azure App Service WebJobs does.

#### Storage account requirements
- Function app requires a general Azure Storage account, which supports Azure Blob, Queue, Files, and Table storage.
- Function code files are stored on Azure Files shares on the function's main storage account. If main storage account of the function app deleted, the function code files are deleted and can't be recovered.

#### host.json
- It is a metadata file in Azure Functions that contains configuration options that affect all functions in a function app instance.
- It is located at the root of a function app project.
 - The *functionTimeout* property in the host.json project file specifies the timeout duration for functions in a function app.
 - We can override settings per environment using application settings




### Scale Azure functions
- In the Consumption and Premium plans, Azure Functions scales CPU and memory resources by adding more instances of the Functions host.
- The number of instances is determined on the number of events that trigger a function.
- Each instance of the Functions host in the Consumption plan is limited to 1.5 GB of memory and one CPU
-  In the Premium plan, the plan size determines the available memory and CPU for all apps in that plan on that instance.

#### Scale controller
- It is a component used by Azure Functions to monitor the rate of events and determine whether to scale out or scale in.
- Scale controller uses heuristics for each trigger type. Ex: when you're using an Azure Queue storage trigger, it scales based on the queue length

#### Cold start
After function app has been idle for a number of minutes, of instances reduced to zero.
The next request has the added latency of scaling from zero to one.
This latency is referred to as a cold start.

#### Scale Limit
***functionAppScaleLimit*** value. The functionAppScaleLimit can be set to 0 or null for unrestricted, or a valid value between 1 and the app maximum.




#### Custom handlers

Custom Handlers as lightweight web servers that receive events from the Azure Functions host. They execute the function code and return a response to the Functions.

You can write your own APIs in any language, even those not natively supported by Azure Functions. For example, you could use languages like Go or Rust.
