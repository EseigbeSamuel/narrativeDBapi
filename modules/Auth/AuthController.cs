using Microsoft.AspNetCore.Mvc;

namespace narrativeDBapi.modules.Auth;

[ApiController]
[Route("api/[controller]")]
public class AuthControllerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
