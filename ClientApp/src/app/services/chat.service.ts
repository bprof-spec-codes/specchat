import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';


@Injectable({
  providedIn: 'root'
})
export class ChatService {
  private url = "Coin";
  constructor(private http: HttpClient) { }

  
}
