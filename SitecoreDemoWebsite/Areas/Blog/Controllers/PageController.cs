using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace SitecoreDemoWebsite.Areas.Blog.Controllers
{
    public class PageController : Controller
    {

        public ActionResult Home()
        {
            return View("~/Areas/Blog/Views/Page/Home.cshtml");
        }

        public ActionResult News()
        {
            return View("~/Areas/Blog/Views/Page/News.cshtml");
        }

        public ActionResult Contacts()
        {
            return View("~/Areas/Blog/Views/Page/Contacts.cshtml");
        }

        public ActionResult About()
        {
            return View("~/Areas/Blog/Views/Page/About.cshtml");
        }
    }
}