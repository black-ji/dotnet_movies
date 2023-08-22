using MediatR;
using movies.application.Responses;

namespace movies.application.Queries;

public class GetMoviesByDirectorNameQuery : IRequest<IEnumerable<MovieResponse>>
{
    public string DirectorName { get; set; }

    public GetMoviesByDirectorNameQuery(string directorName)
    {
        DirectorName = directorName;
    }
}