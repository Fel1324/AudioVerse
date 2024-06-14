using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Services;

public class UserAppService
{
    private IMapper _mapper;
    private UserManager<UserApp> _userManager;
    private SignInManager<UserApp> _signInManager;
    private TokenService _tokenService;

    public UserAppService(IMapper mapper,
        UserManager<UserApp> userManager,
        SignInManager<UserApp> signInManager,
        TokenService tokenService)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    public async Task Register(CreateUserAppDto dto)
    {
        UserApp userApp = _mapper.Map<UserApp> (dto);

        IdentityResult result = await _userManager.CreateAsync
            (userApp, dto.Password);

        if (!result.Succeeded)
        {
          throw new ApplicationException("Falha ao cadastrar: Sua senha deve conter a primeira letra maíuscula," +
          "números e caracteres especiais");
        }
    }

    public async Task Login(LoginUserAppDto dto)
    {
        var result = await _signInManager.PasswordSignInAsync
            (dto.Username, dto.Password, false, false);

        if (!result.Succeeded)
        {
            throw new ApplicationException("Usuário não autenticado!");
        }

        _tokenService.GenerateToken(userApp);
    }
}
