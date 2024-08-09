using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Models;

[Table("UserApp")]
public class UserApp : IdentityUser
{

}
