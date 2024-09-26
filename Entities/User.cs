public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    // Navigation property for requests
    public ICollection<Request> Requests { get; set; }
}
