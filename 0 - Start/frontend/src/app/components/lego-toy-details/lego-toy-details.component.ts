import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { DataServiceService } from 'app/services/data-service.service';
import { LegoToy } from 'app/models/lego-toy';
import { Location } from '@angular/common';
import { LegoPart } from "app/models/lego-part";

@Component({
  selector: 'app-lego-toy-details',
  templateUrl: './lego-toy-details.component.html',
  styleUrls: ['./lego-toy-details.component.css'],
  providers: [DataServiceService]
})
export class LegoToyDetailsComponent implements OnInit {
  legoToy: LegoToy = new LegoToy();
  isLoading: boolean = false;

  constructor(private route: ActivatedRoute,
    private dataService: DataServiceService,
    private location:  Location,
    private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.loadItem(params['id'])
    });
  }

  goBack(): void{ 
    this.location.back();
  }

  saveItem(item: LegoToy){
    this.dataService.saveLegoToy(item);
    this.location.back();
  }

  removePart(part: LegoPart){
    var index = this.legoToy.parts.findIndex(i => i.id == part.id);
    this.legoToy.parts.splice(index, 1);
  }

  addPart(){
    this.router.navigate(['/toy/add', this.legoToy.id]);
  }

  loadItem(id: string){
    this.isLoading = true;

    this.dataService.getLegoToy(id)
        .then(t => { 
          this.legoToy = t;
          this.isLoading = false;
        });
  }
}
