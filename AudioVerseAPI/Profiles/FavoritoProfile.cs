using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class FavoritoProfile : Profile
{
    public FavoritoProfile()
    {
        CreateMap<CreateFavoritoDto, Favorito>();
        CreateMap<Favorito, ReadFavoritoDto>();
    }
}
