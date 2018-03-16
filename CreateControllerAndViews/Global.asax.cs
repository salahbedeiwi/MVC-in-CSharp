using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CreateControllerAndViews
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //must register any routes added on RouteConfig.cs here on the Application_Start() event
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //register all my application routes to include all routes into RouteTable
            RouteConfig.RegisterRoutes(RouteTable.Routes); 
        }
    }
}
