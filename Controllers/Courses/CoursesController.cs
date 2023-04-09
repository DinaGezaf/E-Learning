using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.Contact
{
    public class CoursesController : Controller
    {
        [Authorize(Roles = "Student")]

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CourseDetails()
        {
            return View();
        }
    }
}
