namespace narrativeDBapi.modules.Teams;

public class Teams
{
    public int TeamsId { get; set; }
    public string TeamsName { get; set; } = string.Empty;
    public string TeamsDescription { get; set; } = string.Empty; 
    public required ICollection<Users.Users> Users { get; set; }
    
}
