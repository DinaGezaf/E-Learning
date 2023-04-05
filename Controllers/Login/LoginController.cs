using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.Login
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            App_User newUSer = new App_User();
            return View(newUSer);
        }
    }
}
