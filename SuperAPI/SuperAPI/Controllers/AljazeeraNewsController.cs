using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class AljazeeraNewsController : Controller
    {
        // GET: AljazeeraNews
        public ActionResult Index()
        {
            var aljazeeraNews = Services.AljazeeraAPIServices.GetAljazeeraNews();

            return View(aljazeeraNews);
        }
    }
}