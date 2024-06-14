
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using AudioVerseAPI.Models;

using Microsoft.IdentityModel.Tokens;

namespace AudioVerseAPI.Services;

public class TokenService
{
    public void GenerateToken(UserApp userApp)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username", userApp.UserName),
            //new Claim("id", userApp.Id)
        };

        var key = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
            ("9080912UHEFION091IIND1"));

        var signingCredentials =
            new SigningCredentials(key,
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (
            expires: DateTime.Now.AddMinutes(10),
            claims: claims,
            signingCredentials: signingCredentials
            );
    }
}