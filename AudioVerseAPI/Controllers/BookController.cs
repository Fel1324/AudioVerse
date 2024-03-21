using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private static List<Book> books = new List<Book>();

    [HttpPost]
    public void AdicionaBook([FromBody] Book book)
    {
        books.Add(book);
        Console.WriteLine(book.Title);
    }
}
