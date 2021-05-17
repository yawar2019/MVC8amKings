using MVC8amKings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amKings.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id )
        {
            ViewBag.Number = id;
            return View();
        }

        public ActionResult Index2(EmployeeModel emp)
        {
            ViewBag.emp = emp;
            return View();
        }

        public ActionResult Index3(List<EmployeeModel> emp)
        {
            ViewBag.emp = emp;
            return View();
        }
    }
}