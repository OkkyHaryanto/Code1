using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService.webservice;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        FirstcodeClient client = new FirstcodeClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.Message();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}