using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gittest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (1 == 3)
            {

            }
            else
            {
                var test = "hest2";
            }

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}