using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.Contact
{
    public class CoursesController : Controller
    {
<<<<<<< HEAD
        [Authorize(Roles = "Student")]
=======

>>>>>>> fb023d4d11801bd8cce5e3a3cdb821640cbb913c
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
