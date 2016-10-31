using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MissionSite.Controllers
{
    
    /*Breadcrum methods*/
    public class HomeController : Controller
    {
        public ActionResult HOMES()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult DEGREE()
        {
            return View("~/Views/Home/Missions.cshtml");
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
       
        public ActionResult Missions()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            List<SelectListItem> subject = new List<SelectListItem>();
            subject.Add(new SelectListItem { Text = "BSIS", Value = "0" });
            subject.Add(new SelectListItem { Text = "MISM", Value = "1" });
            subject.Add(new SelectListItem { Text = "Other", Value = "2" });
            ViewBag.Subject = subject;
            return View();
        }
    }
}