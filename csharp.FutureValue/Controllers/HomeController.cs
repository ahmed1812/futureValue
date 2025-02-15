﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp.FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AhmedFawzi.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValue model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculatFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}

