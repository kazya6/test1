using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DegreesController : Controller
    {
        public ActionResult FAQ1 (int FAQ)
        {
            
            if (FAQ == 1)
        {
            ViewBag.FAQ = "Why should I major in IS?";
        }
            
            if (FAQ == 2)
            {
                ViewBag.FAQ = "Is IS program challenging?";
            }

            if (FAQ == 3)
            {
                ViewBag.FAQ = "How are the professors? Are they cool?";
            }
         
         return View("~/Views/Home/FAQVIEW.cshtml");

        }
        public ActionResult Degrees (string Degrees)
        {
            if (Degrees == "BSIS")
            {
                ViewBag.degreename = "BSIS";
                
                ViewBag.degreecoordinator = "Dr. Albrecht";
                ViewBag.titles = "Bachelor of Science in Information Systems";
                ViewBag.officeaddress = "1000 N 1000 E Provo, UT, 84605";
                ViewBag.phd = "phD Education";
                ViewBag.masters = "Masters Education";
                ViewBag.bachelors = "Bachelors Education";
                ViewBag.picture = "Pictures";
                
            }

            if (Degrees == "MISM")
            {
                ViewBag.degreename = "MISM";
                ViewBag.degreecoordinator = "Dr. Bonnie Anderson";
                ViewBag.title = "Masters of Information Systems Management";
                ViewBag.officeaddress = "1000 N 1000 E Provo, UT, 84064";
                ViewBag.phd = "phD Education";
                ViewBag.masters = "Masters Education";
                ViewBag.bachelors = "Bachelors Education";
                ViewBag.picture = "Their Pictures";
            }

            return View();
        }
    }
}