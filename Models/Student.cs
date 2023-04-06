namespace E_Learning_Platform.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Profile_Picture { get; set; }
        public int EnrollmentHistory { get; set; }
        public int PaymentHistory { get; set; }
        public int CourseHistory { get; set; }
        public virtual List<Course> Courses { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }

    }
}
