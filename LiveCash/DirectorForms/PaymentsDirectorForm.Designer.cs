namespace LiveCash.DirectorForms
{
    partial class PaymentsDirectorForm
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
            this.HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.PaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DebtorsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckDebtorsButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryDataGridView
            // 
            this.HistoryDataGridView.AllowUserToAddRows = false;
            this.HistoryDataGridView.AllowUserToDeleteRows = false;
            this.HistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataGridView.Location = new System.Drawing.Point(12, 36);
            this.HistoryDataGridView.Name = "HistoryDataGridView";
            this.HistoryDataGridView.ReadOnly = true;
            this.HistoryDataGridView.RowHeadersVisible = false;
            this.HistoryDataGridView.RowHeadersWidth = 51;
            this.HistoryDataGridView.RowTemplate.Height = 24;
            this.HistoryDataGridView.Size = new System.Drawing.Size(532, 540);
            this.HistoryDataGridView.TabIndex = 0;
            this.HistoryDataGridView.CurrentCellChanged += new System.EventHandler(this.HistoryDataGridView_CurrentCellChanged);
            // 
            // PaymentsDataGridView
            // 
            this.PaymentsDataGridView.AllowUserToAddRows = false;
            this.PaymentsDataGridView.AllowUserToDeleteRows = false;
            this.PaymentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsDataGridView.Location = new System.Drawing.Point(18, 263);
            this.PaymentsDataGridView.Name = "PaymentsDataGridView";
            this.PaymentsDataGridView.ReadOnly = true;
            this.PaymentsDataGridView.RowHeadersVisible = false;
            this.PaymentsDataGridView.RowHeadersWidth = 51;
            this.PaymentsDataGridView.RowTemplate.Height = 24;
            this.PaymentsDataGridView.Size = new System.Drawing.Size(480, 313);
            this.PaymentsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кредиты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Платежи";
            // 
            // DebtorsDataGridView
            // 
            this.DebtorsDataGridView.AllowUserToAddRows = false;
            this.DebtorsDataGridView.AllowUserToDeleteRows = false;
            this.DebtorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DebtorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtorsDataGridView.Location = new System.Drawing.Point(18, 44);
            this.DebtorsDataGridView.Name = "DebtorsDataGridView";
            this.DebtorsDataGridView.ReadOnly = true;
            this.DebtorsDataGridView.RowHeadersVisible = false;
            this.DebtorsDataGridView.RowHeadersWidth = 51;
            this.DebtorsDataGridView.RowTemplate.Height = 24;
            this.DebtorsDataGridView.Size = new System.Drawing.Size(480, 167);
            this.DebtorsDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Должники";
            // 
            // CheckDebtorsButton
            // 
            this.CheckDebtorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckDebtorsButton.Location = new System.Drawing.Point(308, 7);
            this.CheckDebtorsButton.Name = "CheckDebtorsButton";
            this.CheckDebtorsButton.Size = new System.Drawing.Size(190, 31);
            this.CheckDebtorsButton.TabIndex = 2;
            this.CheckDebtorsButton.Text = "Проверить должников";
            this.CheckDebtorsButton.UseVisualStyleBackColor = true;
            this.CheckDebtorsButton.Click += new System.EventHandler(this.CheckDebtorsButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.HistoryDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DebtorsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.CheckDebtorsButton);
            this.splitContainer1.Panel2.Controls.Add(this.PaymentsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 590);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.TabIndex = 0;
            // 
            // PaymentsDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PaymentsDirectorForm";
            this.Text = "PaymentsDirectorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeDirectorForm_FormClosed);
            this.Load += new System.EventHandler(this.PaymentsDirectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorsDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryDataGridView;
        private System.Windows.Forms.DataGridView PaymentsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DebtorsDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckDebtorsButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}