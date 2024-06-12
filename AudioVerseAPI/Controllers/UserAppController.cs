using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;
using AudioVerseAPI.Services;

using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserAppController : ControllerBase 
{
    private UserAppService _userAppService;

    public UserAppController(UserAppService registerAppService)
    {
        _userAppService = registerAppService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> RegisterAppUser
        (CreateUserAppDto dto)
    {
        await _userAppService.Register(dto);
        return Ok("Usúario Cadastrado!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginUserAppDto dto)
    {
        await _userAppService.Login(dto);
        return Ok("Usuário autenticado!");
    }
}


