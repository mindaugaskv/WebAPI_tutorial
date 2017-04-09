import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
import { AlertModule } from 'ng2-bootstrap/ng2-bootstrap';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LegoPartsComponent } from './components/lego-parts/lego-parts.component';
import { LegoPartDetailsComponent } from './components/lego-part-details/lego-part-details.component';
import { DataServiceService } from 'app/services/data-service.service';
import { InMemoryDataService } from "app/services/in-memory-data.service";
import { LegoToysComponent } from './components/lego-toys/lego-toys.component';
import { LegoToyDetailsComponent } from './components/lego-toy-details/lego-toy-details.component';
import { LegoPartAddComponent } from './components/lego-part-add/lego-part-add.component';

@NgModule({
  declarations: [
    AppComponent,
    LegoPartsComponent,
    LegoPartDetailsComponent,
    LegoToysComponent,
    LegoToyDetailsComponent,
    LegoPartAddComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    InMemoryWebApiModule.forRoot(InMemoryDataService),
    AlertModule.forRoot(),
    RouterModule.forRoot([
      {
        path: '',
        redirectTo: '/toys',
        pathMatch: 'full'
      },
      {
        path: 'toys',
        component: LegoToysComponent
      },
      {
        path: 'toy/:id',
        component: LegoToyDetailsComponent
      },
      {
        path: 'toy/add/:id',
        component: LegoPartAddComponent
      },
      {
        path: 'parts',
        component: LegoPartsComponent
      }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
