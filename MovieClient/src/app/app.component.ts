import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Movie Finder';
  movies: any;
  baseUrl = environment.apiurl;
  loggedIn: boolean = false;

  constructor(private http: HttpClient) {}
  ngOnInit() {
      this.getMovies();
  }

  getMovies()
  {
    this.http.get(this.baseUrl + 'Movies').subscribe(response => {
      this.movies = response;
      console.log(response);

    },
      error =>
      {
          console.log(error);
      })
  }

  logIn()
  {
    this.http.get(this.baseUrl + 'user').subscribe(response => {
      this.loggedIn = true;
    },
    error => {
      console.log(error);
    })
  }
}
