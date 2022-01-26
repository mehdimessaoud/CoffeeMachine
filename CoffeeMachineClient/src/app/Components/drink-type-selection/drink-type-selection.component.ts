import { Component, EventEmitter, Output, Input, OnInit } from '@angular/core';
import { DrinkType } from 'src/app/models/DrinkType';
import { DrinkTypeService } from 'src/app/services/drink-type.service';

@Component({
  selector: 'app-drink-type-selection',
  templateUrl: './drink-type-selection.component.html',
  styleUrls: ['./drink-type-selection.component.css']
})
export class DrinkTypeSelectionComponent implements OnInit {

  constructor(private drinkTypeService: DrinkTypeService) { }

  drinkTypes: DrinkType[];
  selectedDrinkType: DrinkType;
  @Output() drinkTypeChange = new EventEmitter();

  private drinkTypeId: number;

  // use getter setter to define the property
  get selectedDrinkTypeId(): number {
    return this.drinkTypeId;
  }

  @Input()
  set selectedDrinkTypeId(val: number) {
    this.drinkTypeId = val;

    if (this.drinkTypes) {
      this.selectedDrinkType = this.drinkTypes.find(d => d.id === this.selectedDrinkTypeId);
    }
  }


  ngOnInit(): void {
    this.drinkTypeService.getAllDrinktypes()
      .subscribe((data: DrinkType[]) => {
        this.drinkTypes = data;
        this.selectedDrinkType = this.drinkTypes.find(d => d.id === this.selectedDrinkTypeId);
        console.log(data);
      });

  }

  changeSelected(element: DrinkType) {
    this.selectedDrinkType = element;
    this.drinkTypeChange.emit(this.selectedDrinkType.id);
  }

}
