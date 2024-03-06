﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AudioVerse.Models;

namespace AudioVerseAPI.Models;

[Table("Favoritos")]
public class Favoritos
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Usuario")]
    [Required(ErrorMessage = "Por favor, informe o nome de usuario")]
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "Por favor, informe o nome do livro")]
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}
