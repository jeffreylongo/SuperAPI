using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class ApNewsController : Controller
    {
        // GET: ApNews
        public ActionResult Index()
        {
            var apNews = Services.ApApiServices.GetAPNews();

            return View(apNews);
        }
    }
}