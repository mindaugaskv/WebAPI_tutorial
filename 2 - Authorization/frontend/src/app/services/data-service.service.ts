import { Injectable } from '@angular/core';
import { LegoPart } from "app/models/lego-part";
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { LegoToy } from "app/models/lego-toy";

@Injectable()
export class DataServiceService {
  delayTimeSec: number = 1000;
  legoPartsUrl: string = 'http://localhost:35201/api/LegoParts';
  legoToysUrl: string = 'http://localhost:35201/api/LegoToys';

  constructor(private http: Http) {
  }

  getLegoToy(id: string): Promise<LegoToy> {
    return this.http.get(this.legoToysUrl + '/' + id)
      .toPromise()
      .then(
        response => {
          return response.json() as LegoToy;
        },
        err => {
          console.log(err);
          return null;
        });
  }

  getLegoToys(): Promise<LegoToy[]> {
    return this.http.get(this.legoToysUrl)
      .toPromise()
      .then(
        response => {
          return response.json() as LegoToy[];
        },
        err => {
          console.log(err);
          return null;
        });
  }

  saveLegoToy(toy: LegoToy): Promise<LegoToy> {
    return this.http.put(this.legoToysUrl + '/' + toy.id, toy)
      .toPromise()
      .then(
        response => {
          return response.json() as LegoToy;
        },
        err => {
          console.log(err);
          return null;
        });
  }  

  addLegoToy(toy: LegoToy): Promise<LegoToy> {
    return this.http.post(this.legoToysUrl, toy)
      .toPromise()
      .then(
        response => {
          return response.json() as LegoToy;
        },
        err => {
          console.log(err);
          return null;
        });
  }    

  getLegoParts(): Promise<LegoPart[]> {
    return this.http.get(this.legoPartsUrl)
      .toPromise()
      .then(
        response => {
          return response.json() as LegoPart[];
        },
        err => {
          console.log(err);
          return null;           
        });    
  }

  addLegoPart(part: LegoPart): Promise<LegoPart> {
    return this.http.post(this.legoPartsUrl, part)
      .toPromise()
      .then(
        response => {
          console.log(response.json() as LegoPart);
          return response.json() as LegoPart;
        },
        err => {
          console.log(err);
          return null;
        });    
  }  

  updateLegoPart(part: LegoPart): Promise<LegoPart> {
    return this.http.put(this.legoPartsUrl + '/' + part.id, part)
      .toPromise()
      .then(
        response => {
          console.log(response.json() as LegoPart);
          return response.json() as LegoPart;
        },
        err => {
          console.log(err);
          return null;
        });    
  }   
}
