using AudioVerseAPI.Data;
using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AddBook(
        [FromBody] CreateBookDto bookDto)
    {
        Book book = _mapper.Map<Book>(bookDto);
        _context.Books.Add(book);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverBookById),
            new { id = book.Id },
            book);
    }

    [HttpGet]
    public IEnumerable<ReadBookDto> RecoverBook([FromQuery] int skip = 0,
    [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadBookDto>>(_context.Books.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecoverBookById(int id)
    {
        var book = _context.Books
            .FirstOrDefault(book => book.Id == id);
        if (book == null) return NotFound();
        var bookDto = _mapper.Map<ReadBookDto>(book);
        return Ok(bookDto);
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

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = _context.Books.FirstOrDefault(
            book => book.Id == id);
        if (book == null) return NotFound();
        _context.Remove(book);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpGet("detailed/{id}")]
    public IActionResult RecoverDetailedBook(int id)
    {
        var book = _context.Books
                .Where(b => b.Id == id)
                .Include(b => b.Chapters)
                .Include(b => b.GenreBooks)
                .ThenInclude(gb => gb.Genre)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .FirstOrDefault();
        return Ok(book);
    }

    [HttpGet("detailed")]
    public IActionResult RecoverAllDetailedBook()
    {
        var book = _context.Books
                .Include(b => b.Chapters)
                .Include(b => b.GenreBooks)
                .ThenInclude(gb => gb.Genre)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .ToList();
        return Ok(book);
    }
}
