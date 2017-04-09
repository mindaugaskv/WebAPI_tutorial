import { Component, OnInit } from '@angular/core';
import { LegoPart } from 'app/models/lego-part';
import { LegoToy } from "app/models/lego-toy";
import { DataServiceService } from "app/services/data-service.service";

@Component({
  selector: 'app-lego-parts',
  templateUrl: './lego-parts.component.html',
  styleUrls: ['./lego-parts.component.css'],
  providers: [DataServiceService]
})
export class LegoPartsComponent implements OnInit {
  parts: LegoPart[];
  item: LegoPart;
  divToggle: boolean = true;
  isLoading: boolean = false;

  constructor(private dataService: DataServiceService) { }

  ngOnInit() {
    this.refreshList();
  }

  saveItem(item: LegoPart){
    this.item = null;

    if(item == null) return;
    this.dataService.addLegoPart(item);
    
    this.refreshList();
  }

  addNewPart(){
    this.item = new LegoPart();
  }

  refreshList(){
    this.isLoading = true;
    this.dataService.getLegoParts().then(c => {
      this.parts = c;
      this.isLoading = false;
    });
  }
}

