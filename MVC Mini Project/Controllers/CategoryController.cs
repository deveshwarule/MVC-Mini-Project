﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Mini_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
