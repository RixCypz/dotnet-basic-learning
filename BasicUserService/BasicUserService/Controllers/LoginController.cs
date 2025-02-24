using BasicUserService.Models.Requests;
using BasicUserService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BasicUserService.Controllers;

[ApiController]
[Route("api")]
public class LoginController(ILoginService loginService, ILogger<LoginController> logger) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody]LoginRequest loginRequest)
    {
        logger.LogInformation("-----LOGIN ATTEMPT-----");
        var response = await loginService.AuthenticateAsync(loginRequest);

        if (response.Code == 200)
        {   
            logger.LogInformation("Login successful. Tokens: {Token}", response.Token);
            return Ok(response); 
        }

        return Unauthorized(response);
    }
}