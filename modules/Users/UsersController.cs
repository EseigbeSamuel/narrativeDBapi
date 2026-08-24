using Microsoft.AspNetCore.Mvc;

namespace narrativeDBapi.modules.Users;

[ApiController]
[Route("api/[controller]")]
public class UsersControllerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
