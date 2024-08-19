using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class ReadChapterDto
{
    public string? ChapterName { get; set; }
    public string? ChapterUrl { get; set; }
    public string Reader { get; set; }

    public int BookId { get; set; }
}
