using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
            "María Paulina Vargas Lenis",
            "Mariana Suaza Serna",
            "Leonel Antonio Martínez silgado",
            "Sebastián Ciro Medellín",
            "Daniel Zapata Ramírez"
        };

        return Ok(members);
    }
    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok(new { total = 5 });  
    }

}