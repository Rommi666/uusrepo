using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MovieApi.Models
{
    public class MovieContext: DbContext

    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; } = null;

    }
}
