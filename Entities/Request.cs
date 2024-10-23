public class Request
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Number { get; set; }

    // Foreign keys
    public int ServiceTypeId { get; set; }
    public ServiceType ServiceType { get; set; }

    public int SpecialistId { get; set; }
    public Specialist Specialist { get; set; }

    public int PatientId { get; set; }
    public User Patient { get; set; }
}
