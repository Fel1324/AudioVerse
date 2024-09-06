using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class ReadFavoritoDto
{
    public int Id { get; set; } 
    public string BookTitle { get; set; }
    public string UserName { get; set; }
}
