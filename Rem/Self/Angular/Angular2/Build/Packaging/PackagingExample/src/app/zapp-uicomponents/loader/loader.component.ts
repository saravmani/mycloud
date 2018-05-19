import { Component, OnInit } from '@angular/core';
import { LoggerServiceService } from "../../zapp-services/logger-service.service";

@Component({
  selector: 'app-loader',
  templateUrl: './loader.component.html',
  styles: []
})
export class LoaderComponent implements OnInit {

  constructor(private LoggerServiceService:LoggerServiceService) { }

  ngOnInit() {
    this.LoggerServiceService.ErrorLog("some test");
  }

}
