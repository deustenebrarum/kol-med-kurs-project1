public class Request
{
    public int RequestID { get; set; }
    public DateTime Date { get; set; }
    public string Number { get; set; }

    // Foreign keys
    public int ServiceTypeID { get; set; }
    public ServiceType ServiceType { get; set; }

    public int SpecialistID { get; set; }
    public Specialist Specialist { get; set; }

    public int PatientID { get; set; }
    public User Patient { get; set; }
}
