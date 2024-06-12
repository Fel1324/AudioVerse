using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class UserAppProfile : Profile
{
    public UserAppProfile()
    {
        CreateMap<CreateUserAppDto, UserApp>();
    }
}
