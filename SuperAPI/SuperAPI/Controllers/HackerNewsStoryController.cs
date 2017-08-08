using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAPI.Controllers
{
    public class HackerNewsStoryController : Controller
    {
        // GET: HackerNewsStory
        public ActionResult Index()
        {
            var hackerNewsStories = Services.HackerNewsAPIServices.GetHackerNews();

            return View(hackerNewsStories);
        }
    }
}