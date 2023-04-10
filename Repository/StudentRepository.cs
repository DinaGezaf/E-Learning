using E_Learning.Interface;
using E_Learning.Models;
using E_Learning_Platform.Models;

namespace E_Learning.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        E_LearningContext context;
        public StudentRepository(E_LearningContext _context) : base(_context)
        {
            context = _context;
        }

        Student IStudentRepository.GetByUserId(string id)
        {
            return context.Students.FirstOrDefault(s => s.User_id == id);
        }
    }
}
