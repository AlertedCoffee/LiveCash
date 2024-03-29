﻿using LiveCash.DirectorForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCash
{
    public partial class Director : Form
    {
        public Director(SQLHelper helper)
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

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            OpenPanel(new EmployeeDirectorForm(_helper));
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            OpenPanel(new PaymentsDirectorForm(_helper));
        }
    }
}
