# Angular HttpInterceptor to Handle HTTP Error (Middleware)
###### In Angular HttpInterceptor act as middleware between client side angular application and browser. We can use this for  - HTTP request Error Handling, Middleware logging, Retry http calls etc.,

*I call Interceptors as clientside middleware*

- HttpInterceptor will intercepts all the http requests which are made from angular application.
  We can able to perform any action before http request made to server
  - *Ex: We can Pass authenticaiton token (bearerToken) on each http request*
- Also we can anble to handle the response and perform the actions
  - *Ex: Handle Errors*


###### Sample HttpInterceptor
This code performs two actions
1. Intercept HttpRequest and add the Authorization token to the header
2. Handles the response fromt he server and if it finds UnAuthorised error then
    navigates the application to authenticaiton page

```javascript
import { Injectable } from '@angular/core';
import {
    HttpRequest,HttpHandler,HttpEvent,HttpInterceptor,HttpErrorResponse
} from '@angular/common/http';

import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs/internal/observable/throwError';
import { Router } from '@angular/router';

@Injectable()
export class MyAppHttpInterceptor implements HttpInterceptor {
    constructor(private router: Router) { }
    intercept(objRequest: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        objRequest = objRequest.clone({
            setHeaders: {// Adding auth token
                Authorization: `Bearer ${sessionStorage.getItem('bearerToken')}`
            }
        });
        return next.handle(objRequest).pipe(
            catchError((error: HttpErrorResponse) => {
                if (error.error instanceof ErrorEvent) {
                    // Handle Client Side Error
                    // Example If Network error we can do retry
                }
                else {
                    // Handle Server Side Error
                }
                console.log(error);
                if (error.status === 401) // Handle un UnAuthorised error
                    this.router.navigate(['authenticaiton-page']);
                return throwError(error);
            }
            ));

    }
}
```



[//]: # (Tags: Angular, Interceptor, bearerToken, HttpInterceptor, Middleware, Handle Http Error, Handle UnAuthorised error, Logging)
[//]: # (Type: Angular - Middleware)
[//]: # (Rating: 1)
[//]: # (ReadyState:Publish)
