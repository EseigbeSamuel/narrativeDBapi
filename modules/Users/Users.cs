namespace narrativeDBapi.modules.Users;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty; 
     //public Teams Teams { get; set; } 
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = new DateTime();
}
