using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagement.Models;
using StudentManagement.Models.EF;

namespace StudentManagement.Controllers
{
    /// <summary>
    /// Students controller : Solution 1
    /// </summary>
    public class Students_1Controller : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: Students_1
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.Group);
            return View(students.ToList());
        }

        // GET: Students_1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }


        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.GroupId = new SelectList(db.Groups, "GroupId", "Name");
            ViewBag.Teams = new SelectList(db.Teams, "TeamId", "TeamName");
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "StudentId,StudentName,Age,Email,GroupId")]
            Student student, List<string> Teams
            )
        {
            ViewBag.GroupId = new SelectList(db.Groups, "GroupId", "Name", student.GroupId);

            List<Team> selectedTeams = new List<Team>();
            if (Teams != null)
            {
                foreach (string s in Teams)
                {
                    int i = int.Parse(s);
                    Team team = db.Teams.Where(t => t.TeamId == i).FirstOrDefault();
                    if (team != null)
                    {
                        selectedTeams.Add(team);
                    }
                }
            }

            if (ModelState.IsValid)
            {
                student.Teams = selectedTeams;
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(student);
        }


        // GET: Students_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.GroupId = new SelectList(db.Groups, "GroupId", "Name", student.GroupId);
            return View(student);
        }

        // POST: Students_1/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,StudentName,Age,GroupId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GroupId = new SelectList(db.Groups, "GroupId", "Name", student.GroupId);
            return View(student);
        }

        // GET: Students_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
