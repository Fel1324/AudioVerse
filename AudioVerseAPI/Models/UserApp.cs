using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Models;

[Table("UserApp")]
public class UserApp : IdentityUser
{
    public int Id {  get; set; }
    public string Token { get; set; }


    public ICollection<Favorito> Favoritos { get; set; }
}
