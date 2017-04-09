import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LegoPart } from "app/models/lego-part";

@Component({
  selector: 'app-lego-part-details',
  templateUrl: './lego-part-details.component.html',
  styleUrls: ['./lego-part-details.component.css']
})
export class LegoPartDetailsComponent implements OnInit {

  constructor() { }
  
  ngOnInit() {
  }
  
  @Input()
  itemDetails: LegoPart;

  @Output()
  saveEvent = new EventEmitter<LegoPart>();

  save(){
    this.saveEvent.emit(this.itemDetails);
  }

  cancel(){
    this.saveEvent.emit(null);
  }
}
