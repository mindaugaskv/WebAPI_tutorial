import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LegoPartAddComponent } from './lego-part-add.component';

describe('LegoPartAddComponent', () => {
  let component: LegoPartAddComponent;
  let fixture: ComponentFixture<LegoPartAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LegoPartAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LegoPartAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
