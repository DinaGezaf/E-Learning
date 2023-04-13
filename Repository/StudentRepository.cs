using E_Learning.Interface;
using E_Learning.viewmodel;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

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
            var Enrollments = context.Enrollments.Include(e => e.Course).Where(cs => cs.StudentId == std.Id).OrderByDescending(e => e.Date).ToList();
          

            StudentProfileViewModel studentVM = new StudentProfileViewModel();

            studentVM.Profile_picture = std?.Profile_Picture;
            studentVM.Bio = std.Bio;
            studentVM.DateOfBirth = std.DateOfBirth;
            studentVM.Id = std.Id;

            studentVM.Enrolled_Courses = Enrollments.Select(e => e.Course).ToList();
            studentVM.CrsEnrolled = studentVM.Enrolled_Courses.Count();

            return studentVM;
        }
        public void UpdateStudent( int id,Student student )
        {

            var existingStudent = context.Students.Include(s => s.App_User).FirstOrDefault(s => s.Id == id);

            if (existingStudent != null)
            {
                existingStudent.Id = student.Id;
                existingStudent.Bio = student.Bio;
                existingStudent.Profile_Picture = student.Profile_Picture;

                context.SaveChanges();
            }
        }
        public StudentProfileViewModel GetById(int id)
        {
            Student studentmodel = context.Students.Include(s=>s.App_User).FirstOrDefault(s => s.Id == id);
            var StudentVM = new StudentProfileViewModel();

            StudentVM.Id = studentmodel.Id;
            StudentVM.Bio= studentmodel.Bio ;
            StudentVM.Profile_picture= studentmodel.Profile_Picture;

            return StudentVM;
        }

    }
}
