

##### Azure App service configuraitons


![](../../../../RefImagesPrivate/Azure/AzureAppserviceConfig.jpg)

---

#### Types of Azure App service configuraitons
1. **App Settings**: These are name-value pairs that you can add to an app. The values are encrypted at rest and transmitted over an encrypted channel¹.

2. **Connection Strings**: These are database connection strings that can be consumed by the application code. Connection strings are also encrypted at rest and transmitted over an encrypted channel¹.

3. **General Settings**: These include platform version, bitness, web sockets, always on, etc¹.

4. **Default Documents**: These are the default documents that the web app will load when the root URL of the website is accessed¹.

5. **Path Mappings**: These are virtual directories and actual paths in your app where they point to

6. **Handler Mappings**: These allow you to define custom script processors for your web app

> **Remember, any changes made to these settings will cause the app to restart**

---


#### Differents between Azure App Configuration And Azure Appservice Configurations

Azure App Configuration and Azure App Service Configuration are both used to manage application settings, but they serve different purposes and have different capabilities

**Azure App Service Configuration**:
- It allows you to define app settings for each App Service instance
- These settings are passed as environment variables to the application code
- You can associate a setting with a specific deployment slot
- It's more suitable for simple applications or when the settings are specific to the app service

**Azure App Configuration**:
- It's like a cloud app.config where you can define key-value pairs and app service applications can access them
- It allows you to define settings that can be shared among multiple apps. This includes apps running in App Service, as well as other platforms
- It becomes beneficial when you modernize your app and start breaking down your backend REST API into a microservice architecture with many services
- When you need to change a setting that is used across all microservices, you just do one change when using Azure app config
