using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin")]
public class AdminController : Controller
{
    [HttpGet("dashboard")]
    [RoleAuthorize("admin")]
    public IActionResult Dashboard()
    {
        return Ok("Admin Access Granted");
    }
}