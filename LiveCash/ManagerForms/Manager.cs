using LiveCash.DirectorForms;
using LiveCash.ManagerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCash.EmployeeForms
{
    public partial class Manager : Form
    {
        public Manager(SQLHelper helper)
        {
            InitializeComponent();
            this._helper = helper;
        }
        private SQLHelper _helper;

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _helper.Connection.Close();
            Thread thread = new Thread(Run => Application.Run(new Login()));
            this.Close();
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        Form panel;

        private void OpenPanel(Form form)
        {
            panel?.Close();
            this.splitContainer1.Panel2.Controls.Clear();


            panel = form;
            panel.TopLevel = false;
            panel.Visible = true;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Focus();
            this.splitContainer1.Panel2.Controls.Add(panel);
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            OpenPanel(new ManagerClientsForm(_helper));
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            OpenPanel(new PaymentsDirectorForm(_helper));
        }
    }
}
