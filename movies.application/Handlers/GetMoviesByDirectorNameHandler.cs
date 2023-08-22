using MediatR;
using movies.application.Mappers;
using movies.application.Queries;
using movies.application.Responses;
using movies.core.Repositories;

namespace movies.application.Handlers;

public class GetMoviesByDirectorNameHandler:  IRequestHandler<GetMoviesByDirectorNameQuery, IEnumerable<MovieResponse>>
{
    private readonly IMovieRepository _movieRepository;

    public GetMoviesByDirectorNameHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public async Task<IEnumerable<MovieResponse>> Handle(GetMoviesByDirectorNameQuery request, CancellationToken cancellationToken)
    {
        var movieList = await _movieRepository.GetMovieByDirectorName(request.DirectorName);
        var movieResponseList = MovieMapper.Mapper.Map<IEnumerable<MovieResponse>>(movieList);
        return movieResponseList;
    }
}