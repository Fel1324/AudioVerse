using Microsoft.AspNetCore.Mvc;
using AudioVerseAPI.Models;
using Microsoft.EntityFrameworkCore;
using AudioVerseAPI.Data;
using AutoMapper;
using AudioVerseAPI.Data.Dtos;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoritoController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public FavoritoController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpPost]
    public IActionResult AddFavorito(
    [FromBody] CreateFavoritoDto favoritoDto)
    {
        Favorito favorito = _mapper.Map<Favorito>(favoritoDto);
        _context.Favoritos.Add(favorito);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverFavoritoById),
            new { id = favorito.Id },
            favorito);
    }

    [HttpGet]
    public IEnumerable<ReadFavoritoDto> RecoverFavorito([FromQuery] int skip = 0,
    [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadFavoritoDto>>(_context.Favoritos.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecoverFavoritoById(int id)
    {
        var favorito = _context.Favoritos
            .Include(f => f.UserApp) 
            .Include(f => f.Book)
                .ThenInclude(b => b.GenreBooks) 
            .FirstOrDefault(favorito => favorito.Id == id);

        if (favorito == null) return NotFound();

        var favoritoDto = _mapper.Map<ReadFavoritoDto>(favorito);

        return Ok(favoritoDto);
    }

    [HttpGet("byuser/{userId}")]
    public IActionResult RecoverDetailedBookTitle(string userId)
    {
        // Busca os favoritos do usuário, incluindo detalhes do livro e seus relacionamentos
        var favoritos = _context.Favoritos
            .Where(f => f.UserAppId == userId)
            .Include(f => f.Book)
                .ThenInclude(b => b.Chapters) // Inclui capítulos
            .Include(f => f.Book)
                .ThenInclude(b => b.GenreBooks) // Inclui os gêneros associados
                    .ThenInclude(gb => gb.Genre)
            .ToList();

        // Mapeia para um DTO para incluir apenas os dados desejados na resposta
        var favoritosDto = favoritos.Select(f => new
        {
            FavoritoId = f.Id,
            Book = new
            {
                f.Book.Id,
                f.Book.Title,
                f.Book.AuthorBooks,
                f.Book.BookImage,
                Genres = f.Book.GenreBooks.Select(gb => gb.Genre.GenreName),
                Chapters = f.Book.Chapters.Select(c => new
                {
                    c.Id,
                    c.ChapterName
                })
            },
            f.DateAdded
        });

        return Ok(favoritosDto);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFavorito(int id)
    {
        
        var favorito = await _context.Favoritos.FindAsync(id);

        
        if (favorito == null)
        {
            return NotFound();
        }

        
        _context.Favoritos.Remove(favorito);
        await _context.SaveChangesAsync();

        
        return NoContent();
    }


    private bool FavoritoExists(int id)
    {
        return _context.Favoritos.Any(f => f.Id == id);
    }
}
