using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoyageofSeno.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Story()
        {
            return View();
        }
        public ActionResult Objective()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}
