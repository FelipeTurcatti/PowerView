import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';


import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

import { SensorComponent } from './sensor/sensor.component';
import { SensorService } from './sensor/sensor.service';

@NgModule({
    imports: [BrowserModule, AppRoutingModule, HttpModule],
    declarations: [AppComponent, SensorComponent],
    bootstrap: [AppComponent],
    providers: [SensorService]
})
export class AppModule { }
