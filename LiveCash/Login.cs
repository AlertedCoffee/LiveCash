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
                SQLHelper sqlHelper = new SQLHelper();

                string appointment = sqlHelper.Login(LoginTextBox.Text, PasswordTextBox.Text);


                Thread thread = null;
                switch (appointment)
                {
                    case "Директор":
                        thread = new Thread(Run => Application.Run(new Director(sqlHelper)));
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
