import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LegoToy } from "app/models/lego-toy";
import { LegoPart } from "app/models/lego-part";
import { DataServiceService } from "app/services/data-service.service";

@Component({
  selector: 'app-lego-part-add',
  templateUrl: './lego-part-add.component.html',
  styleUrls: ['./lego-part-add.component.css'],
  providers: [DataServiceService]
})
export class LegoPartAddComponent implements OnInit {
  legoParts: LegoPart[];
  selectedPart: LegoPart = null;

  @Input()
  legoToy: LegoToy;  

  @Output()
  addEvent = new EventEmitter<LegoPart>();
  
  constructor(private dataService: DataServiceService) { 
  }

  ngOnInit() {
    this.dataService.getLegoParts().then(d => this.legoParts = d);
  }

  addPart(){
    this.addEvent.emit(this.selectedPart);
  }

}
