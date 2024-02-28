using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerse.Models;

[Table("Author")]
public class Author
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int YearBirth { get; set; }

    public int YearDeath { get; set; }
    
    public string Biography { get; set; }

    public bool Active { get; set; }
}