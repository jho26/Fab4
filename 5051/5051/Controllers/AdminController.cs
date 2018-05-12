using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "This is the Admin Control Panel.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "This is the Admin login page.";

            return View();
        }

    }
}