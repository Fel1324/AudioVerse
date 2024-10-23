using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class CreateFavoritoDto
{
    public int UserAppId { get; set; }
    public int BookId { get; set; }
}
