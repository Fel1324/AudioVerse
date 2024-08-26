﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do gênero")]
    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    [StringLength(20, ErrorMessage = "O gênero deve possuir no máximo 20 caracteres")]
    public string GenreName { get; set; }

    [JsonIgnore]
    public ICollection<GenreBook> GenreBooks { get; set; }
}
