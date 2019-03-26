using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redirecter.Controllers
{
    public class HomeController : Controller
    {

        const string baseUrl = "https://whereshouldibuy.apphb.com";

        [OutputCache(Duration = int.MaxValue)]
        public ActionResult Index(string q = "", string country = "us")
        {
            UriBuilder builder = new UriBuilder(baseUrl);

            if (!string.IsNullOrEmpty(q))
            {
                builder.Path = country + "/" + q;
            }

            return RedirectPermanent(builder.Uri.ToString());
        }

    }
}
