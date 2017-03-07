using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daycampprogram.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DailyCamperSheets()
        {
            return View();
        }

        public ActionResult AuthenticationReports()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }
    }
}