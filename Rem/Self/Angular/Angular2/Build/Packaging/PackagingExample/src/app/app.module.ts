import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { ZappUicomponentsModule } from "./zapp-uicomponents/zapp-uicomponents.module";
import { ZappServicesModule } from "./zapp-services/zapp-services.module";


@NgModule({
  declarations: [
    AppComponent,
      
   ],
  imports: [
    BrowserModule,
    ZappUicomponentsModule,
    ZappServicesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
