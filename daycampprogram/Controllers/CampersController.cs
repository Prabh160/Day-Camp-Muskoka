using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daycampprogram.Controllers
{
    public class CampersController : Controller
    {
        // GET: Campers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateProfile()
        {
            return View();
        }
        public ActionResult SelectedProfile()
        {
            return View();
        }
    }
}