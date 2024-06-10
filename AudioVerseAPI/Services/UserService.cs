using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Services;

public class UserService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
    }

    public async Task Register(CreateUserDto dto)
    {
        User user = _mapper.Map<User> (dto);

        IdentityResult result = await _userManager.CreateAsync
            (user, dto.Password);

        if (!result.Succeeded)
        {
          throw new ApplicationException("Falha ao cadastrar: Sua senha deve conter a primeira letra maíuscula," +
          "números e caracteres especiais");
        }
    }

    public async Task Login(LoginUserDto dto)
    {
        var result = await _signInManager.PasswordSignInAsync
            (dto.Username, dto.Password, false, false);

        if (!result.Succeeded)
        {
            throw new ApplicationException("Usuário não autenticado!");
        }
    }
}
