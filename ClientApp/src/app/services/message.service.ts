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

  public getChat() : Observable<Message[]> {
    return this.http.get<Message[]>(`${environment.baseApiUrl}/${this.url}`);
  }
}
