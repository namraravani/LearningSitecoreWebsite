using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using Sitecore.Data;

namespace SitecoreDemoWebsite.Areas.Blog.Controllers
{
    public class PageController : Controller
    {

        public ActionResult Home()
        {
            var sourceItem = RenderingContext.Current.Rendering.Item;

            var pageModel = new Models.PageModel();

            pageModel.PageHeader = sourceItem["PageHeader"];
            pageModel.Body = sourceItem["Body"];

            DateField dateField = sourceItem.Fields["Date"];
            if(dateField != null )
            {
                pageModel.Date = dateField.DateTime;
            }
            return View("~/Areas/Blog/Views/Page/Home.cshtml", pageModel);
        }

        //public ActionResult getData() {
        //    Database database = Database.GetDatabase("Web");

        //    string itemPath
        //}

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