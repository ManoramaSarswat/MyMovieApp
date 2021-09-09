import { Component, Input, OnInit } from '@angular/core';
import { Movie } from 'src/app/_models/movie';
import {MatCardModule} from '@angular/material/card';
@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.css']
})
export class MovieCardComponent implements OnInit {
@Input() movie: any;
  constructor() {
   }

  ngOnInit(): void {
    console.log(this.movie);
  }

}
