import { Component } from '@angular/core';
import { UserSelectionService } from './services/user-selection.service';
import { UserChoice } from './models/user-choice';
import { MatDialog } from '@angular/material/dialog';
 


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private clientSelectionService: UserSelectionService,
    public dialog: MatDialog) {
this.setDefaultFieldsValue();
this.disableBuy = true;
}


selectedDrinkTypeId: number;
sugarQty: number;
useOwnerMug: boolean;
badgeNumber: string;

updateSelection: boolean;
disableBuy: boolean;

updateBadgeNumber(badgeNumber: string) {
  if (badgeNumber === '') {
    this.disableBuy = true;
    this.setDefaultFieldsValue();
    return;
  }

  this.disableBuy = false;
  this.badgeNumber = badgeNumber;
  this.setDefaultFieldsValue();

  this.clientSelectionService.getClientSelection(this.badgeNumber)
  .subscribe(data => {
    this.setClientSelectionFields(data as UserChoice);
    this.updateSelection = true;
  },
  error => console.log('no previous selection from this client'));
}

saveSelection()
{
  const clientSelection = this.getClientSelectionFromFields();

  if (!this.updateSelection) {
    this.clientSelectionService.SaveClientSelection(clientSelection)
      .subscribe(data => {
        
    });
  }
  else {
    this.clientSelectionService.UpdateClientSelection(clientSelection)
    .subscribe(data => {
      
   });
  }
}

 

drinkTypeChange(id: number) {
  this.selectedDrinkTypeId = id;
}

setClientSelectionFields(userChoice: UserChoice) {
    this.selectedDrinkTypeId = userChoice.drinkTypeId;
    this.useOwnerMug = userChoice.usePersonalMug;
    this.sugarQty = userChoice.sugarQuantity;
}

getClientSelectionFromFields(): UserChoice {
  const clientSelection = new UserChoice();
  clientSelection.badgeNumber = this.badgeNumber;
  clientSelection.drinkTypeId = this.selectedDrinkTypeId;
  clientSelection.usePersonalMug = this.useOwnerMug;
  clientSelection.sugarQuantity = Number(this.sugarQty);
  return clientSelection;
}

setDefaultFieldsValue() {
  this.sugarQty = 0;
  this.useOwnerMug = false;
  this.updateSelection = false;
  this.selectedDrinkTypeId = 0;
}
}
