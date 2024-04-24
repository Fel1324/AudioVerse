using AudioVerseAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class CreateGenreDto
{
    [Display(Name = "Nome do gênero")]
    [Required(ErrorMessage = "Por favor, informe o gênero.")]
    [StringLength(20, ErrorMessage = "O gênero deve possuir no máximo 20 caracteres")]
    public string GenreName { get; set; }
}
