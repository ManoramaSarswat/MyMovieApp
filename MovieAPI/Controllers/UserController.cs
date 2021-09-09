// using MovieAPI.MovieData;
// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using MovieAPI.Models;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;

// namespace MovieAPI.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class UserController : ControllerBase
//     {
//         private readonly MovieContext _movieContext;

//         public UserController(MovieContext context)
//         {
//             _movieContext = context;
//         }

//         [HttpPost]
//         public async Task<ActionResult<IEnumerable<User>>> GetUser()
//         {
//             return await _movieContext.Users.ToListAsync();
//         }
//     }
// }