using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult StudentDetails()
        {
            var student = new Student();
            student.Name = "Petro";
            student.Age = 25;

            return View(student);
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            var list = new List<Student>();
            if (ModelState.IsValid)
            {
                list.Add(student);
                return RedirectToAction(nameof(StudentDetails));
            }
            return View(student);
        }
    }
}