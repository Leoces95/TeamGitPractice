using Microsoft.AspNetCore.Mvc;
namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHealth()
    {
        return Ok(new { healthy = true });
    }
}