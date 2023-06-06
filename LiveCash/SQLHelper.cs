using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private SqlCommand UseQuery(string Query)
        {
                return new SqlCommand(Query, Connection);
        }

        public string Login(string login, string password)
        {
            if (login == null || login == "" || password == null || password == "") { throw new Exception("Поля логина и пароля должны быть заполнены"); }
            
            string Query = $" Select Employee.appointment from Users, Employee where [password] = '{password}' and [login] = '{login}'";
            return UseQuery(Query).ExecuteScalar()?.ToString();
        }


        public List<string[]> GetEmployeeList()
        {
            var list = new List<string[]>();

            string Query = $" Select * from Employee";

            SqlDataReader reader = UseQuery(Query).ExecuteReader();
            while (reader.Read())
            {
                var employee = new string[8];
                for (int i = 0; i < employee.Length; i++)
                {
                    employee[i] = reader[i].ToString();
                }

                list.Add(employee);
            }
            reader.Close();

            return list;
        }
        
        public void UpdateEmployee(DataGridViewRow row)
        {
            string Query = $"update Employee set firstName = '{row.Cells[1].Value}'," +
                $"lastName = '{row.Cells[2].Value}'," +
                $"middleName = '{row.Cells[3].Value}'," +
                $"date = '{row.Cells[4].Value}'," +
                $"appointment = '{row.Cells[5].Value}'," +
                $"address = '{row.Cells[6].Value}'," +
                $"telephoneNumber = '{row.Cells[7].Value}' " +
                $"where ID = '{row.Cells[0].Value}'";

            UseQuery(Query).ExecuteNonQuery();
        }

        public void DeleteEmployee(DataGridViewRow row)
        {
            string Query = $"delete Employee where ID = '{row.Cells[0].Value}'";
            UseQuery(Query).ExecuteNonQuery();
        }

        public void AddEmployee(string ID, string firstName, string lastName, 
                                string middleName, string date, string appointment,
                                string address, string telephoneNumber)
        {
            string Query = $"insert into Employee " +
                $"values ({ID}, '{firstName}', '{lastName}', '{middleName}', '{date}', " +
                $"'{appointment}', '{address}', '{telephoneNumber}')";

            UseQuery(Query).ExecuteNonQuery();
        }
    }
}
