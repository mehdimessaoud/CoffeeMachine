import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { UserChoice } from '../models/user-choice'; 
import { retry, catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserSelectionService {

  constructor(private http: HttpClient) { }

  public getClientSelection(badgeNumber) {
    return this.http.get<UserChoice>('http://localhost:6120/api/UserSelections/GetUserSelection/' + badgeNumber)
    .pipe(
      catchError((err) => {
        console.log('error caught in service');
        console.error(err);
        return throwError(err);
      })
    );
  }

  public SaveClientSelection(UserChoice: UserChoice){
    return this.http.post('http://localhost:6120/api/UserSelections', UserChoice);
  }

  public UpdateClientSelection(UserChoice: UserChoice){
    return this.http.put('http://localhost:6120/api/UserSelections', UserChoice);
  }
}
