import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { User } from '../_models/user';
import { LoginModel } from '../_models/viewmodels/loginmodel';
import { RegisterModel } from '../_models/viewmodels/registermodel';
import { Token } from '../_models/viewmodels/token';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private url = 'Auth';
  constructor(private http: HttpClient) { }
  
  login(loginModel: LoginModel): Observable<Token> {
    return this.http.post<Token>(`${environment.baseApiUrl}/${this.url}/Login`, loginModel);
  }
  
  register(registermodel: RegisterModel): Observable<any> {
    console.log(registermodel);
    return this.http.put<any>(`${environment.baseApiUrl}/${this.url}/InsertUser`, registermodel);
  }

  getUserInfo(): Observable<User> {
    return this.http.get<User>(`${environment.baseApiUrl}/${this.url}/GetUserInfos`);
  }

  updateUserInfo(user: any): Observable<any> {
    return this.http.post(`${environment.baseApiUrl}/${this.url}/Update`, user);
  }

  deleteAccount(): Observable<any> {
    return this.http.delete(`${environment.baseApiUrl}/${this.url}/DeleteMyself`);
  }

  getUserById(id: string): Observable<User> {
    return this.http.get<User>(`${environment.baseApiUrl}/${this.url}/GetById/${id}`);
  }

  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${environment.baseApiUrl}/${this.url}/GetUsers`);
  }
}
