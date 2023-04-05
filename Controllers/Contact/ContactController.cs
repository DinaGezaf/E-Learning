using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.Contact
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
