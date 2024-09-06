﻿using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class CreateFavoritoDto
{
    public int BookId { get; set; }
    public int Title { get; set; }
    public string BookImage { get; set; }
    public int UserAppId { get; set; }
}
