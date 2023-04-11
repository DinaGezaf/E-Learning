﻿using E_Learning.Interface;
using E_Learning.Models;
using E_Learning.ViewModels;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Learning.Repository
{
    public class CourseStudentRepository : ICourseStudentRepository
    {
        E_LearningContext context;
        public CourseStudentRepository(E_LearningContext _context, IStudentRepository studentRepo)
        {
            context = _context;
        }
        public void Delete(int courseId, int stdId)
        {
            CourseStudent courseStudent = context.CourseStudent.FirstOrDefault(cs => cs.CourseId == courseId && cs.StudentId == stdId);
            context.Remove(courseStudent);
            context.SaveChanges();
        }

    public List<StudentCourseViewModel> GetByStudentId(int studentId)
    {
          var courses = context.CourseStudent.Include(cs=>cs.Course).Where(cs => cs.StudentId == studentId).ToList();
        List<StudentCourseViewModel> studentCoursesVM = new List<StudentCourseViewModel>();
        foreach (var course in courses)
        {
            studentCoursesVM.Add(new StudentCourseViewModel
            {
                Id = course.Course.Id,
                Title = course.Course.Name,
                Description = course.Course.Description,
                Rating = course.Course.Rating,
                Price = course.Course.Price,
                Image = course.Course.Image,

            });
        }
        return studentCoursesVM;
    }

    public void Insert(CourseStudent crsStudent)
    {
        context.CourseStudent.Add(crsStudent);
        context.SaveChanges();
    }

}
}