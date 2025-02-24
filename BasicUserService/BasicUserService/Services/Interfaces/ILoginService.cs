using BasicUserService.Models.Requests;
using BasicUserService.Models.Response;

namespace BasicUserService.Services.Interfaces;

public interface ILoginService
{
    Task<LoginResponse> AuthenticateAsync(LoginRequest loginRequest);
    string GenerateJwtToken(string username);
}