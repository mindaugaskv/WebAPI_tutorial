import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LegoToysComponent } from './lego-toys.component';

describe('LegoToysComponent', () => {
  let component: LegoToysComponent;
  let fixture: ComponentFixture<LegoToysComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LegoToysComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LegoToysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
