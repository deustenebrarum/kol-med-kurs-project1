public class Review
{
    public int ReviewID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }

    // Foreign key
    public int SpecialistID { get; set; }
    public Specialist Specialist { get; set; }
}
