using narrativeDBapi.modules.Teams;
using narrativeDBapi.modules.Users;

namespace narrativeDBapi.modules.Org;

public class Org
{
    public int OrgId { get; set; }
    public required string OrgName { get; set; }
    public required Teams.Teams Teams { get; set; }
    public  required ICollection<Users.Users> Users { get; set; }
    
}
