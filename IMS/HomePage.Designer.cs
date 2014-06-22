namespace IMS
{
    partial class HomePage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_analytics = new System.Windows.Forms.LinkLabel();
            this.linkLabel_categoriesAndProducts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_addProductsAndCategories = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_userPurchases = new System.Windows.Forms.LinkLabel();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.textBox_balance);
            this.groupBox1.Controls.Add(this.textBox_lastName);
            this.groupBox1.Controls.Add(this.textBox_customerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Users";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(233, 74);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(66, 76);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.Size = new System.Drawing.Size(100, 20);
            this.textBox_balance.TabIndex = 5;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(233, 27);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 4;
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(66, 27);
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance >=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(12, 135);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.RowHeadersVisible = false;
            this.dataGridView_users.Size = new System.Drawing.Size(339, 330);
            this.dataGridView_users.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_userPurchases);
            this.groupBox2.Controls.Add(this.linkLabel_analytics);
            this.groupBox2.Controls.Add(this.linkLabel_categoriesAndProducts);
            this.groupBox2.Controls.Add(this.linkLabel_addProductsAndCategories);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(1101, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 453);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Links";
            // 
            // linkLabel_analytics
            // 
            this.linkLabel_analytics.AutoSize = true;
            this.linkLabel_analytics.Location = new System.Drawing.Point(48, 195);
            this.linkLabel_analytics.Name = "linkLabel_analytics";
            this.linkLabel_analytics.Size = new System.Drawing.Size(49, 13);
            this.linkLabel_analytics.TabIndex = 3;
            this.linkLabel_analytics.TabStop = true;
            this.linkLabel_analytics.Text = "Analytics";
            this.linkLabel_analytics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_analytics_LinkClicked);
            // 
            // linkLabel_categoriesAndProducts
            // 
            this.linkLabel_categoriesAndProducts.AutoSize = true;
            this.linkLabel_categoriesAndProducts.Location = new System.Drawing.Point(6, 141);
            this.linkLabel_categoriesAndProducts.Name = "linkLabel_categoriesAndProducts";
            this.linkLabel_categoriesAndProducts.Size = new System.Drawing.Size(149, 13);
            this.linkLabel_categoriesAndProducts.TabIndex = 2;
            this.linkLabel_categoriesAndProducts.TabStop = true;
            this.linkLabel_categoriesAndProducts.Text = "View Categories and Products";
            this.linkLabel_categoriesAndProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_categoriesAndProducts_LinkClicked);
            // 
            // linkLabel_addProductsAndCategories
            // 
            this.linkLabel_addProductsAndCategories.AutoSize = true;
            this.linkLabel_addProductsAndCategories.Location = new System.Drawing.Point(6, 84);
            this.linkLabel_addProductsAndCategories.Name = "linkLabel_addProductsAndCategories";
            this.linkLabel_addProductsAndCategories.Size = new System.Drawing.Size(145, 13);
            this.linkLabel_addProductsAndCategories.TabIndex = 1;
            this.linkLabel_addProductsAndCategories.TabStop = true;
            this.linkLabel_addProductsAndCategories.Text = "Add Products and Categories";
            this.linkLabel_addProductsAndCategories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addProductsAndCategories_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New User";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_userPurchases
            // 
            this.linkLabel_userPurchases.AutoSize = true;
            this.linkLabel_userPurchases.Location = new System.Drawing.Point(42, 250);
            this.linkLabel_userPurchases.Name = "linkLabel_userPurchases";
            this.linkLabel_userPurchases.Size = new System.Drawing.Size(82, 13);
            this.linkLabel_userPurchases.TabIndex = 4;
            this.linkLabel_userPurchases.TabStop = true;
            this.linkLabel_userPurchases.Text = "User Purchases";
            this.linkLabel_userPurchases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userPurchases_LinkClicked);
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(390, 12);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_month.TabIndex = 9;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(539, 12);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Year.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(561, 397);
            this.dataGridView1.TabIndex = 11;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel_addProductsAndCategories;
        private System.Windows.Forms.LinkLabel linkLabel_categoriesAndProducts;
        private System.Windows.Forms.LinkLabel linkLabel_analytics;
        private System.Windows.Forms.LinkLabel linkLabel_userPurchases;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

