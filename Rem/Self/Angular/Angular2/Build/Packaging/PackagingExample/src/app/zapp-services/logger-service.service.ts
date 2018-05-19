import { Injectable } from '@angular/core';

@Injectable()
export class LoggerServiceService {

  constructor() {
  }
  ErrorLog(errorMessage: string) {
    console.log("it is error message" + errorMessage);
  }

}
