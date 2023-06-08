using LiveCash.DirectorForms;
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
    public partial class ManagerClientsForm : Form
    {
        public ManagerClientsForm(SQLHelper helper)
        {
            InitializeComponent();
            _helper = helper;
        }

        private SQLHelper _helper;

        private void EmployeeDirectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        public void DGInit()
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("ID", "ID клиента");
                dataGridView1.Columns.Add("firstName", "Имя");
                dataGridView1.Columns.Add("secondName", "Фамилия");
                dataGridView1.Columns.Add("middleName", "Отчество");
                dataGridView1.Columns.Add("address", "Адрес");
                dataGridView1.Columns.Add("telephoneNumber", "Номер телефона");
                dataGridView1.Columns.Add("state", "state");
                dataGridView1.Columns["state"].Visible = false;


                var clientList = _helper.GetClientsList();
                foreach (var client in clientList)
                {
                    dataGridView1.Rows.Add(client);
                    dataGridView1["state", dataGridView1.RowCount - 1].Value = RowState.Existed;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void EmployeeDirectorForm_Load(object sender, EventArgs e)
        {
            DGInit();
        }

        private void EditeButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            SaveButton.Visible = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.GridColor = System.Drawing.Color.IndianRed;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            EditeButton.Visible = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;


            try
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    if ((RowState)dataGridView1.Rows[index].Cells["state"].Value == RowState.Edited)
                    {
                        _helper.UpdateClient(dataGridView1.Rows[index]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DGInit();
        }

        private enum RowState
        {
            Existed,
            Edited
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["state"].Value = RowState.Edited;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.DeleteClient(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var AddForm = new AddClientForm(_helper, this);
            AddForm.ShowDialog();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var HistoryForm = new ManagerClientHistoryForm(_helper, Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentCell.RowIndex].Value));
                HistoryForm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
