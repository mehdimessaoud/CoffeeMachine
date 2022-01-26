import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { BadgeComponent } from './Components/badge/badge.component';
import { HttpClientModule } from '@angular/common/http';
import { DrinkTypeSelectionComponent } from './Components/drink-type-selection/drink-type-selection.component';
import { DrinkTypeComponent } from './Components/drink-type/drink-type.component';
import { DrinkTypeService } from './services/drink-type.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDividerModule} from '@angular/material/divider';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatChipsModule} from '@angular/material/chips';
import {MatInputModule} from '@angular/material/input';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatDialogModule} from '@angular/material/dialog';
 
@NgModule({
  declarations: [
    AppComponent,
    BadgeComponent,
    DrinkTypeSelectionComponent,
    DrinkTypeComponent,
   
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatCheckboxModule, 
    MatDividerModule,
    MatButtonModule,
    MatIconModule,
    MatChipsModule,
    MatInputModule,
    MatTooltipModule,
    MatDialogModule
     
  ],
  providers: [DrinkTypeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
 