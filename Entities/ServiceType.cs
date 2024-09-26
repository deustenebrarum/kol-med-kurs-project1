public class ServiceType
{
    public int ServiceTypeID { get; set; }
    public string Name { get; set; }

    // Navigation property for requests
    public ICollection<Request> Requests { get; set; }
}
