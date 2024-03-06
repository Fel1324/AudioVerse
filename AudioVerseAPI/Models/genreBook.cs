using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using AudioVerse.Models;

namespace AudioVerseAPI.Models;

[Table("genreBook")]
public class genreBook
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do gênero")]
    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    [StringLength(20, ErrorMessage = "O gênero deve possuir no máximo 20 caracteres")]
    public string GenreId { get; set; }
    [ForeignKey("GenreId")]
    public Genre Genre { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "Por favor, informe o nome do livro")]
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}
