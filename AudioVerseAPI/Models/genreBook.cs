using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

[Table("GenreBook")]
public class GenreBook
{
    public int BookId { get; set; }
    [JsonIgnore]
    [ForeignKey("BookId")]
    public Book? Book { get; set; }
    public int GenreId { get; set; }
    [JsonIgnore]
    [ForeignKey("GenreId")]
    public Genre? Genre { get; set; }
}
