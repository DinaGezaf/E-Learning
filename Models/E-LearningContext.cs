using Microsoft.EntityFrameworkCore;

namespace E_Learning_Platform.Models
{
    public class E_LearningContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=E-LearningSystemDB;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<App_User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Certificate> Certificates { get; set; }


    }
}
