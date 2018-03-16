using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreateControllerAndViews.Models; //must be added here to call the model classes
namespace CreateControllerAndViews.Controllers
{
    public class NewStudentController : Controller
    {
        // GET: NewStudent
        public ActionResult Index()
        {
            //note var is anonymous class like dynamics
            var studentList = new List<Student>{
                            new Student() { ID = 1, NAME = "John"} ,
                            new Student() { ID = 2, NAME = "Steve"} ,
                            new Student() { ID = 3, NAME = "Bill"} ,
                            new Student() { ID = 4, NAME = "Ram"} ,
                            new Student() { ID = 5, NAME = "Ron"} ,
                            new Student() { ID = 4, NAME = "Chris"} ,
                            new Student() { ID = 4, NAME = "Rob"}
                        };
            // Get the students from the database in the real application

            return View(studentList);
        }
    }
}