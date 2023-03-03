import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../interface/user.interface';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  private URL = 'https://api.github.com/users';


  getInfoUser(username: string) {
    return this.http.get<User>(`${this.URL}/${username}`);
  }
}
