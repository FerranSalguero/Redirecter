using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redirecter.Controllers
{
    public class HomeController : Controller
    {

        const string baseUrl = "http://wheretobuy.putinyourbasket.com";

        [OutputCache(Duration = 3600 * 48)]
        public ActionResult Index(string q = "")
        {
            UriBuilder builder = new UriBuilder(baseUrl);
            if (!string.IsNullOrEmpty(q)) builder.Path = q;

            ViewBag.Url = builder.Uri.ToString();

            Response.StatusCode = 301;
            Response.RedirectLocation = builder.Uri.ToString();

            //return RedirectPermanent(builder.Uri.ToString());

            return View();
        }

    }
}
