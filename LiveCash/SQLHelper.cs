using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCash
{
    internal class SQLHelper
    {
        public SqlConnection Connection;
        private string connectionString = @" Data Source=ALERTEDCOFFEE\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True; ";

        public SQLHelper() 
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public string Login(string login, string passord)
        {
            string ComDel = $" Select Employee.appointment from Users, Employee where [password] = '{passord}' and [login] = '{login}'";
            SqlCommand cmd = new SqlCommand(ComDel, Connection);
            return cmd.ExecuteScalar()?.ToString();
        }
    }
}
