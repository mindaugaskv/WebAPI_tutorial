import { Component, OnInit } from '@angular/core';
import { DataServiceService } from "app/services/data-service.service";
import { LegoToy } from "app/models/lego-toy";
import { Router } from '@angular/router';

@Component({
  selector: 'app-lego-toys',
  templateUrl: './lego-toys.component.html',
  styleUrls: ['./lego-toys.component.css'],
  providers: [DataServiceService]
})
export class LegoToysComponent implements OnInit {
  legoToys: LegoToy[];
  isLoading: boolean = false;

  constructor(private dataService: DataServiceService, private router: Router) { }

  ngOnInit() {
    this.isLoading = true;
    this.dataService.getLegoToys().then(t => { this.legoToys = t; this.isLoading = false; });
  }

  edit(item: LegoToy){
    this.router.navigate(['/toy', item.id]);
  }

  createNew(){

  }
}
