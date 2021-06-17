using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleErorHandling.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            try
            {
                int a = 10, b = 0, c;
                c = a / b;
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }
       [HandleError(View="Error2")]
        public ActionResult TestErrorExample()
        {
            try
            {
                int a = 10, b = 0, c;
                c =a/b;
            } 
            catch (Exception)
            {

                throw;
            }
            return View();
        }
    }
}