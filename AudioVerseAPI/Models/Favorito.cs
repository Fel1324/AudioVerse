using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AudioVerseAPI.Models;

public class Favorito
{
    public int Id {get; set;}
    public int BookId { get; set; }

    [JsonIgnore]
    public Book? Book { get; set; }

    public int UserAppId { get; set; }

    [JsonIgnore]
    public UserApp? UserApp { get; set; }
}
