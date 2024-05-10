using AudioVerseAPI.Data;
using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

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
    public IActionResult AddChapter(CreateChapterDto dto)
    {
        Chapter chapter = _mapper.Map<Chapter>(dto);
        _context.Chapters.Add(chapter);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RetrieveChapterById), new { Id = chapter.Id }, chapter);
    }

    [HttpGet]
    public IEnumerable<ReadChapterDto> RetrieveChapters()
    {
        return _mapper.Map<List<ReadChapterDto>>(_context.Chapters.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RetrieveChapterById(int id)
    {
        Chapter chapter = _context.Chapters.FirstOrDefault(chapter => chapter.Id == id);
        if (chapter != null)
        {
            ReadChapterDto chapterDto = _mapper.Map<ReadChapterDto>(chapter);

            return Ok(chapterDto);
        }
        return NotFound();
    }
}
