import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.apiurl;

  constructor(private http: HttpClient) { }
  login(model: any){
    return this.http.post(this.baseUrl + 'movies', model);
  }
}
