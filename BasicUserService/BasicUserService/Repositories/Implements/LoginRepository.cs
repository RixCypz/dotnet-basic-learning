using BasicUserService.Models.Entities;
using BasicUserService.Models.Requests;
using BasicUserService.Models.Response;
using BasicUserService.Repositories.Interfaces;

namespace BasicUserService.Repositories.Implements;

public class LoginRepository : ILoginRepository
{
    private readonly List<Login> _mockUsers =
    [
        new Login { Username = "Kawee", Password = "Lertrungmongkol" },
        new Login { Username = "Chaiyapruek", Password = "Worasiha" }
    ];
    
    public Task<LoginResponse> AuthenticateAsync(LoginRequest loginRequest)
    {
        var user = _mockUsers.FirstOrDefault(u => (u.Username == loginRequest.Username && u.Password == loginRequest.Password));
        if (user != null)
        {
            return Task.FromResult(new LoginResponse()
            {
                Code = 200,
                Status = "Success",
                Message = "Login successful",
                Username = user.Username,
                Token = "mockToken123"
            });
        }

        return Task.FromResult(new LoginResponse()
        {
            Code = 401,
            Status = "Failed",
            Message = "Invalid username or password"
        });
    }
}