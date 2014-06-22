namespace IMS
{
    partial class ProductDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.richTextBox_productDescription = new System.Windows.Forms.RichTextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.button_addProductDetails = new System.Windows.Forms.Button();
            this.button_editProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(143, 27);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.ReadOnly = true;
            this.textBox_productName.Size = new System.Drawing.Size(199, 20);
            this.textBox_productName.TabIndex = 5;
            // 
            // richTextBox_productDescription
            // 
            this.richTextBox_productDescription.Location = new System.Drawing.Point(143, 53);
            this.richTextBox_productDescription.Name = "richTextBox_productDescription";
            this.richTextBox_productDescription.Size = new System.Drawing.Size(199, 58);
            this.richTextBox_productDescription.TabIndex = 6;
            this.richTextBox_productDescription.Text = "";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(143, 122);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(199, 20);
            this.textBox_quantity.TabIndex = 7;
            // 
            // button_addProductDetails
            // 
            this.button_addProductDetails.Location = new System.Drawing.Point(173, 203);
            this.button_addProductDetails.Name = "button_addProductDetails";
            this.button_addProductDetails.Size = new System.Drawing.Size(129, 23);
            this.button_addProductDetails.TabIndex = 8;
            this.button_addProductDetails.Text = "Add Product";
            this.button_addProductDetails.UseVisualStyleBackColor = true;
            this.button_addProductDetails.Click += new System.EventHandler(this.button_addProductDetails_Click);
            // 
            // button_editProduct
            // 
            this.button_editProduct.Location = new System.Drawing.Point(173, 174);
            this.button_editProduct.Name = "button_editProduct";
            this.button_editProduct.Size = new System.Drawing.Size(129, 23);
            this.button_editProduct.TabIndex = 9;
            this.button_editProduct.Text = "Edit Product";
            this.button_editProduct.UseVisualStyleBackColor = true;
            this.button_editProduct.Visible = false;
            this.button_editProduct.Click += new System.EventHandler(this.button_editProduct_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 295);
            this.Controls.Add(this.button_editProduct);
            this.Controls.Add(this.button_addProductDetails);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.richTextBox_productDescription);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.RichTextBox richTextBox_productDescription;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Button button_addProductDetails;
        private System.Windows.Forms.Button button_editProduct;
    }
}