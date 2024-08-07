using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("GenreBook")]
public class GenreBook
{
    public int? BookId { get; set; }
    public Book Book { get; set; }
    public int? GenreId { get; set; }
    public Genre Genre { get; set; }
}
