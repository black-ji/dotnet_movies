using MediatR;
using movies.application.Commands;
using movies.application.Mappers;
using movies.application.Responses;
using movies.core.Entities;
using movies.core.Repositories;

namespace movies.application.Handlers;

public class CreateMovieCommandHandler: IRequestHandler<CreateMovieCommand, MovieResponse>
{
    private readonly IMovieRepository _movieRepository;

    public CreateMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public async Task<MovieResponse> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var movieEntity = MovieMapper.Mapper.Map<Movie>(request);
        if (movieEntity is null)
        {
            throw new ApplicationException("There is an issue with mapping...");
        }

        var newMovie = await _movieRepository.AddAsyncc(movieEntity);
        var movieResponse = MovieMapper.Mapper.Map<MovieResponse>(newMovie);
        return movieResponse;
    }
}