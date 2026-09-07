using Microsoft.AspNetCore.Mvc;

namespace narrativeDBapi.modules.Users;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new List<Users>
        {
            new Users
            {
               Id = 1,
               Name = "adam",
               Email = "adam@example.com",
            },
            new Users
            {
                Id = 2,
                Name = "gabe",
                Email = "gabe@example.com",
            },

        };
      
      
        return Ok(users);
    }
}
