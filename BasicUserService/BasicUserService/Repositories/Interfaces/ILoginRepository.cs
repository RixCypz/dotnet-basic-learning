using BasicUserService.Models.Requests;
using BasicUserService.Models.Response;

namespace BasicUserService.Repositories.Interfaces;

public interface ILoginRepository
{
    Task<LoginResponse> AuthenticateAsync(LoginRequest loginRequest);
}