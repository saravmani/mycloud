### Azure Foundatinal Components
1. Compute
2. Storage
3. Network


Azure  uses virtualization (using Hyperviser technology) to separate the Hardware and software.

---
##### How to interact with Azure Enivironment?
1. Azure CLI  - Helpful in automation, Handy, Stable
2. Azure powershell
3. Azure Portal
4. Azure Cloud SHell
5. Azure Mobile app
---
1. Identity and Governance
2. Storage
3. Compute
4. Virtual Network
5. Monitor and backup  (Monitoring soultions and backup and DR)


App services
-------------------
we can hoste asp.net webapplicaiton or others (ex nodejs) using this
we can able to publish we application from vsts to azure directly. We can able to enable remote debugging and can debug it from vsts

Functions
----------
it is serverless autonomous Nano services.
it is simple autonomus funciton we can host it on azure, it will be
  triggered by timer, or can execute by calling from externally
we can able to create functions from vsts and can able to publish
Can able to create web Hooks
Timer functions -- are jobs



Azure Active Directory (AAD)
-----------------------------
Azure Active Directory (AAD) to act as a gatekeeper for protecting secure resources. ASP.NET
Core has native integration with AAD by making use of Bearer authentication. Azure
also offers Azure Active Directory B2C (Azure AD B2C), which is a cloud identity-management
solution for web applications that have a minimal configuration for
authenticating against social, enterprise, and local accounts.

---
### IOT Related services

###### Azure IOT hub
Helps to collect  billions of IoT Devices.
It is a PaaS. It help to onboard new IoT device, scaling, security , authentication etc.,
we will have More control, we can define how we collect data

###### IoT Central
 It is a SaaS. Without coding we can onboard device. It provides multiple connectors. Provides UI, Dashboard

 ###### Azure Sphere
 This is a complete IOT solution provided by Azure.
 > ***We have use the Hardware and Chipsets which are certified by Microsoft for Azure. Azure Sphere Operating system will be running on the device. Azure will manage the update and security etc., ***
---

 ### Big data related offerings
 ###### Azure Data Lake Analytics
 Using this we can able to process the data with clustor of computers in parallel. Azure will manage the clustor of computers

 ###### Azure HDInsights
Similar to Azure Data Lake. But HDInsights uses all open source components.
This uses Apache Hadoop, Spark, Kafka

###### Azure DataBricks
Based on Spark.

###### Azure Synapse Analytics
it is data warehouse offering. Used for data analytics
Synapse SQL language can be used to slice and see the data for analytics


---
### Machine Learning offerings
### Cognetive services
Speach reconisation - Audio to text, identify the person based on voice
Vision Services - Ex: identify face, specific object
Decision service - Ex: To find bad language

Language Understanding (LUIS) is a cloud-based conversational AI service that applies custom machine-learning intelligence

###### Bot Services
Used for automation, for interactive chat etc.,
It is a PaaS. In Azure we can create bots using code or without coding.
Azure provides visual Editor to create bot without coding.
Users can talk to bot with NATURAL language by text or voice.
Aslo we can easily integrate with social media like Facebook

###### Azure Machine learing studio
Provides visual tools for ML process. To view models

###### Machine learning service
managing the machine learning project lifecycle..
We can create a model in Azure Machine Learning or use a model built from an open-source platform, such as Pytorch, TensorFlow,
 
