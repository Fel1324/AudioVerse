using Microsoft.AspNetCore.Mvc;
using AudioVerseAPI.Models;
using Microsoft.EntityFrameworkCore;
using AudioVerseAPI.Data;
using AutoMapper;
using AudioVerseAPI.Data.Dtos;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChapterController : ControllerBase
{

    private AudioVerseContext _context;
    private IMapper _mapper;

    public ChapterController(AudioVerseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpPost]
    public IActionResult AddChapter(
    [FromBody] CreateChapterDto chapterDto)
    {
        Chapter chapter = _mapper.Map<Chapter>(chapterDto);
        _context.Chapters.Add(chapter);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecoverChapterById),
            new { id = chapter.Id },
            chapter);
    }

    [HttpGet]
    public IEnumerable<ReadChapterDto> RecoverChapter([FromQuery] int skip = 0,
    [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadChapterDto>>(_context.Chapters.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecoverChapterById(int id)
    {
        var chapter = _context.Chapters
            .FirstOrDefault(chapter => chapter.Id == id);
        if (chapter == null) return NotFound();
        var chapterDto = _mapper.Map<ReadChapterDto>(chapter);
        return Ok(chapterDto);
    }

    [HttpPut("{id}")]
        public async Task<IActionResult> PutChapter(int id, Chapter chapter)
        {
            if (id != chapter.Id)
            {
                return BadRequest();
            }

            _context.Entry(chapter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChapterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter(int id)
        {
            var chapter = await _context.Chapters.FindAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }

            _context.Chapters.Remove(chapter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChapterExists(int id)
        {
            return _context.Chapters.Any(e => e.Id == id);
        }
    }
