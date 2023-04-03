using E_Learning_Platform.Models;

namespace E_Learning_Platform.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public int CourseId { get; set; }
        public int LessonId { get; set; }
        public int QuizId { get; set; }
        public virtual Course? Course { get; set; }
        public virtual Lesson? Lesson { get; set; }
        public virtual Quiz? Quiz { get; set; }
    }
}
