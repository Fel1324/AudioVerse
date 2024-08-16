using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

[Table("GenreBook")]
public class GenreBook
{
    public int? BookId { get; set; }
    [JsonIgnore]
    public Book Book { get; set; }
    public int? GenreId { get; set; }
    [JsonIgnore]
    public Genre Genre { get; set; }
}
