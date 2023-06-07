using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCash.ManagerForms
{
    public partial class AddClientForm : Form
    {
        public AddClientForm(SQLHelper helper, ManagerClientsForm mainForm)
        {
            InitializeComponent();
            _helper = helper;
            _mainForm = mainForm;
        }

        SQLHelper _helper;
        ManagerClientsForm _mainForm;

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.AddClient(ID.Value.ToString(), firstName.Text, lastName.Text, MiddleName.Text, Address.Text, Telephone.Text);
                _mainForm.DGInit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AddEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
