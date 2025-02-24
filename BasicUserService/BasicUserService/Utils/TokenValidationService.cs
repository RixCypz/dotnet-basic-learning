namespace BasicUserService.Utils;

public class TokenValidationService(string jwtSecret)
{
    private readonly string _jwtSecret = jwtSecret;

    public bool ValidateToken(string token)
    {
        return !string.IsNullOrEmpty(token);
    }
}