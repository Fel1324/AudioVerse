using AudioVerseAPI.Data;
using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{

    private AudioVerseContext _context;

    public AuthorController(AudioVerseContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddAuthor([FromBody] Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverAuthorById),
            new { id = author.Id },
            author);
    }

    [HttpGet]
    public IEnumerable<Author> RecoverAuthor([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.Authors.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverAuthorById(int id)
    {
        var author = _context.Authors.FirstOrDefault(author => author.Id == id);
        if (author == null) return NotFound();
        return Ok(author);
    }
}

