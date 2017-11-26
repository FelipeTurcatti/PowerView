import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

import { AppRoutingModule } from './app-routing.module';

import { SensorComponent } from './sensor/sensor.component';

@NgModule({
    imports: [BrowserModule, AppRoutingModule],
    declarations: [AppComponent, SensorComponent],
    bootstrap:    [ AppComponent ]
})
export class AppModule { }
