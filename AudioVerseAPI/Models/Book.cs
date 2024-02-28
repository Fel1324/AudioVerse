using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerse.Models;

[Table("Book")]
public class Book 
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, digite o Título do livro.")]
    [StringLength(40, ErrorMessage = "O nome do livro deve possuir no máximo 40 caracteres.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Por favor, digite o ano de publicação do livro.")]
    [StringLength(4, ErrorMessage = "O ano deve ter 4 caracteres")]
    public int YearPublication { get; set; }

    [Required(ErrorMessage = "Por favor, digite a sinopse do livro.")]
    public string Synopsis { get; set; }

    [Required(ErrorMessage = "Por favor, atribua um link de pdf para o livro.")]
    public string PdfLink { get; set; }

    [Required(ErrorMessage = "Por favor, atribua uma url(imagem) do livro.")]
    public string BookImage { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o livro está ativo ou não.")]
    public bool Active { get; set; }
}
