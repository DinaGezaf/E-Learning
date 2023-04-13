using E_Learning.Interface;
using E_Learning.Repository;
using E_Learning.viewmodel;
using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    public class CoursesController : Controller
    {
        ICourseRepository courseRepository;
        IFeedbackRepository feedbackRepository;
        public CoursesController(IGenericRepository<Course> courseRepo,
            ICourseRepository _courseRepository,
            IFeedbackRepository _feedbackRepository)
        {
            courseRepository = _courseRepository;
            feedbackRepository = _feedbackRepository;
        }
        public IActionResult Index()
        {
            var Courses = courseRepository.GetAll();
            return View(Courses);
        }
        public IActionResult CourseDetails(int id)
        {
            var Course = courseRepository.GetById(id);
            return View(Course);
        }
        [HttpGet]
        public IActionResult AddFeedback(int courseId)
        {
            var feedbackViewModel = new FeedbackViewModel { CourseId = courseId };
            return PartialView("_AddFeedback", feedbackViewModel);
        }
        [HttpPost]
        public IActionResult AddFeedback(FeedbackViewModel model)
        {
            var feedback = new Feedback();
            feedback.CourseId = model.CourseId;
            feedback.StudentId = model.StudentId;
            feedback.Comment = model.Comment;
            feedback.Rating = model.Rating;
            feedback.Date = DateTime.Now;

            feedbackRepository.Insert(feedback);
            return RedirectToAction("CourseDetails", "Courses", feedback);
        }

    }
}
