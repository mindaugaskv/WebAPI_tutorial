import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LegoToyDetailsComponent } from './lego-toy-details.component';

describe('LegoToyDetailsComponent', () => {
  let component: LegoToyDetailsComponent;
  let fixture: ComponentFixture<LegoToyDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LegoToyDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LegoToyDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
