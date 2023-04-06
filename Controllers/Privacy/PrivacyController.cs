using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.Privacy
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
