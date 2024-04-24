using AudioVerseAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class ReadGenreDto
{
    public string? GenreName { get; set; }
}
