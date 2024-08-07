using AudioVerseAPI.Data;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class GenreBookController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public GenreBookController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GenreBook>>> GetGenreBooks()
    {
        return await _context.GenreBooks.ToListAsync();
    }

    [HttpGet("{genreId}/{bookId}")]
    public async Task<ActionResult<GenreBook>> GetGenreBook(int genreId, int bookId)
    {
        var genreBook = await _context.GenreBooks
            .FindAsync(genreId, bookId);

        if (genreBook == null)
        {
            return NotFound();
        }

        return genreBook;
    }

    [HttpPost]
    public async Task<ActionResult<GenreBook>> PostGenreBook(GenreBook genreBook)
    {
        _context.GenreBooks.Add(genreBook);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetGenreBook), new { genreId = genreBook.GenreId, bookId = genreBook.BookId }, genreBook);
    }

    [HttpDelete("{genreId}/{bookId}")]
    public async Task<IActionResult> DeleteGenreBook(int genreId, int bookId)
    {
        var genreBook = await _context.GenreBooks
            .FindAsync(genreId, bookId);

        if (genreBook == null)
        {
            return NotFound();
        }

        _context.GenreBooks.Remove(genreBook);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}