using AudioVerseAPI.Data;
using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : ControllerBase
{

    private AudioVerseContext _context;

    public GenreController(AudioVerseContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddGenre([FromBody] Genre genre)
    {
        _context.Genres.Add(genre);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverGenreById),
            new { id = genre.Id },
            genre);
    }

    [HttpGet]
    public IEnumerable<Genre> RecoverGenre([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.Genres.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverGenreById(int id)
    {
        var genre = _context.Genres.FirstOrDefault(genre => genre.Id == id);
        if (genre == null) return NotFound();
        return Ok(genre);
    }
}

