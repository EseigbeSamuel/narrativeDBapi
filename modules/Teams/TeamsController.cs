using Microsoft.AspNetCore.Mvc;

namespace narrativeDBapi.modules.Teams;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
