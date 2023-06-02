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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection _myConnection;

        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = @" Data Source=ALERTEDCOFFEE\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True; ";
                _myConnection = new SqlConnection(connectionString);
                _myConnection.Open();

                string ComDel = $" Select Employee.appointment from Users, Employee where [password] = '{PasswordTextBox.Text}' and [login] = '{LoginTextBox.Text}'";
                SqlCommand cmd = new SqlCommand(ComDel, _myConnection);
                string appointment = cmd.ExecuteScalar()?.ToString();


                Thread thread = null;
                switch (appointment)
                {
                    case "Директор":
                        thread = new Thread(Run => Application.Run(new Director(_myConnection)));
                        break;
                    default:
                        MessageBox.Show("Отказано в доступе", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                this.Close();
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
