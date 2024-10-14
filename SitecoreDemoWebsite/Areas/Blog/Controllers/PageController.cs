using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreDemoWebsite.Areas.Blog.Controllers
{
    public class PageController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}