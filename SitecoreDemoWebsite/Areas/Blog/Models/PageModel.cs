using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemoWebsite.Areas.Blog.Models
{
    public class PageModel : BaseItem
    {
        public string PageHeader { get; set; }
        public string Body { get; set; }

        public DateTime Date { get; set; }
    }
}