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
            ViewBag.Message = "This is homepage of the Admin Control Panel.";
            ViewBag.Title = "Admin Home Page";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "This is the Admin login page.";
            ViewBag.Title = "Admin Login Page";
            return View();
        }
        public ActionResult ViewReport()
        {
            ViewBag.Message = "This is the admin page to view attendance reports";
            ViewBag.Title = "Attendance Report Page";
            return View();
        }

        public ActionResult ModifyPanel()
        {
            ViewBag.Title = "Modify Panel Page";
            ViewBag.Message = "This is the admin page to modify records.";

            return View();
        }

        public ActionResult EditCalendar()
        {
            ViewBag.Title = "Override Calendar Page";
            ViewBag.Message = "This is the admin page to edit calendar";

            return View();
        }

        public ActionResult EditAttendance()
        {
            ViewBag.Title = "Edit Attendance Page";
            ViewBag.Message = "This is the admin page to edit attendance.";

            return View();
        }

        public ActionResult Unenroll()
        {
            ViewBag.Title = "Unenroll Student Page";
            ViewBag.Message = "This is the admin page to unenroll student.";

            return View();
        }
    }
}