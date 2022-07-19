using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADO.NETCORE.DbConfig;
using ADO.NETCORE.Models;
using Microsoft.Data.SqlClient;
using System.Data; 

namespace ADO.NETCORE.DataAccess
{
    public class EmployeDataContext
    {
        ConnectDb db = new ConnectDb();
        public List<Employees> GetEmployees()
        {
            string sp = "usp_get_Employes";
            SqlCommand cmd = new SqlCommand(sp,db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            if (db.sql.State == ConnectionState.Closed)
            {
                db.sql.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employees> lst = new List<Employees>();
            while (reader.Read())
            {
                Employees obj = new Employees();
                obj.ID = (int)reader[0];
                obj.Name = reader[1].ToString();
                obj.Email = reader[2].ToString();
                obj.Mobile = reader[3].ToString();
                obj.Gender = reader[4].ToString();
                obj.dept = reader[5].ToString();
                lst.Add(obj);
            }
            db.sql.Close();
            return lst;
        }
    }
}
