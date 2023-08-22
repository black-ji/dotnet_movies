using Microsoft.EntityFrameworkCore;
using movies.core.Entities;

namespace movies.infrastructure.Data;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options): base(options)
    {
        
    }

    public DbSet<Movie> Movies {get; set;}
}