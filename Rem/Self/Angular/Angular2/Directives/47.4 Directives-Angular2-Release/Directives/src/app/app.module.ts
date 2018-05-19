import { NgModule } from '@angular/core';
import { BrowserModule  } from '@angular/platform-browser';
import { AppComponent }   from './app.component';
import { HighlightDirective } from "./highlight.directive";
import { UnlessDirective } from "./unless.directive";

@NgModule({
    declarations: [
        AppComponent,
        HighlightDirective,
        UnlessDirective
    ],
    imports:      [BrowserModule],
    bootstrap:    [AppComponent],
})
export class AppModule {}