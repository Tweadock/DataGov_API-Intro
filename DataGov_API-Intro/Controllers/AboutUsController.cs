﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataGov_API_Intro.Controllers
{
    public class AboutUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
