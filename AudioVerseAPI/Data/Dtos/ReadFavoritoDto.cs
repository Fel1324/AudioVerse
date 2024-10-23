using AudioVerseAPI.Models;

namespace AudioVerseAPI.Data.Dtos;

public class ReadFavoritoDto
{
        public int UserAppId { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorBook { get; set; }
        public string GenreBook { get; set; }


    public ICollection<Favorito> Favoritos { get; set; }
}


