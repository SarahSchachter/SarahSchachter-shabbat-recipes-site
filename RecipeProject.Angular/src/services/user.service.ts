import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../interfaces/user.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  url: string = "https://localhost:7261/api/User"
  constructor(private httpc: HttpClient) { }

  user: User = {
    id: 0,
    fname: "",
    lname: "",
    email: "",
    password: ""
  };

  current_user: User = {
    id: 0,
    fname: "",
    lname: "",
    email: "",
    password: ""
  };
  setUser(user: User) {
    this.current_user = user;
  }

  getById(email: string, password: string): Observable<User> {
    return this.httpc.get<User>(`${this.url}/${email}/${password}`)
  }


  addUser(user: User): Observable<void> {
    return this.httpc.post<void>(this.url, user);
  }

}




