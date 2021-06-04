using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.Employees.Add(emp);//insert Query
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");//hi
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State = EntityState.Modified;  
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");//hi
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleConfirmed(int? id)
        {
            EmployeeModel emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");//hi
            }
            else
            {
                return View();
            }
        }
    }
}