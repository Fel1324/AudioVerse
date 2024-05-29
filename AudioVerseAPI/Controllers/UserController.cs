using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;
using AudioVerseAPI.Services;

using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase 
{
    private RegisterService _registerService;

    public UserController(RegisterService registerService)
    {
        _registerService = registerService;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser
        (CreateUserDto dto)
    {
        await _registerService.Register(dto);
        return Ok("Usúario Cadastrado!");
    }
}


