using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using OSharp.Core;
using $rootnamespace$.Dtos;
using $rootnamespace$.Security;
using OSharp.SiteBase;
using OSharp.Web.Mvc.Routing;

namespace $rootnamespace$
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RoutesRegister();
            DtoMappers.RegisterMappers();
            
            IOSharpInitializer initializer = new OSharpInitializer()
            {
                FunctionHandler = new FunctionHandler(),
                EntityInfoHandler = new EntityInfoHandler()
            };
            initializer.Initialize();
        }

        private static void RoutesRegister()
        {
            RouteCollection routes = RouteTable.Routes;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapLowerCaseUrlRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "$rootnamespace$.Controllers" });
        }
    }
}