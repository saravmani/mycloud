#### Simple example to create Observables in Angular to publish data to subscribers
###### In Angular Observable collection playing important role. This article will provide simple steps to start with Observable collecitons

1. Import Observable, Subject from rxjs
```javascript
  import { Observable, Subject } from 'rxjs';
```
2. Declare subject and Observable properties
```javascript
  private menuSubject: Subject<string>;
  public menuItemsObservable: Observable<string>;
```

3. In constructor create object for subject and initialise Observable
```javascript
  this.menuSubject = new Subject<string>();
  this.menuItemsObservable = this.menuSubject.asObservable();
```

4. Use the subject to publish or broadcast the data
```javascript
  this.menuSubject.next(result);
```

---

###### Full Code with Observable and Subject
- Producer.ts - producer
- consumer.ts - consumer

###### Producer.ts - Producer which broadcast the data usbing Observable
```javascript

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class Producer {
  private serverBaseURL = 'http://localhost:53316/';
  private menuSubject: Subject<string>;// Step 1
  public menuItemsObservable: Observable<string>;// Step 2
  constructor(private objHttpClient: HttpClient) {
    this.menuSubject = new Subject<string>();// Step 4
    this.menuItemsObservable = this.menuSubject.asObservable();// Step 5
  }
  public AuthenticateUser(idToken: string, authenticationSource: string): Observable<AuthenticationRes> {
    return this.objHttpClient.post<AuthenticationRes>(this.serverBaseURL + 'ServerAPI')
     .SUBSCRIBE(result => {
       this.menuSubject.next(result);// Step 6
     });
  }
}
```

 ###### Consumer.ts - consumer who subscribes the Observable
```javascript
import { Observable, Subject } from 'rxjs';
import { Producer } from './services/Producer';
export class Consumer {
  constructor(private producer: Producer) {
  }
  initializeApp() {
    this.producer.menuItemsObservable.subscribe(a => { //Step 7
      console.log(a);
    });
  }
}

```

[//]: # (Tags: Angular, Observable, Simple Observable example)
[//]: # (Type: Angular - Observables)
[//]: # (Rating: 1)
[//]: # (ReadyState:Publish)