


```mermaid
flowchart LR
A(Catalogue Microservice)
B(Ordering Microservice)
C(Basket MicroService)
D(Event Bus)


subgraph MicroServices
  A
  B
  C
end

subgraph Event-Bus
D
end

A --> Event-Bus
B --> Event-Bus
C --> Event-Bus

```


```c
Basket Microservice

  + Basket Cart
      calculatePrice()
      -UserName
      -TotalPrice
      + BasketCartItem
          - Qty, Price, PRoductId, PRodName, Colour

BasketCheckout
  - username, country, state, zipcode,
  - carno, cvv, expiration etc.,
```
