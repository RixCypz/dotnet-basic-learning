using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BasicUserService.Models.Requests;

public class LoginRequest
{
    [Required(ErrorMessage = "Username is required")]
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [JsonPropertyName("password")]
    public string? Password { get; set; }
}