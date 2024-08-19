using System.ComponentModel.DataAnnotations;

namespace AudioVerseAPI.Data.Dtos;

public class UpdateChapterDto
{
    [Display(Name = "Nome do capítulo")]
    [Required(ErrorMessage = "O Nome do capítulo deve ser preenchido.")]
    [StringLength(60, ErrorMessage = "O nome do capítulo deve conter no máximo 60 caracteres")]
    public string ChapterName { get; set; }

    [Display(Name = "Url do capítulo")]
    [Required(ErrorMessage = "A url do capítulo deve ser preenchida")]
    public string ChapterUrl { get; set; }

    [Display(Name = "Leitor do Capítulo")]
    [Required(ErrorMessage = "O leitor do capítulo é obrigatorio")]
    public string Reader { get; set; }

    public int BookId { get; set; }
}
