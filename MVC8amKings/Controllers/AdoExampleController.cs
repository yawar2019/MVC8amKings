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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }


        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.deleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
    }
}