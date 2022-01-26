import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DrinkTypeSelectionComponent } from './drink-type-selection.component';

describe('DrinkTypeSelectionComponent', () => {
  let component: DrinkTypeSelectionComponent;
  let fixture: ComponentFixture<DrinkTypeSelectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DrinkTypeSelectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DrinkTypeSelectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
