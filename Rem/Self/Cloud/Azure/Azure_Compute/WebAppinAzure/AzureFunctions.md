
Azure functions can be run as par of App-service plan or can be serverless (different processes)***

those are event driven

3 types
  1. Azure functions -
    stateless, max time 5 mins
  2. Azure durable functions -
    popular, function chaining (one function op required for another function)
  3. Web Jobs



Azure function triggers
--------------------------
  http trigger, timer trigger, Cosmos db trigger, blob trigger,
  queue trigger, event grid trigger , event hub trigger


#### Function bindings
3 pars are there
1. Trigger -  schedules | webhook | rules | events
2. input binding
3. output binding
 
#### How to confiure trigger for function?
Select a particular deployed functiona and click on functions menu in left side then click add new button in center pan
there are multiple triggers available

#### Triggers for Functions
Http trigger
azure queue triggers
azure service buss trigger
azure service buss topic trigger
azure blob trigger
