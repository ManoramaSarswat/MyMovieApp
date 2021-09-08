using MovieAPI.MovieData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MovieAPI.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _movieContext;

        public MoviesController(MovieContext context)
        {
            _movieContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieModel>>> GetMovies()
        {
            return await _movieContext.Movies.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<MovieModel>> GetMovie(int id)
        {
            return await _movieContext.Movies.FindAsync(id);
        }
    }
}