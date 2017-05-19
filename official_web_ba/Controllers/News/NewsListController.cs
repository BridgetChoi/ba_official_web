using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace official_web_ba.Controllers.News
{
    public class NewsListController : Controller
    {
        // GET: NewsList
        public ActionResult Index()
        {
            return View();
        }
    }
}