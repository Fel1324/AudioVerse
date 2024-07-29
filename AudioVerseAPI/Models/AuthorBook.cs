namespace AudioVerseAPI.Models;

public class AuthorBook
{
    public int? BookId { get; set; }
    public virtual Book Book { get; set; }
    public int? AuthorId { get; set; }
    public virtual Author Author { get; set; }
}
