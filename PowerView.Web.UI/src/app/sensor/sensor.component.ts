import { Component, OnInit } from "@angular/core";

import { Sensor } from "./Sensor";
import { SensorService } from "./sensor.service";

@Component({
    templateUrl: "./sensor.component.html"
})
export class SensorComponent implements OnInit {
    constructor(private sensorService: SensorService) {
    }

    ngOnInit() {
        this.getSensors();
    }

    // Public properties
    sensors: Sensor[];
    messages: string[] = [];

    private getSensors() {
        this.sensorService.getSensors()
            .subscribe(sensors => this.sensors = sensors,
            errors => this.handleErrors(errors));
    }

    private handleErrors(errors: any) {
        this.messages = [];

        for (let msg of errors) {
            this.messages.push(msg);
        }
    }
}