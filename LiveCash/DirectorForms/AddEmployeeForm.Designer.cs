namespace LiveCash.DirectorForms
{
    partial class AddEmployeeForm
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
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Appointment = new System.Windows.Forms.ComboBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(35, 50);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(64, 22);
            this.ID.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(163, 49);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 1;
            // 
            // Appointment
            // 
            this.Appointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Appointment.FormattingEnabled = true;
            this.Appointment.Items.AddRange(new object[] {
            "Менеджер",
            "Коллектор"});
            this.Appointment.Location = new System.Drawing.Point(431, 47);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(215, 24);
            this.Appointment.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(35, 100);
            this.firstName.MaxLength = 35;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(151, 22);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "Имя";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(231, 100);
            this.lastName.MaxLength = 35;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(153, 22);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Фамилия";
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(431, 100);
            this.MiddleName.MaxLength = 35;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(215, 22);
            this.MiddleName.TabIndex = 3;
            this.MiddleName.Text = "Отчество";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(35, 153);
            this.Address.MaxLength = 255;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(151, 22);
            this.Address.TabIndex = 3;
            this.Address.Text = "Адресс";
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(353, 153);
            this.Telephone.MaxLength = 11;
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(153, 22);
            this.Telephone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата трудоустройства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер телефона";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(540, 146);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 213);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Appointment);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployeeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Appointment;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}