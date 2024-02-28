using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerse.Models;

[Table("Author")]
public class Author
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome do autor.")]
    [StringLength(30, ErrorMessage = "O nome do autor deve possuir no máximo 30 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Por favor, informe o ano de nascimento do autor.")]
    [StringLength(4, ErrorMessage = "O ano deve ter 4 caracteres")]
    public int YearBirth { get; set; }

    [Required(ErrorMessage = "Por favor, informe o ano de falecimento do autor.")]
    [StringLength(4, ErrorMessage = "O ano deve ter 4 caracteres")]
    public int YearDeath { get; set; }

    [Required(ErrorMessage = "Por favor, informe a biografia do autor.")]
    public string Biography { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o autor está ativo ou não.")]
    public bool Active { get; set; }
}