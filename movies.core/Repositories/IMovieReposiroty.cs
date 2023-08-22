using movies.core.Entities;
using movies.core.Repositories.Base;

namespace movies.core.Repositories;

public interface IMovieRepository:IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetMovieByDirectorName(string directorName);
}