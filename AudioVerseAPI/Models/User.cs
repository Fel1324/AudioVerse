using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("User")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome do usuário")]
    [Required(ErrorMessage = "O nome do usuário deve ser preenchido")]
    [StringLength(35, ErrorMessage = "O nome do usuário deve conter no máximo 35 caracteres")]
    public string? UserName { get; set; }

    [Display(Name = "Email do usuário")]
    [Required(ErrorMessage = "O email do usuário deve ser preenchido")]
    [StringLength(80, ErrorMessage = "O email deve conter no máximo 80 caracteres")]
    public string? Email { get; set; }

    [Display(Name = "Senha")]
    [Required(ErrorMessage = "A senha do usuário deve ser preenchida")]
    [StringLength(50, ErrorMessage = "A senha deve conter no máximo 50 caracteres")]
    public string? Password { get; set; }

    [Display(Name = "data de nascimento")]
    [Required(ErrorMessage = "O data de nascimento do usuário deve ser preeenchido")]
    [StringLength(8, ErrorMessage = "A data de nascimento deve conter no máximo 8 caracteres")]
    public DateTime YearBirth { get; set; }

    public ICollection<Favorite>? Favorite { get; set; }
}
