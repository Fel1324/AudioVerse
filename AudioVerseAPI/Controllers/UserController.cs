using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AudioVerseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase 
{
    private IMapper _mapper;
    private UserManager<User> _userManager;

    public UserController(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser
        (CreateUserDto dto)
    {
        User user = _mapper.Map<User>
            (dto);

        IdentityResult result = await _userManager.CreateAsync
            (user, dto.Password);

        if(result.Succeeded) return Ok("Usuário Cadastrado!");

        throw new ApplicationException("Falha ao cadastrar: Sua senha deve conter letras, números e caracteres especiais");
    }
}


