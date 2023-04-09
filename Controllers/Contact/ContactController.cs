using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_Learning.Controllers.Contact
{
    public class ContactController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            
           
            return View();
        }
    }
}
