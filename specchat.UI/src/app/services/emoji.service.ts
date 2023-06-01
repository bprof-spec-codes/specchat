import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Emoji } from '../_models/emoji';


@Injectable({
  providedIn: 'root'
})
export class EmojiService {
  private url = "api/Emoji";
  
  constructor(private http: HttpClient) { }

  addNewEmoji(emoji: Emoji) {
    return this.http.post(`${environment.baseApiUrl}/${this.url}`, emoji);
  }

  deleteEmoji(id: string): Observable<void> {
    return this.http.delete<void>(`${environment.baseApiUrl}/${this.url}/${id}`);
  }

  getAll(): Observable<Emoji[]> {
    return this.http.get<Emoji[]>(`${environment.baseApiUrl}/${this.url}`);
  }

  getById(id: string): Observable<Emoji[]> {
    return this.http.get<Emoji[]>(`${environment.baseApiUrl}/${this.url}/${id}`);
  }

}
