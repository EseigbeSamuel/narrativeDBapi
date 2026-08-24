using Microsoft.AspNetCore.Mvc;

namespace narrativeDBapi.modules.Org;

[ApiController]
[Route("api/[controller]")]
public class OrgControllerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
