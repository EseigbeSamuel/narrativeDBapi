namespace narrativeDBapi.modules.Users;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty; 
     //public Teams Teams { get; set; } 
    public UserRole Role { get; set; }
}
