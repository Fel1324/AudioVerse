﻿using AudioVerseAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class ReadBookDto
{
    public string? Title { get; set; }

    public int YearPublication { get; set; }

    public string? Synopsis { get; set; }

    public string? PdfLink { get; set; }

    public string? BookImage { get; set; }

    public bool Active { get; set; }

    public ICollection<Favorite>? Favorite { get; set; }
    public ICollection<GenreBook>? GenreBook { get; set; }
    public ICollection<AuthorBook>? AuthorBook { get; set; }
}
