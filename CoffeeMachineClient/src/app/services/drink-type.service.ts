import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DrinkType } from '../models/DrinkType';

@Injectable({
  providedIn: 'root'
})

export class DrinkTypeService {
  constructor(private http: HttpClient) { }

  public getAllDrinktypes() {
    return this.http.get<DrinkType[]>('http://localhost:6120/api' + '/DrinkTypes');
  }
}
