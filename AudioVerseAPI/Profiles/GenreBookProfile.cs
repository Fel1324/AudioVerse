using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class GenreBookProfile : Profile
{
    public GenreBookProfile()
    {
        CreateMap<CreateGenreBookDto, GenreBook>();
        CreateMap<GenreBook, ReadGenreBookDto>();
    }
}
