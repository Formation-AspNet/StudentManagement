using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class ArithmeticOperationController : Controller
    {
        // GET: ArithmeticOperation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Addition(float? x = null, float? y = null)
        {
            if (x != null && y != null)
            {
                ViewBag.x = x;
                ViewBag.y = y;
                ViewBag.result_addition = x + y;

            }
            return View();
        }
    }
}