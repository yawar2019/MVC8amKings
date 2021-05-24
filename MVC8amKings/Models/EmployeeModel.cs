using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace MVC8amKings.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public bool status { get; set; }
    }

    public class EmpDetail
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<EmployeeModel> getEmployees()
        {
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

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaAddEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public EmployeeModel getEmployeeById(int ? id)
        {
            EmployeeModel emp = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("sp_RajagetEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

                
            }
            return emp;
        }

        

             public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaUpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int deleteEmployee(int? id)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaDeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        
    }
}