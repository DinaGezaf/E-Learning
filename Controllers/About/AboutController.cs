using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers.About
{
    public class AboutController : Controller
    {
<<<<<<< HEAD
=======
        [Authorize]
>>>>>>> fb023d4d11801bd8cce5e3a3cdb821640cbb913c
        public IActionResult Index()
        {
            return View();
        }
    }
}
