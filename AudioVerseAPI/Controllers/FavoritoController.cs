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

    [HttpGet("byuser/{user}")]
    public IActionResult RecoverDetailedBookTitle(string user)
    {
        var book = _context.Favoritos
            .Where(f => f.UserAppId == user)
            .Include(f => f.Book)
            .ThenInclude(b => b.GenreBooks)
            .ThenInclude(g => g.Genre)
            .FirstOrDefault();
        return Ok(book);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFavorito(int id)
    {
        var userApp = await _context.UserApps.FindAsync(id);
        if (userApp == null)
        {
            return NotFound();
        }

        _context.UserApps.Remove(userApp);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FavoritoExists(int id)
    {
        return _context.Favoritos.Any(f => f.Id == id);
    }
}
