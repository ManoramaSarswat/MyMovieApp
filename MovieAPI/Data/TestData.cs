using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MovieAPI.MovieData;

namespace MovieAPI.Data
{
    public class TestData
    {
        public static async Task SeedMovies(MovieContext context)
        {
            if (await context.Movies.AnyAsync()) return;

            var movieData = System.IO.File.ReadAllText("Data/movies.json");
            var movies = JsonSerializer.Deserialize<Movies>(movieData);
            foreach (var movie in movies.movies)
            {
                var idIncrement = 1;
                // movie.Id = idIncrement;
                // movie.Language = movie.Language;
                // movie.Location = movie.Location;
                // movie.Plot = movie.Plot;
                // movie.Poster = movie.Poster;
                // movie.imdbID = movie.imdbID;
                // movie.imdbRating = movie.imdbRating;
                 movie.MovieName = movie.Title;
                // movie.Title = movie.Title;
                // movie.listingType = movie.listingType;
                // movie._soundEffects = movie._soundEffects;
                // movie._stills = movie._stills;
               // context.Movies.Add(movie);

                idIncrement++;
            }

            await context.Movies.AddRangeAsync(movies.movies);
            await context.SaveChangesAsync();
        }
    }
}