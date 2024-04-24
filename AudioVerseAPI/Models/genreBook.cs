using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("GenreBook")]
public class GenreBook
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do gênero")]
    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    public int GenreId { get; set; }
    [ForeignKey("GenreId")]
    public Genre Genre { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "Por favor, informe o nome do livro")]
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}
