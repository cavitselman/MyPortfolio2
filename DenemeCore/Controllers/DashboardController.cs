﻿using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
