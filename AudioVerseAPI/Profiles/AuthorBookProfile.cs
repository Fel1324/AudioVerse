using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class AuthorBookProfile : Profile
{
    public AuthorBookProfile() 
    {
        CreateMap<CreateAuthorBookDto, AuthorBook>();
        CreateMap<AuthorBook, ReadAuthorBookDto>();
    }
}
