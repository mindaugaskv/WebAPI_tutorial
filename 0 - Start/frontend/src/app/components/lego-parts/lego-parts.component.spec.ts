import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LegoPartsComponent } from './lego-parts.component';

describe('LegoPartsComponent', () => {
  let component: LegoPartsComponent;
  let fixture: ComponentFixture<LegoPartsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LegoPartsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LegoPartsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
