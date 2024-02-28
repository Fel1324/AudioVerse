using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    public  string NameGenre { get; set; }
}
