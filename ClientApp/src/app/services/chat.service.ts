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

  addNewChat(chat: Chat): Observable<void> {
    return this.http.post<void>(`${environment.baseApiUrl}/${this.url}/addNewChat`, chat);
  }

  deleteChat(id: string): Observable<void> {
    return this.http.delete<void>(`${environment.baseApiUrl}/${this.url}/deleteChat/${id}`);
  }

  getAllChats(): Observable<Chat[]> {
    return this.http.get<Chat[]>(`${environment.baseApiUrl}/${this.url}/getAll`);
  }

  getChatById(id: string): Observable<Chat> {
    return this.http.get<Chat>(`${environment.baseApiUrl}/${this.url}/getById/${id}`);
  }

  updateChat(chat: Chat): Observable<void> {
    return this.http.put<void>(`${environment.baseApiUrl}/${this.url}/updateChat`, chat);
  }
}
