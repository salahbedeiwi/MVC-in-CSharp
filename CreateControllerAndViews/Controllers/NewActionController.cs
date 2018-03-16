using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class NewActionController : Controller
    {
        // GET: NewAction/ActionOne
        [ActionName("ActionOne")] //let ActionOne be alternative name for Index action method.
        //remember, you must set this up on RouteConfig.cs and name the view page as ActionOne.cshtml
        public ActionResult Index()
        {
            return View();
        }
    }
}