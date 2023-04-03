namespace E_Learning_Platform.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EnrollmentHistory { get; set; }
        public int PaymentHistory { get; set; }
        public int CourseHistory { get; set; }

        public virtual App_User User { get; set; }
        public virtual List<Course> Courses { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }

    }
}
