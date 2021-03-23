using Paup2021_Vjezbe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paup2021_Vjezbe.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Početna stranica o studentima";
            ViewBag.Fakultet = "Međimursko veleučilište u Čakovcu";

            return View();
        }
        public ActionResult Popis()
        {
            StudentiDB studenti = new StudentiDB();
            return View(studenti);
        }
        public ActionResult Detalji(int? id)
        {
            if(!id.HasValue)
            {
                return RedirectToAction("Popis");
            }

            StudentiDB studenti = new StudentiDB();
            Student student = studenti.VratiListu().FirstOrDefault(x => x.Id == id);

            if(student==null)
            {
                return RedirectToAction("Popis");
            }

            return View(student);
        }
        public ActionResult Azuriraj(int? id)
        {
            if(!id.HasValue)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            StudentiDB studentidb = new StudentiDB();
            Student student = studentidb.VratiListu().FirstOrDefault(x => x.Id == id);

            if(student==null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Azuriraj(Student s)
        {
            if(ModelState.IsValid)
            {
                StudentiDB studentiDb = new StudentiDB();
                studentiDb.AzurirajStudenta(s);
                return RedirectToAction("Popis");

            }
            return View(s);
        }
    }
}