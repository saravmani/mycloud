
- Static concurrency - Static numbers will be mentioned. But some times not efficiant.. may be overloaded or underutilized
- Dynamic concurrency - Only supported for the Azure Blob, Azure Queue, and Service Bus triggers


```json
--host.json

"version": "2.0",
"concurrency": {
    "dynamicConcurrencyEnabled": true,
    "snapshotPersistenceEnabled": true
}

```

#### Concurrency manager
When dynamic concurrency is enabled there's a concurrency manager process running in the background. This manager constantly monitors instance health metrics, like CPU and thread utilization, and changes throttles as needed
- heuristics  used

Host.Concurrency log category in the traces table - When dynamic concurrency is enabled, you'll see dynamic concurrency decisions in your logs.
