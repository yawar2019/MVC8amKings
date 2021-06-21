using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Models;

namespace WebService
{
    /// <summary>
    /// Summary description for EmployeeDetailService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeDetailService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<EmployeeModel> getEmployees()
        {
            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

            List<EmployeeModel> listemp = new List<Models.EmployeeModel>();
            SqlCommand cmd = new SqlCommand("sp_RajagetEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

                listemp.Add(emp);
            }
            return listemp;
        }
    }
}
