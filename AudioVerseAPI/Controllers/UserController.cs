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
    private UserService _userService;

    public UserController(UserService registerService)
    {
        _userService = registerService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> RegisterUser
        (CreateUserDto dto)
    {
        await _userService.Register(dto);
        return Ok("Usúario Cadastrado!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginUserDto dto)
    {
        await _userService.Login(dto);
        return Ok("Usuário autenticado!");
    }
}

//Renomear as classes users


