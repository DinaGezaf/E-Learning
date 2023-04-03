using E_Learning_Platform.Models;

namespace E_Learning_Platform.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Questions { get; set; }
        public int Duration { get; set; }
        public int Pass_Percentage { get; set; }
        public int Quiz_Results { get; set; }
        public int LessonId { get; set; }
        public virtual Lesson? Lesson { get; set; }

    }
}
