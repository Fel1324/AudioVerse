
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using AudioVerseAPI.Models;

using Microsoft.IdentityModel.Tokens;

namespace AudioVerseAPI.Services;

public class TokenService
{
    private IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(UserApp userApp)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username", userApp.UserName),
            new Claim("id", userApp.Id)
        };

    var tokenKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes
        ("9ASHDA98H9ah9ha9H9A89n0fjhkjsjafkjhakhfhal8e789798qy23yhuiyhyhuya"));

        var signingCredentials =
            new SigningCredentials
            (tokenKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (
            expires: DateTime.Now.AddMinutes(10),
            claims: claims,
            signingCredentials: signingCredentials
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

