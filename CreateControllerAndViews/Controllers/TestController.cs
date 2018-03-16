using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        /// <summary>
        /// ViewData saves and stores attributes as in array.
        /// Every public method on my controller is an action method
        /// </summary>
        /// <returns>The action ResultDate and all info inside this action method</returns>
        public ActionResult ResultDate()
        {
            ViewData["date"] = DateTime.Now;
            ViewData["name"] = "Salah";
            ViewData["age"] = 29;
            return View(); 
            //coming from ViewResult Class that hav base class from ActionResult
        }
        public ActionResult ResultDateBag()
        {
            ResultDate(); //get all info here from ResultDate();
            //note: i added this here to avoid asking me for ViewData['date/name/age'] on Test/ResultDateBag
            ViewBag.email = "Bedeiwi@something.com"; //dynamic property -> anonymous dynamic property inside class
            ViewBag.address = "Minnesota, USA";
            ViewBag.phone = "612-644-1634"; //Note i can use ViewData["phone"]
            //don't ever have the key name of ViewData & ViewBag
            ViewBag.classes = new object[] { "Computer Science", 5, 3.8}; //classname, # of credits & gpa
            ViewBag.schools = new object[] { "Computer Science", "NCC", "UMN"}; //highschool, college & univ.
            //dynamic variable classes can hold any data inside it
            //dynamic info = {150,"hi", methodName, enumInfo}
            return View("ResultDate"); //let it return same page of Test/ResultDate
        }
    }
}