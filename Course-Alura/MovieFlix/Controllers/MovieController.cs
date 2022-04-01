using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieFlix.Models;

namespace MovieFlix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>();
        private static int id = 1;

        [HttpPost]
        public void addMovie([FromBody] Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);

        }


        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            
           Movie movie = movies.FirstOrDefault(m => m.Id == id); // modo usual
           if(movie != null)
           {
              return Ok(movie);
           }
               
           return NotFound();
          
        }
    }
}
