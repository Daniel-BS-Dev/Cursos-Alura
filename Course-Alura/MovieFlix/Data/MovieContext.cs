using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieFlix.Models;

namespace MovieFlix.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt): base(opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
