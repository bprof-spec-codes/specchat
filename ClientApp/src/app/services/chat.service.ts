import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Chat } from '../models/chat';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class ChatService {
  private url = "api/Chat";
  constructor(private http: HttpClient) { }

  public getChat() : Observable<Chat[]> {
    return this.http.get<Chat[]>(`${environment.baseApiUrl}/${this.url}`);
  }
}
