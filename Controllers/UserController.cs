using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("user")]
public class UserController : Controller
{
    [HttpPost("submit")]
    public IActionResult Submit(string username, string email)
    {
        var clean = InputSanitizer.SanitizeUsername(username);
        if (!InputSanitizer.IsValidEmail(email)) return BadRequest();
        return Ok(InputSanitizer.EncodeForHtml(clean));
    }
}