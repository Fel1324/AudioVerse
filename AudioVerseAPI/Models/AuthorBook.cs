﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("AuthorBook")]
public class AuthorBook
{
    public int? BookId { get; set; }
    public Book Book { get; set; }
    public int? AuthorId { get; set; }
    public Author Author { get; set; }
}
