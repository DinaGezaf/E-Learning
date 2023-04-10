﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    [Authorize]
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowLesson()
        {
            return View();
        }
    }
}
