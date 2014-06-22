namespace IMS
{
    partial class UserPurchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_searchUsers = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.groupBox_users = new System.Windows.Forms.GroupBox();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.groupBox_userPurchases = new System.Windows.Forms.GroupBox();
            this.linkLabel_userPayments = new System.Windows.Forms.LinkLabel();
            this.linkLabel_bills = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_userPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_billDescription = new System.Windows.Forms.TextBox();
            this.linkLabel_calculateAmount = new System.Windows.Forms.LinkLabel();
            this.button_generateBill = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_billAmount = new System.Windows.Forms.Label();
            this.dateTimePicker_billDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.groupBox_searchUsers.SuspendLayout();
            this.groupBox_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox_userPurchases.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_searchUsers
            // 
            this.groupBox_searchUsers.Controls.Add(this.button_search);
            this.groupBox_searchUsers.Controls.Add(this.textBox_lastName);
            this.groupBox_searchUsers.Controls.Add(this.label_lastName);
            this.groupBox_searchUsers.Controls.Add(this.label_firstName);
            this.groupBox_searchUsers.Controls.Add(this.textBox_firstName);
            this.groupBox_searchUsers.Location = new System.Drawing.Point(13, 13);
            this.groupBox_searchUsers.Name = "groupBox_searchUsers";
            this.groupBox_searchUsers.Size = new System.Drawing.Size(282, 121);
            this.groupBox_searchUsers.TabIndex = 0;
            this.groupBox_searchUsers.TabStop = false;
            this.groupBox_searchUsers.Text = "Search Users";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(63, 92);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(89, 52);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 3;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(24, 55);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 2;
            this.label_lastName.Text = "Last Name";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(24, 29);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 1;
            this.label_firstName.Text = "First Name";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(88, 22);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 0;
            // 
            // groupBox_users
            // 
            this.groupBox_users.Controls.Add(this.dataGridView_users);
            this.groupBox_users.Location = new System.Drawing.Point(13, 160);
            this.groupBox_users.Name = "groupBox_users";
            this.groupBox_users.Size = new System.Drawing.Size(282, 287);
            this.groupBox_users.TabIndex = 1;
            this.groupBox_users.TabStop = false;
            this.groupBox_users.Text = "Users";
            this.groupBox_users.Visible = false;
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(6, 28);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersVisible = false;
            this.dataGridView_users.Size = new System.Drawing.Size(270, 253);
            this.dataGridView_users.TabIndex = 0;
            // 
            // groupBox_userPurchases
            // 
            this.groupBox_userPurchases.Controls.Add(this.linkLabel_userPayments);
            this.groupBox_userPurchases.Controls.Add(this.linkLabel_bills);
            this.groupBox_userPurchases.Controls.Add(this.label2);
            this.groupBox_userPurchases.Controls.Add(this.textBox_userPayment);
            this.groupBox_userPurchases.Controls.Add(this.label1);
            this.groupBox_userPurchases.Controls.Add(this.textBox_billDescription);
            this.groupBox_userPurchases.Controls.Add(this.linkLabel_calculateAmount);
            this.groupBox_userPurchases.Controls.Add(this.button_generateBill);
            this.groupBox_userPurchases.Controls.Add(this.label);
            this.groupBox_userPurchases.Controls.Add(this.label_billAmount);
            this.groupBox_userPurchases.Controls.Add(this.dateTimePicker_billDate);
            this.groupBox_userPurchases.Controls.Add(this.textBox_quantity);
            this.groupBox_userPurchases.Controls.Add(this.textBox_username);
            this.groupBox_userPurchases.Controls.Add(this.comboBox_product);
            this.groupBox_userPurchases.Controls.Add(this.comboBox_category);
            this.groupBox_userPurchases.Location = new System.Drawing.Point(314, 13);
            this.groupBox_userPurchases.Name = "groupBox_userPurchases";
            this.groupBox_userPurchases.Size = new System.Drawing.Size(427, 434);
            this.groupBox_userPurchases.TabIndex = 2;
            this.groupBox_userPurchases.TabStop = false;
            this.groupBox_userPurchases.Text = "Bill Calculation";
            this.groupBox_userPurchases.Visible = false;
            // 
            // linkLabel_userPayments
            // 
            this.linkLabel_userPayments.AutoSize = true;
            this.linkLabel_userPayments.Location = new System.Drawing.Point(332, 32);
            this.linkLabel_userPayments.Name = "linkLabel_userPayments";
            this.linkLabel_userPayments.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_userPayments.TabIndex = 13;
            this.linkLabel_userPayments.TabStop = true;
            this.linkLabel_userPayments.Text = "User Payments";
            this.linkLabel_userPayments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userPayments_LinkClicked);
            // 
            // linkLabel_bills
            // 
            this.linkLabel_bills.AutoSize = true;
            this.linkLabel_bills.Location = new System.Drawing.Point(285, 32);
            this.linkLabel_bills.Name = "linkLabel_bills";
            this.linkLabel_bills.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_bills.TabIndex = 3;
            this.linkLabel_bills.TabStop = true;
            this.linkLabel_bills.Text = "Bills";
            this.linkLabel_bills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_bills_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Payment";
            // 
            // textBox_userPayment
            // 
            this.textBox_userPayment.Location = new System.Drawing.Point(177, 266);
            this.textBox_userPayment.Name = "textBox_userPayment";
            this.textBox_userPayment.Size = new System.Drawing.Size(100, 20);
            this.textBox_userPayment.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bill Description";
            // 
            // textBox_billDescription
            // 
            this.textBox_billDescription.Location = new System.Drawing.Point(186, 317);
            this.textBox_billDescription.Name = "textBox_billDescription";
            this.textBox_billDescription.Size = new System.Drawing.Size(100, 20);
            this.textBox_billDescription.TabIndex = 9;
            // 
            // linkLabel_calculateAmount
            // 
            this.linkLabel_calculateAmount.AutoSize = true;
            this.linkLabel_calculateAmount.Location = new System.Drawing.Point(347, 169);
            this.linkLabel_calculateAmount.Name = "linkLabel_calculateAmount";
            this.linkLabel_calculateAmount.Size = new System.Drawing.Size(51, 13);
            this.linkLabel_calculateAmount.TabIndex = 8;
            this.linkLabel_calculateAmount.TabStop = true;
            this.linkLabel_calculateAmount.Text = "Calculate";
            this.linkLabel_calculateAmount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_calculateAmount_LinkClicked);
            // 
            // button_generateBill
            // 
            this.button_generateBill.Location = new System.Drawing.Point(145, 365);
            this.button_generateBill.Name = "button_generateBill";
            this.button_generateBill.Size = new System.Drawing.Size(75, 23);
            this.button_generateBill.TabIndex = 7;
            this.button_generateBill.Text = "Generate Bill";
            this.button_generateBill.UseVisualStyleBackColor = true;
            this.button_generateBill.Click += new System.EventHandler(this.button_generateBill_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(74, 221);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Total Amount : ";
            // 
            // label_billAmount
            // 
            this.label_billAmount.AutoSize = true;
            this.label_billAmount.Location = new System.Drawing.Point(174, 221);
            this.label_billAmount.Name = "label_billAmount";
            this.label_billAmount.Size = new System.Drawing.Size(62, 13);
            this.label_billAmount.TabIndex = 5;
            this.label_billAmount.Text = "Amount Rs.";
            // 
            // dateTimePicker_billDate
            // 
            this.dateTimePicker_billDate.Location = new System.Drawing.Point(208, 100);
            this.dateTimePicker_billDate.Name = "dateTimePicker_billDate";
            this.dateTimePicker_billDate.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker_billDate.TabIndex = 4;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(208, 166);
            this.textBox_quantity.MaxLength = 10;
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(123, 20);
            this.textBox_quantity.TabIndex = 3;
            // 
            // textBox_username
            // 
            this.textBox_username.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_username.Location = new System.Drawing.Point(110, 29);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(145, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(23, 165);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 1;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(23, 100);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 0;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // UserPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 459);
            this.Controls.Add(this.groupBox_userPurchases);
            this.Controls.Add(this.groupBox_users);
            this.Controls.Add(this.groupBox_searchUsers);
            this.Name = "UserPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPurchases";
            this.Load += new System.EventHandler(this.UserPurchases_Load);
            this.groupBox_searchUsers.ResumeLayout(false);
            this.groupBox_searchUsers.PerformLayout();
            this.groupBox_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox_userPurchases.ResumeLayout(false);
            this.groupBox_userPurchases.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_searchUsers;
        private System.Windows.Forms.GroupBox groupBox_users;
        private System.Windows.Forms.GroupBox groupBox_userPurchases;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.DateTimePicker dateTimePicker_billDate;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_billAmount;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_generateBill;
        private System.Windows.Forms.LinkLabel linkLabel_calculateAmount;
        private System.Windows.Forms.TextBox textBox_billDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_userPayment;
        private System.Windows.Forms.LinkLabel linkLabel_bills;
        private System.Windows.Forms.LinkLabel linkLabel_userPayments;
    }
}