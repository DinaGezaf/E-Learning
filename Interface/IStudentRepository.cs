using E_Learning.Models;

namespace E_Learning.Interface
{
    public interface IStudentRepository:IGenericRepository<Student>
    {
        Student GetByUserId(string id);
    }
}
