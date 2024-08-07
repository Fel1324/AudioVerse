﻿using AudioVerseAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class ReadAuthorDto
{
    public int Id { get; set; }
    public string? AuthorName { get; set; }

    public int YearBirth { get; set; }

    public int YearDeath { get; set; }

    public string? Biography { get; set; }

    public bool Active { get; set; }
    public ICollection<ReadAuthorBookDto> AuthorBooks { get; set; }
}
