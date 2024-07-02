using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieBlazorApp;

namespace MovieBlazorApp.Data
{
    public class MovieBlazorAppContext : DbContext
    {
        public MovieBlazorAppContext (DbContextOptions<MovieBlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieBlazorApp.Movie> Movie { get; set; } = default!;
    }
}
