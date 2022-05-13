using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO_employee_Payroll
{
    internal class EmployeeRepository
    {
        //Give path for Database Connection
        public static string connection = @"Server=LAPTOP-ABMNAC9K\SQLEXPRESS;Database=payroll;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
