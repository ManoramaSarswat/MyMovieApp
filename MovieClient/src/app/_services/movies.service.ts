import { HttpClient, HttpHeaders } from '@angular/common/http';
import { CoreEnvironment } from '@angular/compiler/src/compiler_facade_interface';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Movie } from '../_models/movie';

// const httpOptions = {
//   headers: new HttpHeaders({
//     Authorization: 'Bearer ' + JSON.parse(localStorage.getItem('movie')).token
//   })
// }

@Injectable({
  providedIn: 'root'
})
export class MoviesService {
  baseUrl = environment.apiurl;

  constructor(private http: HttpClient) { }

  getMovies(): Observable<Movie[]>{
    return this.http.get<Movie[]>(this.baseUrl + 'movies');
  }

  getMovie(id: BigInteger): Observable<Movie>{
    return this.http.get<Movie>(this.baseUrl + 'movies/' + id);
  }
}
