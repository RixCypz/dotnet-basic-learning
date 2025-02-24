using BasicUserService.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicUserService.Controllers;

[ApiController]
[Route("api")]
public class HealthCheckController(TokenValidationService tokenValidationService, ILogger<HealthCheckController> logger) : ControllerBase
{
    [HttpPost("healthCheck")]
    public IActionResult HealthCheck()
    {
        logger.LogInformation("-----HEALTH CHECK ATTEMPT-----");
        var token = Request.Headers.Authorization.ToString().Replace("Bearer ", "");

        if (tokenValidationService.ValidateToken(token))
        {
            return Ok("Heath check ok, Application is running.");
        }

        return Unauthorized("Invalid token");
    }
}