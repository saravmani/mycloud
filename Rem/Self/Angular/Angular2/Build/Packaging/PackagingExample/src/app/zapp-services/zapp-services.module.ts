import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoggerServiceService } from "./logger-service.service";

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers:[LoggerServiceService],
  exports:[]
 })
export class ZappServicesModule { }
