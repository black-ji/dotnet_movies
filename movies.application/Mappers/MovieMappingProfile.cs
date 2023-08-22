using AutoMapper;
using movies.application.Commands;
using movies.application.Responses;
using movies.core.Entities;

namespace movies.application.Mappers;

public class MovieMappingProfile : Profile
{
    public MovieMappingProfile()
    {
        CreateMap<Movie, MovieResponse>().ReverseMap();
        CreateMap<Movie, CreateMovieCommand>().ReverseMap();
    }
}