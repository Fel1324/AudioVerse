using AudioVerseAPI.Data;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class AuthorBookController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public AuthorBookController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AuthorBook>>> GetAuthorBooks()
    {
        return await _context.AuthorBooks.ToListAsync();
    }

    [HttpGet("{authorId}/{bookId}")]
    public async Task<ActionResult<AuthorBook>> GetAuthorBook(int authorId, int bookId)
    {
        var authorBook = await _context.AuthorBooks
            .FindAsync(authorId, bookId);

        if (authorBook == null)
        {
            return NotFound();
        }

        return authorBook;
    }

    [HttpPost]
    public async Task<ActionResult<AuthorBook>> PostAuthorBook(AuthorBook authorBook)
    {
        _context.AuthorBooks.Add(authorBook);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAuthorBook), new { authorId = authorBook.AuthorId, bookId = authorBook.BookId }, authorBook);
    }

    [HttpDelete("{authorId}/{bookId}")]
    public async Task<IActionResult> DeleteAuthorBook(int authorId, int bookId)
    {
        var authorBook = await _context.AuthorBooks
            .FindAsync(authorId, bookId);

        if (authorBook == null)
        {
            return NotFound();
        }

        _context.AuthorBooks.Remove(authorBook);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}