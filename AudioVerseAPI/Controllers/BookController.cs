using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private static List<Book> books = new List<Book>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        book.Id = id++;
        books.Add(book);
        return CreatedAtAction(nameof(RecoverBookById),
            new { id = book.Id},
            book);
    }

    [HttpGet]
    public IEnumerable<Book> RecoverBook([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return books.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverBookById (int id)
    {
        var book = books.FirstOrDefault(book => book.Id == id);
        if (book == null) return NotFound();
        return Ok(book);
    }
}
