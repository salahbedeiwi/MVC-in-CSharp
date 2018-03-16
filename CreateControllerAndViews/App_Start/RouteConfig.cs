using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CreateControllerAndViews
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //QueryString/Users/userName/userId
            //http://localhost:51422/QueryString/Users/salah/15
            //http://localhost:51422/QueryString/Users/?userName=salah/userId=15
            routes.MapRoute(
                name: "QueryString",
                url: "{controller}/{action}/{userName}/{userId}",
                defaults: new { controller = "QueryString", action = "Users", id = UrlParameter.Optional,
                    userId = UrlParameter.Optional
                },
                constraints: new { userId = @"\d+" } //only numbers for UserId, else page will not be found
            );
            routes.MapRoute(
                name: "NewAction",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "NewAction", action = "ActionOne", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //defaults here call by default HOME/INDEX when running my app. no need to home/index (optional)
            );
            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //defaults here call by default HOME/INDEX when running my app. no need to home/index (optional)
            );
            */
            /* to run Test/ResultDateBag by default
             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", 
                defaults: new { controller = "Test", action = "ResultDateBag", id = UrlParameter.Optional }
                //defaults here call by default Test/ResultDateBag when running my app as default
            );
            */
        }
    }
}
