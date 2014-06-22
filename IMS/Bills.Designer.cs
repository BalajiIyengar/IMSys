namespace IMS
{
    partial class Bills
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
            this.checkBox_monthlyBill = new System.Windows.Forms.CheckBox();
            this.checkBox_dailyBill = new System.Windows.Forms.CheckBox();
            this.groupBox_userBills = new System.Windows.Forms.GroupBox();
            this.dataGridView_userBills = new System.Windows.Forms.DataGridView();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button_viewBill = new System.Windows.Forms.Button();
            this.groupBox_userBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userBills)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_monthlyBill
            // 
            this.checkBox_monthlyBill.AutoSize = true;
            this.checkBox_monthlyBill.Location = new System.Drawing.Point(85, 12);
            this.checkBox_monthlyBill.Name = "checkBox_monthlyBill";
            this.checkBox_monthlyBill.Size = new System.Drawing.Size(79, 17);
            this.checkBox_monthlyBill.TabIndex = 0;
            this.checkBox_monthlyBill.Text = "Monthly Bill";
            this.checkBox_monthlyBill.UseVisualStyleBackColor = true;
            this.checkBox_monthlyBill.CheckedChanged += new System.EventHandler(this.checkBox_monthlyBill_CheckedChanged);
            // 
            // checkBox_dailyBill
            // 
            this.checkBox_dailyBill.AutoSize = true;
            this.checkBox_dailyBill.Location = new System.Drawing.Point(279, 12);
            this.checkBox_dailyBill.Name = "checkBox_dailyBill";
            this.checkBox_dailyBill.Size = new System.Drawing.Size(65, 17);
            this.checkBox_dailyBill.TabIndex = 1;
            this.checkBox_dailyBill.Text = "Daily Bill";
            this.checkBox_dailyBill.UseVisualStyleBackColor = true;
            this.checkBox_dailyBill.CheckedChanged += new System.EventHandler(this.checkBox_dailyBill_CheckedChanged);
            // 
            // groupBox_userBills
            // 
            this.groupBox_userBills.Controls.Add(this.dataGridView_userBills);
            this.groupBox_userBills.Location = new System.Drawing.Point(85, 109);
            this.groupBox_userBills.Name = "groupBox_userBills";
            this.groupBox_userBills.Size = new System.Drawing.Size(338, 232);
            this.groupBox_userBills.TabIndex = 2;
            this.groupBox_userBills.TabStop = false;
            this.groupBox_userBills.Text = "User Bills";
            this.groupBox_userBills.Visible = false;
            // 
            // dataGridView_userBills
            // 
            this.dataGridView_userBills.AllowUserToAddRows = false;
            this.dataGridView_userBills.AllowUserToDeleteRows = false;
            this.dataGridView_userBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_userBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userBills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_userBills.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_userBills.Name = "dataGridView_userBills";
            this.dataGridView_userBills.ReadOnly = true;
            this.dataGridView_userBills.RowHeadersVisible = false;
            this.dataGridView_userBills.Size = new System.Drawing.Size(326, 239);
            this.dataGridView_userBills.TabIndex = 0;
            this.dataGridView_userBills.Visible = false;
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(26, 50);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(94, 21);
            this.comboBox_month.TabIndex = 3;
            this.comboBox_month.Visible = false;
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(142, 50);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(102, 21);
            this.comboBox_year.TabIndex = 4;
            this.comboBox_year.Visible = false;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(279, 50);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_date.TabIndex = 5;
            this.dateTimePicker_date.Visible = false;
            // 
            // button_viewBill
            // 
            this.button_viewBill.Location = new System.Drawing.Point(215, 80);
            this.button_viewBill.Name = "button_viewBill";
            this.button_viewBill.Size = new System.Drawing.Size(75, 23);
            this.button_viewBill.TabIndex = 6;
            this.button_viewBill.Text = "View Bill";
            this.button_viewBill.UseVisualStyleBackColor = true;
            this.button_viewBill.Visible = false;
            this.button_viewBill.Click += new System.EventHandler(this.button_viewBill_Click);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 353);
            this.Controls.Add(this.button_viewBill);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.groupBox_userBills);
            this.Controls.Add(this.checkBox_dailyBill);
            this.Controls.Add(this.checkBox_monthlyBill);
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.groupBox_userBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_monthlyBill;
        private System.Windows.Forms.CheckBox checkBox_dailyBill;
        private System.Windows.Forms.GroupBox groupBox_userBills;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.DataGridView dataGridView_userBills;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button_viewBill;
    }
}