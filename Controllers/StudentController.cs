using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Learning.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
