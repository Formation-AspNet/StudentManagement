using StudentManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Bonjour Controller";
        }

        public string number_students()
        {
            StudentContext context = new StudentContext();
            int number_of_students = context.Students.Count();
            return string.Format("Nombre des étudiants {0}", number_of_students);
        }
    }
}

