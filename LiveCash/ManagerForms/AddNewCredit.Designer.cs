namespace LiveCash.ManagerForms
{
    partial class AddNewCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreditIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientIDNumericUpDown
            // 
            this.ClientIDNumericUpDown.Location = new System.Drawing.Point(24, 47);
            this.ClientIDNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ClientIDNumericUpDown.Name = "ClientIDNumericUpDown";
            this.ClientIDNumericUpDown.Size = new System.Drawing.Size(74, 22);
            this.ClientIDNumericUpDown.TabIndex = 0;
            // 
            // CreditIDNumericUpDown
            // 
            this.CreditIDNumericUpDown.Location = new System.Drawing.Point(134, 47);
            this.CreditIDNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CreditIDNumericUpDown.Name = "CreditIDNumericUpDown";
            this.CreditIDNumericUpDown.Size = new System.Drawing.Size(74, 22);
            this.CreditIDNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID кредита";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(274, 47);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата выдачи средств";
            // 
            // PeriodNumericUpDown
            // 
            this.PeriodNumericUpDown.Location = new System.Drawing.Point(521, 47);
            this.PeriodNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PeriodNumericUpDown.Name = "PeriodNumericUpDown";
            this.PeriodNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.PeriodNumericUpDown.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Период в неделях";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(24, 123);
            this.SumTextBox.MaxLength = 11;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(104, 22);
            this.SumTextBox.TabIndex = 3;
            this.SumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Сумма кредита";
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Location = new System.Drawing.Point(173, 123);
            this.CountNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.CountNumericUpDown.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Кол-во обращение";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(490, 100);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(152, 45);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Внести данные";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 270);
            this.dataGridView1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "План платежей";
            // 
            // AddNewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeriodNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreditIDNumericUpDown);
            this.Controls.Add(this.ClientIDNumericUpDown);
            this.Name = "AddNewCredit";
            this.Text = "AddNewCredit";
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ClientIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown CreditIDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PeriodNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}