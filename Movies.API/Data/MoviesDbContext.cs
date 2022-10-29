using Microsoft.EntityFrameworkCore;
using Movies.API.Models.Domain;

namespace Movies.API.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movies{ get; set; }

        public DbSet<Genre> Genres{ get; set; }

        public DbSet<Actors> Actors{ get; set; }

    }
}
