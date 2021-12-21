using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class PersonController : Controller
    {
       public ActionResult List()
        {
            int a = 11;
            int b = 15;
            int c = a + b;

            ViewBag.A = a; /* this ViewBag is responsible for sending data to view*/
            ViewBag.B = b;
            ViewBag.C = c;

            /*Another ViewBag using array*/
            string[] names = new string[3];
            names[0] = "Ahad";
            names[1] = "Ridowan";
            names[2] = "Muhammad";

            ViewBag.Names = names;
            ViewData["A"] = a;/*Viewdata is a ditionary, dictionary is for key value pair*/

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}