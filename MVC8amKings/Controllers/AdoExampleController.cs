using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amKings.Models;

namespace MVC8amKings.Controllers
{
    public class AdoExampleController : Controller
    {
        // GET: AdoExample
        EmpDetail db = new EmpDetail();
        public ActionResult Index()
        {
            return View(db.getEmployees());
        }
    }
}