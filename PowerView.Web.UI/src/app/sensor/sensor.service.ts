import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Sensor } from "./sensor";

@Injectable()
export class SensorService {
    private url = "/api/Sensor";

    constructor(private http: Http) {
    }

    getSensors(): Observable<Sensor[]> {
        return this.http.get(this.url)
            .map(this.extractData)
            .catch(this.handleErrors);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body || {};
    }

    private handleErrors(error: any): Observable<any> {
        let errors: string[] = [];

        //TODO: handler errors here !

        return Observable.throw(errors);
    }
}