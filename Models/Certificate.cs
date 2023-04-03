using E_Learning_Platform.Models;

namespace E_Learning_Platform.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }

    }
}
