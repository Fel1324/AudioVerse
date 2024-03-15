using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do gênero")]
    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    [StringLength(20, ErrorMessage = "O gênero deve possuir no máximo 20 caracteres")]
    public  string? GenreName { get; set; }

    public ICollection<GenreBook>? GenreBooks { get; set; }
}
