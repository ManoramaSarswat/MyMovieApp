using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.MovieData
{
    public class MovieContext : DbContext
    {
         public MovieContext(DbContextOptions options) : base(options)
         {

         }

         public DbSet<MovieModel> Movies { get; set; }
    }
}