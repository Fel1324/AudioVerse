using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : ControllerBase
{

    private static List<Genre> genres = new List<Genre>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AddGenre([FromBody] Genre genre)
    {
        genre.Id = id++;
        genres.Add(genre);
        return CreatedAtAction(nameof(RecoverGenreById),
            new { id = genre.Id },
            genre);
    }

    [HttpGet]
    public IEnumerable<Genre> RecoverGenre([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return genres.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverGenreById(int id)
    {
        var genre = genres.FirstOrDefault(genre => genre.Id == id);
        if (genre == null) return NotFound();
        return Ok(genre);
    }
}

