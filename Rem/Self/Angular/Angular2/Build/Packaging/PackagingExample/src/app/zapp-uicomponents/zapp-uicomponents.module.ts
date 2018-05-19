import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoaderComponent } from "./loader/loader.component";
import { ZappServicesModule } from "../zapp-services/zapp-services.module";

@NgModule({
  imports: [
    CommonModule,
    ZappServicesModule
  ],
  declarations: [LoaderComponent],
  exports: [LoaderComponent]
})
export class ZappUicomponentsModule { }
