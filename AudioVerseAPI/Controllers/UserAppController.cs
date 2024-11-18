using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;
using AudioVerseAPI.Services;

using AutoMapper;

using Microsoft.AspNetCore.Authorization;
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
    public async Task<IActionResult> RegisterAppUser(CreateUserAppDto dto)
    {
        try
        {
            await _userAppService.Register(dto);
            return Ok("Usuário Cadastrado!");
        }
        catch (ApplicationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginUserAppDto dto)
    {
        try
        {
            var token = await _userAppService.Login(dto);
            return Ok(token);
        }
        catch (ApplicationException ex)
        {
            return Unauthorized(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("userinfo")]
    public IActionResult GetUserInfo()
    {
        var userId = User.FindFirst("id")?.Value; 
        var username = User.FindFirst("username")?.Value; 

        if (userId == null)
        {
            return Unauthorized(new
            {
                Message = "Usuário não autenticado.",
                Claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList() 
            });
        }

        return Ok(new
        {
            UserId = userId,
            Username = username,
            Token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "")
        });
    }
}
