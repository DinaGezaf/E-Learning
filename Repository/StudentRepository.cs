using E_Learning.Interface;
using E_Learning.viewmodel;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

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

         StudentProfileViewModel IStudentRepository.GetCrsByStudentId(string userId)
        {
            var std = context.Students.FirstOrDefault(s => s.User_id == userId);
            var Enrollments = context.Enrollments.Where(cs => cs.StudentId == std.Id).ToList();

            StudentProfileViewModel studentVM = new StudentProfileViewModel();

            studentVM.Profile_picture = std?.Profile_Picture;
            studentVM.Bio = std.Bio;
            studentVM.DateOfBirth = std.DateOfBirth;
            
            foreach(var item in Enrollments)
            {
                studentVM.Enrolled_Courses = context.Courses.Where(cs => cs.EnrollmentId == item.Id).ToList();
                studentVM.CrsEnrolled = studentVM.Enrolled_Courses.Count();
            }
            return studentVM;
        }

    }
}
