
// Unused usings removed.

using Microsoft.EntityFrameworkCore;

using HT.IMS.WebApp.Models;  // Enables public DbSet<Movie> Movie

namespace HT.IMS.WebApp.Data
{
    public class MvcMovieContext : DbContext

    {

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)

            : base(options)

        {

        }



        public DbSet<Movie> Movie { get; set; }

    }
}
