﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.BasicInfo.Controllers
{

    [Area("BasicInfo")]
    public class BranchDefinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
