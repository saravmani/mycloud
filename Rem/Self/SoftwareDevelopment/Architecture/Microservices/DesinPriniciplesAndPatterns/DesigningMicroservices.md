While designing microservices we have to consider below
1. Network traffic (one service may depend another service.
    so we have to try to reduce this chained calls as much as possible)
2. reduce cross domain calls as much as possible


##### Design patterns for microservices
1. Bulkhead
2. Sidecar
3. Ambassador
4. Saga ()
5. Circute breaker
