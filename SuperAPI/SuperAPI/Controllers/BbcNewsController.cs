using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class BbcNewsController : Controller
    {
        // GET: BbcNews
        public ActionResult Index()
        {
            var bbcNews = Services.BBCApiServices.GetBBCNews();

            return View(bbcNews);
        }
    }
}