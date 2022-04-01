using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieFlix.Data;
using MovieFlix.Data.DTO;
using MovieFlix.Models;

namespace MovieFlix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        // com o banco
        private MovieContext _context;
        private IMapper _mapper;

        // iniciando o meu context atraves de um construtor
        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /* sem o banco
         private static List<Movie> movies = new List<Movie>();
         private static int id = 1;
        */

        [HttpPost]
        public IActionResult addMovie([FromBody] CreateMovieDTO movieDTO)
        {
            /* sem banco
            movie.Id = id++;
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
            */

            Movie movie = _mapper.Map<Movie>(movieDTO);

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }


        [HttpGet]
        public IActionResult GetMovies()
        {
            // sem o banco
            //return Ok(movies);

            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            // sem banco
            //Movie movie = movies.FirstOrDefault(m => m.Id == id); // modo usual
            Movie movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
           {
                MovieDTO movieDTO = _mapper.Map<MovieDTO>(movie);
              return Ok(movieDTO);
           }
               
           return NotFound();
          
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] CreateMovieDTO newMovie)
        {
            Movie movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            _mapper.Map(newMovie, movie); // pegando as informações do meu dto para o meu filme
           // movie.Name = newMovie.Name;
            // movie.Genre = newMovie.Genre;
            // movie.Duration = newMovie.Duration;
            _context.SaveChanges();
            return NoContent();
            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
                Movie movie = _context.Movies.FirstOrDefault(m => m.Id == id);
                if (movie == null)
                {
                    return NotFound(movie);
                }
            _context.Remove(movie);
            _context.SaveChanges();
            return NoContent();
            }
    }
}
