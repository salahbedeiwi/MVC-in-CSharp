using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class QueryStringController : Controller
    {
        // GET: QueryString/index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users(int userId, string userName)
        {
            TempData["printInfo"] = string.Format("Your name is {0} and Id is {1}", userName, userId);
            ViewBag.msg = TempData["printInfo"];
            TempData.Keep();
            return View(); //return Users page
        }
    }
}