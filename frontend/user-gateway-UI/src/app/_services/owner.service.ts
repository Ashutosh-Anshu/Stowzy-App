import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OwnerService {
  baseUrl = environment.apiUrl + 'Account/';
  constructor(private httpClient: HttpClient) { }


  ownerRegistration(data: FormData): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}registerOwner`, data);
  }
  
  

}