using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private static List<Book> books = new List<Book>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaBook([FromBody] Book book)
    {
        book.Id = id++;
        books.Add(book);
        Console.WriteLine(book.Title);
    }

    [HttpGet]
    public IEnumerable<Book> RecuperaBooks()
    {
        return books;
    }

    [HttpGet("{id}")]
    public Book? RecuperaBookPorId (int id)
    {
        return books.FirstOrDefault(book => book.Id == id);
    }
}
