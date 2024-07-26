using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("Book")]
public class Book 
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Título do livro")]
    [Required(ErrorMessage = "Por favor, digite o Título do livro.")]
    [StringLength(50, ErrorMessage = "O nome do livro deve possuir no máximo 50 caracteres.")]
    public string Title { get; set; }

    [Display(Name = "Ano da publicação")]
    [Required(ErrorMessage = "Por favor, digite o ano de publicação do livro.")]
    public int YearPublication { get; set; }

    [Display(Name = "Sinopse")]
    [Required(ErrorMessage = "Por favor, digite a sinopse do livro.")]
    public string Synopsis { get; set; }

    [Display(Name = "Link de pdf do livro")]
    [Required(ErrorMessage = "Por favor, atribua um link de pdf para o livro.")]
    public string PdfLink { get; set; }

    [Display(Name = "Imagem da capa do livro")]
    [Required(ErrorMessage = "Por favor, atribua uma url(capa) do livro.")]
    public string BookImage { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o livro está ativo ou não.")]
    public bool Active { get; set; }

    public virtual ICollection<Chapter>? Chapters { get; set; } 
    public ICollection<Favorite> Favorite { get; set; }
    public ICollection<GenreBook> GenreBook { get; set; }
    public ICollection<AuthorBook> AuthorBook { get; set; }
}
