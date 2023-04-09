using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.About
{
    public class AboutController : Controller
    {
        [Authorize(Roles ="Instructor")] 
        public IActionResult Index()
        {
            return View();
        }
    }
}
