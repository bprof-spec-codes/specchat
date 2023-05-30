import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Chat } from '../_models/chat';
import { environment } from 'src/environments/environment';
import { ChatUser } from '../_models/chatuser';


@Injectable({
  providedIn: 'root'
})
export class ChatService {
  private url = "Chat";
  private url2 = "ChatUser";
  constructor(private http: HttpClient) { }

  addNewChat(chat: Chat): Observable<void> {
    return this.http.post<void>(`${environment.baseApiUrl}/${this.url}/addNewChat`, chat);
  }

  deleteChat(id: string): Observable<void> {
    return this.http.delete<void>(`${environment.baseApiUrl}/${this.url}/deleteChat/${id}`);
  }

  getAllChats(): Observable<Chat[]> {
    return this.http.get<Chat[]>(`${environment.baseApiUrl}/${this.url}`);
  }

  getChatById(id: string): Observable<Chat> {
    return this.http.get<Chat>(`${environment.baseApiUrl}/${this.url}/getById/${id}`);
  }

  updateChat(chat: Chat): Observable<void> {
    return this.http.put<void>(`${environment.baseApiUrl}/${this.url}/updateChat`, chat);
  }

  getChatsByUserId(id: string): Observable<Chat[]> {
    return this.http.get<Chat[]>(`${environment.baseApiUrl}/${this.url2}/${id}`);
  }


  addUserToChat(chatid: string, userid: string): Observable<any> {
    return this.http.post(`${environment.baseApiUrl}/${this.url2}/${chatid}/addUser/${userid}`, userid);
  }
}
