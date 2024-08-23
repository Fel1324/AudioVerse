using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

namespace AudioVerseAPI.Profiles;

public class FavoritoProfile()
{
    CreateMap<CreateFavoritoDto, Favorito>();
    CreateMap<Favorito, ReadFavoritoDto>();
}
