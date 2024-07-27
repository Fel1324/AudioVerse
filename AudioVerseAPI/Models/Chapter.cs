using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudioVerseAPI.Models;

[Table("Chapter")]
public class Chapter
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Nome do capítulo")]
    [Required(ErrorMessage = "O Nome do capítulo deve ser preenchido.")]
    [StringLength(60, ErrorMessage = "O nome do capítulo deve conter no máximo 60 caracteres")]
    public string ChapterName { get; set; }

    [Display(Name = "Url do capítulo")]
    [Required(ErrorMessage = "A url do capítulo deve ser preenchida")]
    public string ChapterUrl { get; set; }

    public int BookId { get; set; }
    public virtual Book Book { get; set; }
}
