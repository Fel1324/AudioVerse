﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using AudioVerse.Models;

namespace AudioVerseAPI.Models;

public class authorBook
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Autor")]
    [Required(ErrorMessage = "Por favor informe o nome do autor")]
    public int AuthorId { get; set; }
    [ForeignKey("AuthorId")]
    public User User { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "Por favor, informe o nome do livro")]
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}