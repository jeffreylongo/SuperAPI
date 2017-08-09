using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class IgnNewsController : Controller
    {
        // GET: IgnNews
        public ActionResult Index()
        {
            var ignStories = Services.IgnApiServices.GetIgnNews();

            return View(ignStories);
        }
    }
}