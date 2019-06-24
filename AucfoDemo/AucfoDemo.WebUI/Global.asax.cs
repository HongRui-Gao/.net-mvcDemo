using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AucfoDemo.WebUI.App_Start;

namespace AucfoDemo.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AutofacConfig.Register();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
