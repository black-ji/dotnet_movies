using Microsoft.EntityFrameworkCore;
using movies.core.Entities;
using movies.core.Repositories;
using movies.infrastructure.Data;
using movies.infrastructure.Repositories.Base;

namespace movies.infrastructure.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(MovieContext movieContext) : base(movieContext){}

    public async Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName)
    {
        return await _movieContext.Movies
            .Where(m => m.DirectorName == directorName)
            .ToListAsync();
    }

    Task<IEnumerable<Movie>> IMovieRepository.GetMovieByDirectorName(string directorName)
    {
        throw new NotImplementedException();
    }
}