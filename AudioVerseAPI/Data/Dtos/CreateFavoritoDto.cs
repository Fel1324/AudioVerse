using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class CreateFavoritoDto
{
    public string? UserAppId { get; set; }
    public int BookId { get; set; }
    public DateTime? DateAdded { get; set; } = DateTime.Now;
}
