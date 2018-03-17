using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            // Rappell
            dynamic i = "";
            i.message = "";

            // Solution 1
            // ViewData["message"] = "il y a 30 stagiaires à la base de données";

            // Solution 2
            ViewBag.message = "il y a 30 stagiaires à la base de données";
           
            return View();
        }

        public ActionResult Addition(float? x = null,float? y = null)
        {
            if(x != null && y != null)
            {
                ViewBag.x = x;
                ViewBag.y = y;
                ViewBag.result_addition = x + y;

            }
            return View();
        }
    }
}