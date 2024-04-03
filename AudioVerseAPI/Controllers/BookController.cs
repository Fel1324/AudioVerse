using AudioVerseAPI.Data;
using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public BookController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddBook(
        [FromBody] CreateBookDto bookDto)
    {
        Book book = _mapper.Map<Book>(bookDto);
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
        var book = _context.Books
            .FirstOrDefault(book => book.Id == id);
        if (book == null) return NotFound();
        return Ok(book);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody]
        UpdateBookDto bookDto)
    {
        var book = _context.Books.FirstOrDefault(
            book => book.Id == id);
        if (book == null) return NotFound();
        _mapper.Map(bookDto, book);
        _context.SaveChanges();
        return NoContent();
    }
}
