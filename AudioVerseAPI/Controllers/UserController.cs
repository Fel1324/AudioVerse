using AudioVerseAPI.Data.Dtos;

using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]

    public IActionResult RegisterUser
        (CreateUserDto dto)
    {
        throw new NotImplementedException();
    }
}
