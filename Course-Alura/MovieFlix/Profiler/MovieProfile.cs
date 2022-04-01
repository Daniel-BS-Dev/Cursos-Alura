using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MovieFlix.Data.DTO;
using MovieFlix.Models;

namespace MovieFlix.Profiler
{



    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieDTO, Movie>();
            CreateMap<Movie, MovieDTO>();
        }
    }
}
