

#### Azure API Management
- It is a hybrid, multicloud management platform for APIs across all environments.
- It’s a platform-as-a-service that supports the complete API lifecycle.
- It is made up of an
  - API gateway
    - Accept requests and routs
    - Validate tokents and cred
    - Enforce policies
    - Logs
    - Cache
  - Management plane
    - Import API Schema, Pacage APIs, Set policies for APIs, Gain access to user analytics
  - Developer portal
    - setup subscription
    - Create and Manage keys


#### Product
- When we publish the api  using API Management then it wil packaged as a PRODUCT. Product contain 1 or more API and description.
- It can be open or protected
- Producted means developer must subscribe before use the API

#### Policy
- It is simple XML documents
- In Azure API Management, a policy is a collection of statements that are executed sequentially on the request or response of an API1.
- Policies allow API publishers to change the behavior of APIs through configuration
- Ex: Convert from XML to JSON, Rate Limiting, IP address filtering


> *** The policy XML configuration is divided into inbound, backend, outbound, and on-error sections. This series of specified policy statements is executed in order for a request and a response. If an error occurs during the processing of a request, any remaining steps in the inbound, backend, or outbound sections are skipped. Execution jumps to the statements in the on-error section****


#### Sample Policy
```xml
<policies>
    <inbound>
        <base />
        <set-header name="X-Content-Type-Options" exists-action="override">
            <value>nonsniff</value>
        </set-header>
    </inbound>
    <backend>
        <base />
    </backend>
    <outbound>
        <base />
    </outbound>
    <on-error>
        <base />
    </on-error>
</policies>

```
