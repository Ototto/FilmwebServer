using Microsoft.EntityFrameworkCore;

namespace Filmweb.Entities
{
    public class FilmwebContext : DbContext
    {
        public FilmwebContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<CastFunction> CastFunctions { get; set; }
    }
}
