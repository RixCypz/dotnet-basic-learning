namespace BasicUserService.Models.Response;

public class BaseResponse
{
    public long? Code { get; set; }
    public string? Status { get; set; }
    public string? Message { get; set; }
}