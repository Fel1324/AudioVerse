using AudioVerseAPI.Data;
using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private AudioVerseContext _context;

    public BookController(AudioVerseContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverBookById),
            new { id = book.Id},
            book);
    }

    [HttpGet]
    public IEnumerable<Book> RecoverBook([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.Books.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverBookById (int id)
    {
        var book = _context.Books.FirstOrDefault(book => book.Id == id);
        if (book == null) return NotFound();
        return Ok(book);
    }
}
