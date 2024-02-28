using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerse.Models;

[Table("Book")]
public class Book 
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }

    public int YearPublication { get; set; }

    public string Synopsis { get; set; }

    public string PdfLink { get; set; }

    public string BookImage { get; set; }

    public bool Active { get; set; }
}
