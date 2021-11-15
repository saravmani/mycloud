

> *In PCF Scalling Up/Down immediatly reflected in router (Auto load balance)*



###### Commands to scale the applicaiton
```powershell
cf scale <appname> -i 2 # To Increase the number of instances
cf scale <appname> -m 250M # To Increase the ram
cf scale <appname> -k 10G # To Increase the local storage size
```



###### Scalling Vertically and Horizontally
In terms of PCF Horizontal scallaing means - Increasing number of process
Vertical scale means - Increase Core and memory
Autoscalling is possible by defining Auto scale policy

> *By default CF do round rboin between the instances*

##### Autoscale policy
we can abe to define autoscale policy like below
throughput >=3 req/sec +2 instances
(i.e if traffic increases >=3 req/ sec then it will add 2 more instances)
This threashould is the average of all the instances

**Sample Autoscale policy (autoscale-policy.json)**
```json
{
  "instance_min_count": 1,
  "instance_max_count": 5,
  "scaling_rules": [
    {
      "metric_type": "throughput",
      "operator": ">=",
      "threshold": 30, // 30 seconds
      "adjustment": "+2",
      "breach_duration_secs": 120, // How long required to execute the threashould. Or How much time we have to wait to do autoscale
      "cool_down_secs": 120
    },
    {
      "metric_type": "throughput",
      "operator": "<=",
      "threshold": 10,
      "adjustment": "-1",
      "breach_duration_secs": 120,
      "cool_down_secs": 120
    }
  ]
}
```
