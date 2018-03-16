using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student or student/index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStudent() {
            ViewData["name"] = "Salah Bedeiwi";
            ViewData["age"] = 30;
            return View("index");
        } // if you enter student/GetStudent -> return student/index page
        public ActionResult Student() { return View(); } // return student/index
        public ActionResult AddStudent() { return this.View(); } // return student/AddStudent
    }
}