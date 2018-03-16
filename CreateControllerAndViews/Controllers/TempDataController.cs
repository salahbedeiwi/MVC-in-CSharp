using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateControllerAndViews.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData

        public ActionResult Index()
        {

            return View();
        }
        //url: TempData/Sample
        public ActionResult Sample()
        {
            //say i like to pass temporary data to another controller
            TempData["name"] = "Salah"; //short session live
            TempData["TodayDate"] = DateTime.Now;
            Session["Active"] = "Active"; //Session is same as TempData
            //note sessions and TempData will be passed to the other controllers
            //NOTE: I can't pass values by ViewData or ViewBag to another controller
            //it will lose its value
            ViewData["age"] = 29; // => will not work/Can't pass it to other controllers
            //it redirects to other controller only TempData
            /* 
             * redirect or call another action: one way to call 
             * the controller right away if in the same page
             * return RedirectToAction("SampleView","TempData"); 
             * ----> redirect to SampleView Action In Controll TempData 
            */
            //redirect to SampleView Action In Controll TempData
            //, "TempData" is optional since same page
            //call action SampleView - SampleView will return Sample page
            //note: new url is changed to TempData/SampleView, even i set it up to Sample()
            return RedirectToAction("SampleView", "TempData");
            //redirect, means change the url. or everytime i go to 
            //redirect also means, pass all info on this action 
            //method to the new controller SampleView
            //if you enter TempData/Sample, changes the url right away to TempData/SampleView
        }
        //url: TempData/SampleView
        public ActionResult SampleView()
        {
            //make sure that TempData["name"] is live/found and value isn't empty 
            //you can validate and write all TempData here as well
            if (TempData.ContainsKey("name") && TempData["name"] != null)
            {
              ViewData["school"] = "UMN"; //Will work normal when i call it
            }
            //if we don't have TempData.Keep(); by refreshing page, info is no longer available
            TempData.Keep();//note if we refresh the page, info still exists.
            //this must be outside the if loop, because it doesn't, will be cleared after the page and
            //value of it will be null.but outside it still retain/keep its value.
            //note: values doesn't change. Time doesn't change as well. Sessions
            return View("Sample");//return page TempData/Sample
        }
        //url or httpGet : TempData/SampleViewTwo
        public ActionResult SampleViewTwo()
        {
            string myDate = "";
            string myName = "";
            if ( 
                (TempData.ContainsKey("TodayDate") && TempData["TodayDate"] != null) &&
                (TempData.ContainsKey("name") && TempData["name"] != null)
               )
            {
                myDate = TempData["TodayDate"].ToString();
                myName = TempData["name"].ToString();
            }
            ViewData["callMyDate"] = myDate; //will work, why? because data are retained by TempData.Keep();
            ViewData["nameIs"] = myName;
            //i can call this myDate on TempData/SampleViewTwo
            //Note i can call @session on my SampleViewTwo page normally and value is never gone.
            //note also, i must run SampleView first before this one, so i can get the value from there

            return View();
        }
    }
}