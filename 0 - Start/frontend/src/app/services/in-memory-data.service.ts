import { Injectable } from '@angular/core';
import { LegoPart } from "app/models/lego-part";
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { LegoToy } from "app/models/lego-toy";

@Injectable()
export class InMemoryDataService extends InMemoryDbService {
  createDb(){
    return {
      parts: cArrayParts,
      toys: cArrayToys
    };
  }
}

const cArrayParts: LegoPart[] =[
      {
        id: '1',
        name: '',
        color: 'reiksme',
        size: 'reiksme',
        type: 'reiksme',
        shape: 'reiksme',
        imageUrl: 'https://www.bricklink.com/PL/11293pb001.jpg'
      },
      {
        id: '2',
        name: '',
        color: 'reiksme1',
        size: 'reiksme1',
        type: 'reiksme1',
        shape: 'reiksm1e',
        imageUrl: 'https://www.bricklink.com/PL/87615pb05.jpg'
      }
    ];


const cArrayToys: LegoToy[] = [
      {
        id: '1',
        name: 'Laivas',
        description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum',
        price: 100,
        imageUrl: 'https://www.bricklink.com/SL/6209-1.jpg',
        parts: [
          {
            id: '1',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          }]
      },
{
        id: '2',
        name: 'AT-TE Walker - Mini polybag',
        description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum',
        price: 100,
        imageUrl: 'https://www.bricklink.com/SL/20009-1.jpg',
        parts: [
          {
            id: '1',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          },
          {
            id: '2',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          },
          {
            id: '3',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          },
          {
            id: '4',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          },
          {
            id: '5',
            name: 'Paprasta kaladėlė x3',
            color: 'Raudona',
            size: 'Didelė',
            type: 'Paprasta',
            shape: 'Stačiakampė',
            imageUrl: 'https://www.bricklink.com/PL/3003old.jpg'
          }
          ]
      }      
    ];