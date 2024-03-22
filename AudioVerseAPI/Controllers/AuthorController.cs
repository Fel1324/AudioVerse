using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{

    private static List<Author> authors = new List<Author>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AddAuthor([FromBody] Author author)
    {
        author.Id = id++;
        authors.Add(author);
        return CreatedAtAction(nameof(RecoverAuthorById),
            new { id = author.Id },
            author);
    }

    [HttpGet]
    public IEnumerable<Author> RecoverAuthor([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return authors.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverAuthorById(int id)
    {
        var author = authors.FirstOrDefault(author => author.Id == id);
        if (author == null) return NotFound();
        return Ok(author);
    }
}

