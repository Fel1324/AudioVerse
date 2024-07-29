using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<CreateAuthorDto, Author>();
        CreateMap<Author, ReadAuthorDto>()
            .ForMember(authorDto => authorDto.AuthorBooks,
                opt => opt.MapFrom(author => author.AuthorBooks));
        CreateMap<UpdateAuthorDto, Author>();
    }
}
