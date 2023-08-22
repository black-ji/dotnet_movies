using MediatR;
using movies.application.Responses;

namespace movies.application.Commands;

public class CreateMovieCommand : IRequest<MovieResponse>
{
    public string MovieName { get; set; }
    public string DirectorName { get; set; }
    public string ReleaseYear { get; set; }
}