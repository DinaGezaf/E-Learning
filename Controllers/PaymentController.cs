using E_Learning.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;


namespace E_Learning.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Charge()
        {
            return View("Index");
        }
    }
}
