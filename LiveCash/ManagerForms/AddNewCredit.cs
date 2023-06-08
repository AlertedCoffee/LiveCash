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
    public partial class AddNewCredit : Form
    {
        public AddNewCredit(SQLHelper helper)
        {
            InitializeComponent();
            _helper = helper;
        }

        private SQLHelper _helper;

        private void SumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //цифры
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            //замена точки запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            //проверка на наличие запятых
            if (e.KeyChar == ',' && ((TextBox)sender).Text.IndexOf(',') == -1)
            {
                return;
            }

            //функциональные клавиши
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // нажата клавиша <Enter>
                    // установить курсор на кнопку Вычислить
                    EnterButton.Focus();
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }

        private void PaymentsDGInit(int creditID)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("paymentID", "ID платежа");
                dataGridView1.Columns.Add("sum", "Сумма");
                dataGridView1.Columns.Add("date", "Дата оплаты");
                dataGridView1.Columns.Add("paid", "Выплачен");
                dataGridView1.Columns.Add("overdue", "Дни просрочки");


                var list = _helper.GetPayments(creditID);
                foreach (var item in list)
                {
                    dataGridView1.Rows.Add(item);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_helper.ExistClient((int)ClientIDNumericUpDown.Value))
                {
                    _helper.AddCredit((int)CreditIDNumericUpDown.Value, (int)ClientIDNumericUpDown.Value, DateTimePicker.Value,
                                (int)PeriodNumericUpDown.Value, Convert.ToInt32(SumTextBox.Text), (int)CountNumericUpDown.Value);
                    PaymentsDGInit((int)CreditIDNumericUpDown.Value);
                }
                else MessageBox.Show("Такой клиент отсутствует в базе данных", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
