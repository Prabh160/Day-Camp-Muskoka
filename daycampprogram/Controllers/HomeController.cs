﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daycampprogram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult StaffDashboard()
        {
            return View();
        }

        public ActionResult signedIn()
        {
            return View();
        }

    }
}