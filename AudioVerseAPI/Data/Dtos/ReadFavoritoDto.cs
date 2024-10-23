using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class ReadFavoritoDto
{
    public int BookId { get; set; }
    public int UserAppId { get; set; }

    public ICollection<Favorito> Favoritos { get; set;}
}
