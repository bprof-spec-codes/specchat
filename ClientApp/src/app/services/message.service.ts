import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Message } from '../models/message';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class MessageService {
  private url = "api/Message";
  constructor(private http: HttpClient) { }

  addNewMessage(message: Message): Observable<void> {
    return this.http.post<void>(`${environment.baseApiUrl}/${this.url}`, message);
  }

  deleteMessage(id: string): Observable<void> {
    return this.http.delete<void>(`${environment.baseApiUrl}/${this.url}/${id}`);
  }

  getAll(): Observable<Message[]> {
    return this.http.get<Message[]>(`${environment.baseApiUrl}/${this.url}`);
  }

  getById(id: string): Observable<Message> {
    return this.http.get<Message>(`${environment.baseApiUrl}/${this.url}/${id}`);
  }

  updateMessage(message: Message): Observable<void> {
    return this.http.put<void>(`${environment.baseApiUrl}/${this.url}`, message);
  }
}
