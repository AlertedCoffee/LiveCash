using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCash
{
    public class SQLHelper
    {
        public SqlConnection Connection;
        private string connectionString = @" Data Source=ALERTEDCOFFEE\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True; ";

        public SQLHelper() 
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public string Login(string login, string password)
        {
            if (login == null || login == "" || password == null || password == "") { throw new Exception("Поля логина и пароля должны быть заполнены"); }
            string ComDel = $" Select Employee.appointment from Users, Employee where [password] = '{password}' and [login] = '{login}'";
            SqlCommand cmd = new SqlCommand(ComDel, Connection);
            return cmd.ExecuteScalar()?.ToString();
        }
    }
}
