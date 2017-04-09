import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LegoPartDetailsComponent } from './lego-part-details.component';

describe('LegoPartDetailsComponent', () => {
  let component: LegoPartDetailsComponent;
  let fixture: ComponentFixture<LegoPartDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LegoPartDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LegoPartDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
