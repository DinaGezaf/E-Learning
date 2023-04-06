using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
