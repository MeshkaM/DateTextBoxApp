using Dapper;
using DateTextBoxApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTextBoxApp
{
    public class DataAccessLayer
    {
        private static readonly string ConnString = "Data Source=(local);Initial Catalog=CustomerDB;Integrated Security=True";

        public static List<CustomerModel> LoadCustomer()
        {
            using(IDbConnection conn = new SqlConnection(ConnString))
            {
                if(conn.State == ConnectionState.Closed) conn.Open();
                return conn.Query<CustomerModel>("SELECT * FROM Customers").ToList();
            }
        }
    }
}
