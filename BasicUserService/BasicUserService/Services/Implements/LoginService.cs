using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BasicUserService.Models.Requests;
using BasicUserService.Models.Response;
using BasicUserService.Repositories.Interfaces;
using BasicUserService.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace BasicUserService.Services.Implements;

public class LoginService(ILoginRepository loginRepository) : ILoginService
{
    private const string JwtSecret = "your-strong-32-characters-long-secret-key!";

    public async Task<LoginResponse> AuthenticateAsync(LoginRequest loginRequest)
    {
        var loginResponse = await loginRepository.AuthenticateAsync(loginRequest);
        if (loginResponse.Code == 200)
        {
            loginResponse.Token = GenerateJwtToken(JwtSecret);
        }
        
        return loginResponse;
    }

    public string GenerateJwtToken(string username)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(JwtSecret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

}