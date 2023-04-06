namespace E_Learning_Platform.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public virtual List<Course>? Courses { get; set; }
        public virtual List<Payment>? Payments { get; set; }
    }
}
