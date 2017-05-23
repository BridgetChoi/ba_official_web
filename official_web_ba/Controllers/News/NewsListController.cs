using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace official_web_ba.Controllers.News
{
    public class jsonTest
    {
        public int sr = 0;
        public string name = string.Empty;
        public string location = string.Empty;
        public string language = string.Empty;
    }

    public class test
    {
        public List<jsonTest> lstjson = null;
        public int totalPages = 40;
        public int currPage = 4;
        public int pageLimit = 5;
        public string link = string.Empty;
    }

    public class NewsListController : Controller
    {
        // GET: NewsList
        public ActionResult Index()
        {
            return View("~/Views/News/NewsList.cshtml");
        }

        public string strJsonTest()
        {
            List<jsonTest> strjson = new List<jsonTest> {
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo1</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish2</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo3</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish4</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo5</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish6</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo7</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish8</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo9</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish10</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo11</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish12</a>", location = "Mountain View", language = "CSS" },
                new jsonTest { sr = 1, name = "<a>Amey Sakhadeo13</a>", location = "Pune", language = "Javascript" },
                new jsonTest { sr = 1, name = "<a>Paul Irish14</a>", location = "Mountain View", language = "CSS" },
            };

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return "{\"data\" :" + serializer.Serialize(strjson) + "}";
        }
    }
}