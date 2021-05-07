using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amKings.Models;
namespace MVC8amKings.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        [Route("Superman/shopping")]
        [Route("batman/cricket")]
        public string  helloworld() {

            return "Hello to All";
        }

        private int helloworld2()
        {

            return 1211;
        }
        [NonAction]
        public int helloworld3()
        {
            return 1211;
        }

        public int helloworld4()
        {
            return 1211;
        }

        
        public ActionResult getView()
        {

            return View();
        }

        public ActionResult getView2()
        {

            return View("Contact");
        }

       
        public ActionResult getViewofDefault()
        {

            return View("~/Views/Default/index.cshtml");
        }
        public string helloworld12(string id)
        {

            return "Hello to All "+ id;
        }
        public ActionResult sendName() {

            ViewBag.Cricket = "Adam Gilcrist";
            return View();
        }

        public ActionResult sendName2()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Trupti";
            obj.EmpSalary = 578000;


            ViewBag.Cricket = obj;
            return View();
        }

        public ActionResult sendName3()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Trupti";
            obj.EmpSalary = 578000;


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Dash";
            obj1.EmpSalary = 538000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Namaithullah";
            obj2.EmpSalary = 378000;


            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 4;
            obj3.EmpName = "ElayRaja";
            obj3.EmpSalary = 478000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(obj);
            listEmp.Add(obj1);
            listEmp.Add(obj2);
            listEmp.Add(obj3);



            ViewBag.EmpInfo = listEmp;


            return View();
        }

        public ActionResult sendName4()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Trupti";
            obj.EmpSalary = 578000;

            // object model = obj;

          
            return View(obj);
        }


        public ActionResult sendName5()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Trupti";
            obj.EmpSalary = 578000;


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Dash";
            obj1.EmpSalary = 538000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Namaithullah";
            obj2.EmpSalary = 378000;


            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 4;
            obj3.EmpName = "ElayRaja";
            obj3.EmpSalary = 478000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(obj);
            listEmp.Add(obj1);
            listEmp.Add(obj2);
            listEmp.Add(obj3);

            return View(listEmp);
        }

        public ViewResult sendName6()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Trupti";
            obj.EmpSalary = 578000;


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Dash";
            obj1.EmpSalary = 538000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Namaithullah";
            obj2.EmpSalary = 378000;


            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 4;
            obj3.EmpName = "ElayRaja";
            obj3.EmpSalary = 478000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(obj);
            listEmp.Add(obj1);
            listEmp.Add(obj2);
            listEmp.Add(obj3);


            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1211;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 1211;
            dept2.DeptName = "Network";

            List<DepartmentModel> listdept = new List<DepartmentModel>();

            listdept.Add(dept1);
            listdept.Add(dept2);

            EmpDept empdeptObj = new Models.EmpDept();
            empdeptObj.emp =listEmp;
            empdeptObj.dept =listdept;


            return View(empdeptObj);
        }

        public ViewResult getmeView() {

            return View();
        }
    }
}