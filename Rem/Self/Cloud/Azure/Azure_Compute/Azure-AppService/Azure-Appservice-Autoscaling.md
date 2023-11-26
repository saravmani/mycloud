
#### Autoscaling in Azure App Service
It monitors the resource metrics and  It detects situations where other resources are required to handle an increasing workload, and ensures those resources are available before the system becomes overloaded.

>*** It only changes the instances of web  app. It doesn't have any effect on the CPU power, memory, or storage capacity of the web servers***

>**Not all App Service Plan pricing tiers support autoscaling.**

#### Autoscale conditions
1. metric based - Scale based on a metric
2. schedule based - Scale to a specific instance count according to a schedule
3. Combination

#### Metrics for autoscale rules
1. CPU Percentage
2. Memory Percentage
3. Disk Queue Length
4. Http Queue Length
5. Data In
6. Data Out

**You can also scale based on metrics for other Azure services. Ex: Spin up more instances of a web app if the number of items held in an Azure Service Bus Queue exceeds a critical length**

---

#### How an autoscale rule analyzes metrics
1. *Autoscaling works by analyzing trends in metric values over time across all instances*
2. **Time grain:** Autoscale rule aggregates the values retrieved for a metric for all instances across a period of time known as the time grain. Each metric has its own intrinsic time grain (Mostly it is 1 minute).
<details >
 <summary>Some extra</summary>

Autoscale rule performs a second step that performs a further aggregation of the value calculated by the time aggregation over a longer, user-specified period, known as the Duration. The minimum Duration is 5 minutes. If the Duration is set to 10 minutes for example, the autoscale rule aggregates the 10 values calculated for the time grain.
 [Refer](https://learn.microsoft.com/en-us/training/modules/scale-apps-app-service/3-app-service-autoscale-conditions-rules)
</details>


3. The options available are Average, Minimum, Maximum, Sum, Last, and Count.
4. Autoscale rule detects that a metric has crossed a threshold, it can perform an autoscale action.
    - An autoscale action can be **scale-out or scale-in**




---

#### Cooldown period
- It specified in minutes.
- During this interval, the scale rule won't be triggered again.
- This helps system to stabilize between autoscale events.
- Minimum cool down period is 5 minutes.


#### Paring autoscale rules
- One autoscale rule should indicate how to scale the system out when a metric exceeds an upper threshold.
- Then other rule should define how to scale the system back in again when the same metric drops below a lower threshold.


#### Combining autoscale rules
A single autoscale condition can contain several autoscale rules
Ex:
If the HTTP queue length exceeds 10, scale out by 1
If the CPU utilization exceeds 70%, scale out by 1
- Also we can mention **any | All** to meet any conditon or all condition to get into action

>***If you need to scale in if only one of the scale-in rules are met, you must define the rules in separate autoscale conditions***

> ***By default it is manual scaling***
