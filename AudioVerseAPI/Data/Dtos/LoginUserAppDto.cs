using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class LoginUserAppDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
