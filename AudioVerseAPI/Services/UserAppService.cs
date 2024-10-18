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
        UserApp userApp = _mapper.Map<UserApp>(dto);

        IdentityResult result = await _userManager.CreateAsync(userApp, dto.Password);

        if (!result.Succeeded)
        {
            var errorMessages = result.Errors.Select(e => e.Description).ToList();

            if (result.Errors.Any(e => e.Code == "DuplicateUserName"))
            {
                throw new ApplicationException("Esse usuário já foi cadastrado.");
            }

            throw new ApplicationException($"Falha ao cadastrar: {string.Join(", ", errorMessages)}");
        }
    }

 
    public async Task<string> Login(LoginUserAppDto dto)
    {
        
        var userApp = _signInManager.UserManager.Users
            .FirstOrDefault(user => user.NormalizedUserName == dto.Username.ToUpper());

        if (userApp == null)
        {
            throw new ApplicationException("Usuário não encontrado.");
        }

        
        var result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

        if (!result.Succeeded)
        {
            throw new ApplicationException("Senha incorreta.");
        }

        
        var token = _tokenService.GenerateToken(userApp);
        return token;
    }
}