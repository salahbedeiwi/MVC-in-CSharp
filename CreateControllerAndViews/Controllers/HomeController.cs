using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index  or home/index
        public ActionResult Index()
        {
            return View();
        }
    }
}