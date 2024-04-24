using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("AuthorBook")]
public class AuthorBook
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Autor")]
    [Required(ErrorMessage = "Por favor informe o nome do autor")]
    public int AuthorId { get; set; }
    [ForeignKey("AuthorId")]
    public Author Author { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "Por favor, informe o nome do livro")]
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}
