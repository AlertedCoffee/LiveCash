using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCash
{
    public partial class Director : Form
    {
        public Director(SqlConnection connection)
        {
            InitializeComponent();
            _myConnection = connection;
        }

        SqlConnection _myConnection;

        private void button1_Click(object sender, EventArgs e)
        {
            string ComDel = $" Select Employee.appointment from Users, Employee where [password] = '{PasswordTextBox.Text}' and [login] = '{LoginTextBox.Text}'";
            SqlCommand cmd = new SqlCommand(ComDel, _myConnection);
            string appointment = cmd.ExecuteScalar()?.ToString();


            switch (appointment)
            {
                case "Директор":
                    MessageBox.Show("внатуре", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Отказано в доступе", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
