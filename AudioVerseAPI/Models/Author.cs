﻿ using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

[Table("Author")]
public class Author
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do autor")]
    [Required(ErrorMessage = "Por favor, informe o nome do autor.")]
    [StringLength(30, ErrorMessage = "O nome do autor deve possuir no máximo 30 caracteres.")]
    public string AuthorName { get; set; }

    [Display(Name = "Ano de nascimento")]
    [Required(ErrorMessage = "Por favor, informe o ano de nascimento do autor.")]
    public int YearBirth { get; set; }

    [Display(Name = "Ano de falecimento")]
    [Required(ErrorMessage = "Por favor, informe o ano de falecimento do autor.")]
    public int YearDeath { get; set; }

    [Display(Name = "Biografia")]
    [Required(ErrorMessage = "Por favor, informe a biografia do autor.")]
    public string Biography { get; set; }

    [Display(Name = "Ativo")]
    [Required(ErrorMessage = "Por favor, informe se o autor está ativo ou não.")]
    public bool Active { get; set; }
    [JsonIgnore]
    public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
}