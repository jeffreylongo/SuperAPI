using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class WsjNewsController : Controller
    {
        // GET: WsjNews
        public ActionResult Index()
        {
            var wsjNews = Services.WsjApiServices.GetWsjNews();

            return View(wsjNews);
        }
    }
}