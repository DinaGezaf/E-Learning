using E_Learning.Interface;
using E_Learning.Repository;
using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using E_Learning.Models;
using E_Learning.viewmodel;

namespace E_Learning.Controllers
{

    public class StudentController : Controller
    {
        IStudentRepository studentRepository;
        public StudentController(IGenericRepository<Course> courseRepo,
            IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }
        public IActionResult Profile()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            List<Claim> claims = User.Claims.ToList();
            Claim? ClaimID = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            string userId = ClaimID.Value;

            var student=studentRepository.GetCrsByStudentId(userId);
            return View(student);
        }
    }
}
