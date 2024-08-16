using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

[Table("AuthorBook")]
public class AuthorBook
{
    public int? BookId { get; set; }
    [JsonIgnore]
    public Book Book { get; set; }
    public int? AuthorId { get; set; }
    [JsonIgnore]
    public Author Author { get; set; }
}
