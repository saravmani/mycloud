## Application Insights metrics

**Overview**

Application Insights metrics let you analyze the health of your monitored apps, create powerful dashboards, and configure alerts. There are two kinds of metrics:

* **Log-based metrics:** Collected from events stored in logs. More dimensions, better for data analysis and ad-hoc diagnostics.
* **Standard metrics:** Pre-aggregated time series with key dimensions. Better performance at query time, better for dashboarding and real-time alerting.

**Log-based metrics**

* Developers can send events manually or use automatic collection.
* Application Insights backend stores events as logs.
* Good for analytical and diagnostic value.
* Can be impractical for applications that generate a large volume of telemetry.

**Pre-aggregated metrics**

* Stored as pre-aggregated time series, and only with key dimensions.
* Faster and requires less compute power to retrieve data.
* Enables new scenarios such as near real-time alerting on dimensions of metrics, more responsive dashboards, and more.

**New SDKs**

New SDKs (Application Insights 2.7 SDK or later for .NET) pre-aggregate metrics during collection. This applies to standard metrics sent by default so the accuracy isn't affected by sampling or filtering.

**Old SDKs**

For old SDKs that don't implement pre-aggregation, the Application Insights backend still populates the new metrics by aggregating the events received by the Application Insights event collection endpoint. While you don't benefit from the reduced volume of data transmitted over the wire, you can still use the pre-aggregated metrics and experience better performance and support of the near real-time dimensional alerting.

**Collection endpoint**

Collection endpoint pre-aggregates events before ingestion sampling, which means that ingestion sampling will never impact the accuracy.


---

#### Enable via OpenCensus
-  Application Insights also supports distributed tracing through OpenCensus.
- OpenCensus is an open source, vendor-agnostic, single distribution of libraries to provide metrics collection and distributed tracing for services
