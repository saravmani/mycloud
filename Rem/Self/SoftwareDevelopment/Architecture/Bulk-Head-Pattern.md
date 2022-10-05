###### Bulkhead pattern

To implement the bulkhead pattern, we need to make sure that all our services work independently of each other, and failure in one will not create a failure in another service. Techniques such as maintaining a single-responsibility pattern, an asynchronous-communication pattern, or fail-fast and failure-handling patterns help us to achieve.
