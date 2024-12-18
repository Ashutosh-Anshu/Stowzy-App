import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { RoomOwner } from '../_model/RoomOwner/room-owner';
import { Observable } from 'rxjs';
import { RoomOwnerRegistration } from '../_model/RoomOwner/room-details';

@Injectable({
  providedIn: 'root'
})
export class RoomOwnerService {
  baseUrl = environment.apiUrl + 'Account/';
  constructor(private httpClient: HttpClient) { }


  roomOwnerRegistration(data: FormData): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}registerRoomOwner`, data);
  }
  
  

}