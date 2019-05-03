﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}