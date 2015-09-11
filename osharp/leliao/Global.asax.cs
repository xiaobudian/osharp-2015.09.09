using OSharp.Autofac;
using OSharp.Core;
using OSharp.Demo.Dtos;
using OSharp.SiteBase.Initialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OSharp.Web.Mvc.Routing;

namespace leliao
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
            DtoMappers.MapperRegister();

            Initialize();
        }

     

        private static void Initialize()
        {
            //ICacheProvider provider = new RuntimeMemoryCacheProvider();
            //CacheManager.SetProvider(provider, CacheLevel.First);

            IFrameworkInitializer initializer = new FrameworkInitializer()
            {
                MvcIocInitializer = new AutofacMvcIocInitializer()
            };
            initializer.Initialize();
        }
    }
}
