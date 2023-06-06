using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCash.DirectorForms
{
    public partial class PaymentsDirectorForm : Form
    {
        public PaymentsDirectorForm(SQLHelper helper)
        {
            InitializeComponent();
            _helper = helper;
        }

        private SQLHelper _helper;

        private void EmployeeDirectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void HistoryDGInit()
        {
            try
            {
                HistoryDataGridView.Columns.Clear();
                HistoryDataGridView.Columns.Add("FIO", "ФИО");
                HistoryDataGridView.Columns.Add("creditID", "ID кредита");
                HistoryDataGridView.Columns.Add("clientID", "ID клиента");
                HistoryDataGridView.Columns.Add("startDate", "Дата начала");
                HistoryDataGridView.Columns.Add("endDate", "Дата окончания");
                HistoryDataGridView.Columns.Add("sum", "Сумма");
                HistoryDataGridView.Columns.Add("paid", "Выплачен");
                HistoryDataGridView.Columns.Add("overduePayments", "Просроченных платежей");


                var list = _helper.GetClientHistory();
                foreach (var item in list)
                {
                    HistoryDataGridView.Rows.Add(item);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PaymentsDGInit(int creditID)
        {
            try
            {
                PaymentsDataGridView.Columns.Clear();
                PaymentsDataGridView.Columns.Add("paymentID", "ID платежа");
                PaymentsDataGridView.Columns.Add("sum", "Сумма");
                PaymentsDataGridView.Columns.Add("date", "Дата оплаты");
                PaymentsDataGridView.Columns.Add("paid", "Выплачен");
                PaymentsDataGridView.Columns.Add("overdue", "Дни просрочки");


                var list = _helper.GetPayments(creditID);
                foreach (var item in list)
                {
                    PaymentsDataGridView.Rows.Add(item);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DebtorsDGInit()
        {
            try
            {
                DebtorsDataGridView.Columns.Clear();
                DebtorsDataGridView.Columns.Add("creditID", "ID кредита");
                DebtorsDataGridView.Columns.Add("clientID", "ID клиента");


                var list = _helper.GetDebtors();
                foreach (var item in list)
                {
                    DebtorsDataGridView.Rows.Add(item);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PaymentsDirectorForm_Load(object sender, EventArgs e)
        {
            HistoryDGInit();
            PaymentsDGInit(Convert.ToInt32(HistoryDataGridView["creditID", HistoryDataGridView.CurrentCell.RowIndex].Value));
            DebtorsDGInit();
        }

        private void HistoryDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            PaymentsDGInit(Convert.ToInt32(HistoryDataGridView["creditID", HistoryDataGridView.CurrentCell.RowIndex].Value));
        }

        private void CheckDebtorsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
