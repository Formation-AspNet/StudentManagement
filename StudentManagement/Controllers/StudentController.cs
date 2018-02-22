using StudentManagement.Models;
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
        StudentContext context; 
        public StudentController()
        {
            context = new StudentContext();
        }
        public ActionResult Index()
        {
            var studentList = context.Students.ToList();
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var student = context.Students.Where(s => s.StudentId == id)
                                 .FirstOrDefault();
            return View(student);
        }



        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                //write code to update student 
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}