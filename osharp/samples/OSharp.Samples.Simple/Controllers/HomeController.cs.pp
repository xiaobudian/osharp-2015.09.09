using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSharp.Utility.Data;
using $rootnamespace$.Contracts;
using $rootnamespace$.Dtos.Samples;

namespace $rootnamespace$.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Samples");
        }
    }
}