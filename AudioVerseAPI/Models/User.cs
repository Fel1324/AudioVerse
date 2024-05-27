﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Models;

[Table("User")]
public class User : IdentityUser
{

    public ICollection<Favorite>? Favorite { get; set; }
}
