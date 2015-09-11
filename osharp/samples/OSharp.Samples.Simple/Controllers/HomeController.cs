using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSharp.Utility.Data;
using OSharp.Samples.Simple.Contracts;
using OSharp.Samples.Simple.Dtos.Samples;

namespace OSharp.Samples.Simple.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Samples");
        }
    }
}