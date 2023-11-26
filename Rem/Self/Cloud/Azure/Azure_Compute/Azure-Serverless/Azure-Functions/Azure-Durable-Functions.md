## Azure Durable Functions
It is an extension of Azure Functions that allows you to write stateful functions in a serverless compute environment.

#### Steps to Create Durable function


#### Types of Azure Durable Functions
1. **Orchestrator Functions**:
    - These functions describe how actions are executed and the order in which they are executed.
    - They can have many different types of actions, including activity functions, sub-orchestrations, waiting for external events, HTTP, and timers

2. **Activity Functions**:
    - These are the basic unit of work in a durable function orchestration.
    - They are the functions and tasks that are orchestrated in the process
    - Stateless
    - Those can be executed in parallel | Sequence

3. **Entity Functions**:
    - These define operations that target a specific entity (like a class instance) and can manage state that persists across multiple function calls
    - These Functions define operations for reading and updating small pieces of state, known as durable entities
    - Statefull
    - Can be invoked from Client functions and Orchestrator functions


4. **Client Functions**:
    - Those are the triggering points 
    - These functions are entry point which is used to start instances of orchestrator functions
    - Any non-orchestrator function can be a client function.
    - What makes a function a client function is its use of the durable client output binding
    - Stateless

##### Patterns
1. Functin chaining
2. Fan-out/fan-int
3. Monitoring
4. Aggregator
5. Human interaction


#### Function chaining example
```csharp
[FunctionName("E1_HelloSequence")]
public static async Task<List<string>> Run(
    [OrchestrationTrigger] IDurableOrchestrationContext context)
{
    var outputs = new List<string>();
    // Call the 'E1_SayHello' function with different inputs
    outputs.Add(await context.CallActivityAsync<string>("E1_SayHello", "Tokyo"));
    outputs.Add(await context.CallActivityAsync<string>("E1_SayHello", "Seattle"));
      // Returns ["Hello Tokyo!", "Hello Seattle!"]
    return outputs;
}

```
