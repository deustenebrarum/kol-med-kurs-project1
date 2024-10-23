public class Specialist
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }

    // Navigation properties
    public ICollection<Request> Requests { get; set; }
    public ICollection<Review> Reviews { get; set; }
}
