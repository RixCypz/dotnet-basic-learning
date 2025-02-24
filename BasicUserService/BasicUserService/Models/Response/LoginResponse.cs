namespace BasicUserService.Models.Response;

public class LoginResponse : BaseResponse
{
    public string? Token { get; set; }
    public string? Username { get; set; }
}