using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

using Microsoft.AspNetCore.Identity;

namespace AudioVerseAPI.Services;

public class RegisterService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;

    public RegisterService(UserManager<User> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
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
}
