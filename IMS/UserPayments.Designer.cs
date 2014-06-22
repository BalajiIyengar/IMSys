namespace IMS
{
    partial class UserPayments
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
            this.groupBox_userPayment = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.textBox_paymentMethod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.groupBox_userPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_userPayment
            // 
            this.groupBox_userPayment.Controls.Add(this.dateTimePicker_paymentDate);
            this.groupBox_userPayment.Controls.Add(this.label4);
            this.groupBox_userPayment.Controls.Add(this.button_pay);
            this.groupBox_userPayment.Controls.Add(this.textBox_paymentMethod);
            this.groupBox_userPayment.Controls.Add(this.label3);
            this.groupBox_userPayment.Controls.Add(this.label2);
            this.groupBox_userPayment.Controls.Add(this.textBox_amount);
            this.groupBox_userPayment.Controls.Add(this.label1);
            this.groupBox_userPayment.Controls.Add(this.textBox_username);
            this.groupBox_userPayment.Controls.Add(this.label_username);
            this.groupBox_userPayment.Location = new System.Drawing.Point(12, 12);
            this.groupBox_userPayment.Name = "groupBox_userPayment";
            this.groupBox_userPayment.Size = new System.Drawing.Size(281, 227);
            this.groupBox_userPayment.TabIndex = 2;
            this.groupBox_userPayment.TabStop = false;
            this.groupBox_userPayment.Text = "User Payment";
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(131, 98);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker_paymentDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(81, 180);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(75, 23);
            this.button_pay.TabIndex = 8;
            this.button_pay.Text = "Pay";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // textBox_paymentMethod
            // 
            this.textBox_paymentMethod.Location = new System.Drawing.Point(130, 131);
            this.textBox_paymentMethod.Name = "textBox_paymentMethod";
            this.textBox_paymentMethod.Size = new System.Drawing.Size(100, 20);
            this.textBox_paymentMethod.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(131, 64);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(131, 13);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(63, 16);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // UserPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 251);
            this.Controls.Add(this.groupBox_userPayment);
            this.Name = "UserPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPayments";
            this.Load += new System.EventHandler(this.UserPayments_Load);
            this.groupBox_userPayment.ResumeLayout(false);
            this.groupBox_userPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_userPayment;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.TextBox textBox_paymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_paymentDate;
    }
}