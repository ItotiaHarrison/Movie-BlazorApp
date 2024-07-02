using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieBlazorApp.Data;

namespace MovieBlazorApp.Data
{
    public class MovieBlazorAppContext(DbContextOptions<MovieBlazorAppContext> options) : IdentityDbContext<MovieBlazorAppUser>(options)
    {
        public DbSet<MovieBlazorApp.Movie> Movie { get; set; } = default!;
    }
}
