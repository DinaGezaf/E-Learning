using E_Learning.Interface;
using E_Learning.Models;

namespace E_Learning.Repository
{
    public class StudentRepository:GenericRepository<Student>, IStudentRepository
    {
        ELearningContext context;
        public StudentRepository(ELearningContext _context):base(_context)
        {
            context= _context;
        }

        Student IStudentRepository.GetByUserId(string id)
        {
            return context.Students.FirstOrDefault(s => s.UserId == id);
        }
    }
}
