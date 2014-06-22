namespace IMS
{
    partial class CategoriesAndProducts
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
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.groupBox_products = new System.Windows.Forms.GroupBox();
            this.button_saveProduct = new System.Windows.Forms.Button();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.groupBox_category = new System.Windows.Forms.GroupBox();
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_quantityGreaterThan = new System.Windows.Forms.TextBox();
            this.textBox_quantityLessThan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_searchProduct = new System.Windows.Forms.Button();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.groupBox_category.SuspendLayout();
            this.groupBox_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(69, 45);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 1;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // groupBox_products
            // 
            this.groupBox_products.Controls.Add(this.button_saveProduct);
            this.groupBox_products.Controls.Add(this.dataGridView_products);
            this.groupBox_products.Location = new System.Drawing.Point(290, 12);
            this.groupBox_products.Name = "groupBox_products";
            this.groupBox_products.Size = new System.Drawing.Size(602, 369);
            this.groupBox_products.TabIndex = 2;
            this.groupBox_products.TabStop = false;
            this.groupBox_products.Text = "Products";
            // 
            // button_saveProduct
            // 
            this.button_saveProduct.Location = new System.Drawing.Point(255, 335);
            this.button_saveProduct.Name = "button_saveProduct";
            this.button_saveProduct.Size = new System.Drawing.Size(75, 23);
            this.button_saveProduct.TabIndex = 1;
            this.button_saveProduct.Text = "Save";
            this.button_saveProduct.UseVisualStyleBackColor = true;
            this.button_saveProduct.Click += new System.EventHandler(this.button_saveProduct_Click);
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AllowUserToAddRows = false;
            this.dataGridView_products.AllowUserToDeleteRows = false;
            this.dataGridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_products.MultiSelect = false;
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersVisible = false;
            this.dataGridView_products.Size = new System.Drawing.Size(596, 313);
            this.dataGridView_products.TabIndex = 0;
            // 
            // groupBox_category
            // 
            this.groupBox_category.Controls.Add(this.label1);
            this.groupBox_category.Controls.Add(this.comboBox_category);
            this.groupBox_category.Location = new System.Drawing.Point(14, 12);
            this.groupBox_category.Name = "groupBox_category";
            this.groupBox_category.Size = new System.Drawing.Size(254, 187);
            this.groupBox_category.TabIndex = 3;
            this.groupBox_category.TabStop = false;
            this.groupBox_category.Text = "Search By Category";
            // 
            // groupBox_product
            // 
            this.groupBox_product.Controls.Add(this.label4);
            this.groupBox_product.Controls.Add(this.textBox_quantityGreaterThan);
            this.groupBox_product.Controls.Add(this.textBox_quantityLessThan);
            this.groupBox_product.Controls.Add(this.label3);
            this.groupBox_product.Controls.Add(this.button_searchProduct);
            this.groupBox_product.Controls.Add(this.textBox_productName);
            this.groupBox_product.Controls.Add(this.label2);
            this.groupBox_product.Location = new System.Drawing.Point(14, 212);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Size = new System.Drawing.Size(254, 187);
            this.groupBox_product.TabIndex = 4;
            this.groupBox_product.TabStop = false;
            this.groupBox_product.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity > ";
            // 
            // textBox_quantityGreaterThan
            // 
            this.textBox_quantityGreaterThan.Location = new System.Drawing.Point(99, 116);
            this.textBox_quantityGreaterThan.Name = "textBox_quantityGreaterThan";
            this.textBox_quantityGreaterThan.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantityGreaterThan.TabIndex = 5;
            // 
            // textBox_quantityLessThan
            // 
            this.textBox_quantityLessThan.Location = new System.Drawing.Point(99, 79);
            this.textBox_quantityLessThan.Name = "textBox_quantityLessThan";
            this.textBox_quantityLessThan.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantityLessThan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity < =";
            // 
            // button_searchProduct
            // 
            this.button_searchProduct.Location = new System.Drawing.Point(46, 158);
            this.button_searchProduct.Name = "button_searchProduct";
            this.button_searchProduct.Size = new System.Drawing.Size(75, 23);
            this.button_searchProduct.TabIndex = 2;
            this.button_searchProduct.Text = "Search";
            this.button_searchProduct.UseVisualStyleBackColor = true;
            this.button_searchProduct.Click += new System.EventHandler(this.button_searchProduct_Click);
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(99, 45);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(100, 20);
            this.textBox_productName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name";
            // 
            // CategoriesAndProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 411);
            this.Controls.Add(this.groupBox_product);
            this.Controls.Add(this.groupBox_category);
            this.Controls.Add(this.groupBox_products);
            this.Name = "CategoriesAndProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesAndProducts";
            this.Load += new System.EventHandler(this.CategoriesAndProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_products_KeyDown);
            this.groupBox_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.groupBox_category.ResumeLayout(false);
            this.groupBox_category.PerformLayout();
            this.groupBox_product.ResumeLayout(false);
            this.groupBox_product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.GroupBox groupBox_products;
        private System.Windows.Forms.GroupBox groupBox_category;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Button button_searchProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_quantityGreaterThan;
        private System.Windows.Forms.TextBox textBox_quantityLessThan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_saveProduct;
    }
}