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
    public partial class ManagerClientHistoryForm : Form
    {
        public ManagerClientHistoryForm(SQLHelper helper, int clientID)
        {
            InitializeComponent();
            _helper = helper;
            _clientID = clientID;
        }

        private SQLHelper _helper;
        private int _clientID;

        private enum RowState
        {
            Existed,
            Edited
        }

        private void ManagerClientHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("creditID", "ID кредита");
                dataGridView1.Columns.Add("clientID", "ID клиента");
                dataGridView1.Columns.Add("startDate", "Дата начала");
                dataGridView1.Columns.Add("endDate", "Дата окончания");
                dataGridView1.Columns.Add("sum", "Сумма");
                dataGridView1.Columns.Add("paid", "Выплачен");
                dataGridView1.Columns.Add("overduePayments", "Кол-во просроченных платежей");
                dataGridView1.Columns.Add("state", "state");
                dataGridView1.Columns["state"].Visible = false;


                var List = _helper.GetClientHistoryList(_clientID);
                foreach (var item in List)
                {
                    dataGridView1.Rows.Add(item);
                    dataGridView1["state", dataGridView1.RowCount - 1].Value = RowState.Existed;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
