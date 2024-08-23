﻿using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class UpdateFavoritoDto
{
    public int BookId { get; set; }
    public Book? Book { get; set; }

    public int UserAppId { get; set; }
    public UserApp? UserApp { get; set; }
}
