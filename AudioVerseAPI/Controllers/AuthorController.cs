﻿using AudioVerseAPI.Data;
using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public AuthorController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddAuthor(
        [FromBody] CreateAuthorDto authorDto)
    {
        Author author = _mapper.Map<Author>(authorDto);
        _context.Authors.Add(author);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverAuthorById),
            new { id = author.Id },
            authorDto);
    }

    [HttpGet]
    public IEnumerable<ReadAuthorDto> RecoverAuthor([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadAuthorDto>>(_context.Authors.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecoverAuthorById(int id)
    {
        var author = _context.Authors.
            FirstOrDefault(author => author.Id == id);
        if (author == null) return NotFound();
        var authorDto = _mapper.Map<ReadAuthorDto>(author);
        return Ok(authorDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAuthor(int id, [FromBody]
        UpdateAuthorDto authorDto)
    {
        var author = _context.Authors.FirstOrDefault(
            author => author.Id == id);
        if (author == null) return NotFound();
        _mapper.Map(authorDto, author);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAuthor(int id)
    {
        var author = _context.Authors.FirstOrDefault(
            author => author.Id == id);
        if (author == null) return NotFound();
        _context.Remove(author);
        _context.SaveChanges();
        return NoContent();
    }
}

