import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BadgeService {

  constructor(private http: HttpClient) { }

  public getOwner(badgeNumber){
    return this.http.get('http://localhost:6120/api/Badges/GetOwner/' + badgeNumber, { responseType: 'text' });
  }
}
