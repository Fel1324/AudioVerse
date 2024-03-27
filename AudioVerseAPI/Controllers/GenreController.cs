﻿using AudioVerseAPI.Data;
using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public GenreController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddGenre(
        [FromBody] CreateGenreDto genreDto)
    {
        Genre genre = _mapper.Map<Genre>(genreDto);
        _context.Genres.Add(genre);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverGenreById),
            new { id = genre.Id },
            genre);
    }

    [HttpGet]
    public IEnumerable<Genre> RecoverGenre([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.Genres.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverGenreById(int id)
    {
        var genre = _context.Genres.FirstOrDefault(genre => genre.Id == id);
        if (genre == null) return NotFound();
        return Ok(genre);
    }
}

