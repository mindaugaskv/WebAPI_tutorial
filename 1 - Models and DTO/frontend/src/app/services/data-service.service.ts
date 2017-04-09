import { Injectable } from '@angular/core';
import { LegoPart } from "app/models/lego-part";
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { LegoToy } from "app/models/lego-toy";

@Injectable()
export class DataServiceService {
  delayTimeSec: number = 1000;

  constructor(private http: Http) {
  }

  getLegoToy(id: string): Promise<LegoToy> {
    return this.http.get('/api/toys/' + id)
      .delay(this.delayTimeSec)
      .toPromise()
      .then(response => {
        return response.json().data as LegoToy;
      });
  }

  getLegoToys(): Promise<LegoToy[]> {
    return this.http.get('/api/toys')
      .delay(this.delayTimeSec)
      .toPromise()
      .then(response => {
        return response.json().data as LegoToy[];
      });
  }

  saveLegoToy(toy: LegoToy): Promise<LegoToy> {
    return this.http.post('/api/toys', toy)
      .delay(this.delayTimeSec)
      .toPromise()
      .then(response => {
        return response.json().data as LegoToy;
      });
  }  

  getLegoParts(): Promise<LegoPart[]> {
    return this.http.get('/api/parts')
      .delay(this.delayTimeSec)
      .toPromise()
      .then(response => {
        return response.json().data as LegoPart[];
      });    
  }

  addLegoPart(part: LegoPart): Promise<LegoPart> {
    return this.http.post('/api/parts', part)
      .toPromise()
      .then(response => {
        return response.json().data as LegoPart;
      });    
  }  
}
