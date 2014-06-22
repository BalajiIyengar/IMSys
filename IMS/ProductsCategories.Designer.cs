namespace IMS
{
    partial class ProductsCategories
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
            this.groupBox_category = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_deleteCategory = new System.Windows.Forms.LinkLabel();
            this.textBox_addNewCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.button_refreshCategories = new System.Windows.Forms.Button();
            this.comboBox_existingCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_modifyCategory = new System.Windows.Forms.GroupBox();
            this.button_rename = new System.Windows.Forms.Button();
            this.button_refreshModifyCategory = new System.Windows.Forms.Button();
            this.textBox_modifyRenameAs = new System.Windows.Forms.TextBox();
            this.label_renameCategory = new System.Windows.Forms.Label();
            this.comboBox_modifyExistingCategories = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.groupBox_editProduct = new System.Windows.Forms.GroupBox();
            this.button_refreshEditProduct = new System.Windows.Forms.Button();
            this.comboBox_editCategoriesInProducts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_renameProduct = new System.Windows.Forms.TextBox();
            this.label_renameAs = new System.Windows.Forms.Label();
            this.button_editProduct = new System.Windows.Forms.Button();
            this.comboBox_editCategories = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_addProduct = new System.Windows.Forms.GroupBox();
            this.linkLabel_editProduct = new System.Windows.Forms.LinkLabel();
            this.linkLabel_deleteProduct = new System.Windows.Forms.LinkLabel();
            this.checkBox_addProductDetails = new System.Windows.Forms.CheckBox();
            this.button_refreshProducts = new System.Windows.Forms.Button();
            this.comboBox_ProductsInCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_newProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.comboBox_existingProductCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_addCategory = new System.Windows.Forms.CheckBox();
            this.checkBox_addProduct = new System.Windows.Forms.CheckBox();
            this.groupBox_category.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_modifyCategory.SuspendLayout();
            this.groupBox_product.SuspendLayout();
            this.groupBox_editProduct.SuspendLayout();
            this.groupBox_addProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_category
            // 
            this.groupBox_category.Controls.Add(this.groupBox2);
            this.groupBox_category.Controls.Add(this.groupBox_modifyCategory);
            this.groupBox_category.Location = new System.Drawing.Point(33, 44);
            this.groupBox_category.Name = "groupBox_category";
            this.groupBox_category.Size = new System.Drawing.Size(382, 341);
            this.groupBox_category.TabIndex = 0;
            this.groupBox_category.TabStop = false;
            this.groupBox_category.Text = "Categories";
            this.groupBox_category.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_deleteCategory);
            this.groupBox2.Controls.Add(this.textBox_addNewCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_AddCategory);
            this.groupBox2.Controls.Add(this.button_refreshCategories);
            this.groupBox2.Controls.Add(this.comboBox_existingCategories);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Category";
            // 
            // linkLabel_deleteCategory
            // 
            this.linkLabel_deleteCategory.AutoSize = true;
            this.linkLabel_deleteCategory.Location = new System.Drawing.Point(301, 71);
            this.linkLabel_deleteCategory.Name = "linkLabel_deleteCategory";
            this.linkLabel_deleteCategory.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_deleteCategory.TabIndex = 6;
            this.linkLabel_deleteCategory.TabStop = true;
            this.linkLabel_deleteCategory.Text = "Delete";
            this.linkLabel_deleteCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_deleteCategory_LinkClicked);
            // 
            // textBox_addNewCategory
            // 
            this.textBox_addNewCategory.Location = new System.Drawing.Point(144, 22);
            this.textBox_addNewCategory.MaxLength = 100;
            this.textBox_addNewCategory.Name = "textBox_addNewCategory";
            this.textBox_addNewCategory.Size = new System.Drawing.Size(134, 20);
            this.textBox_addNewCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Category Name";
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.Location = new System.Drawing.Point(10, 106);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(128, 23);
            this.button_AddCategory.TabIndex = 2;
            this.button_AddCategory.Text = "Add Category";
            this.button_AddCategory.UseVisualStyleBackColor = true;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // button_refreshCategories
            // 
            this.button_refreshCategories.Location = new System.Drawing.Point(221, 106);
            this.button_refreshCategories.Name = "button_refreshCategories";
            this.button_refreshCategories.Size = new System.Drawing.Size(57, 23);
            this.button_refreshCategories.TabIndex = 5;
            this.button_refreshCategories.Text = "Refresh";
            this.button_refreshCategories.UseVisualStyleBackColor = true;
            this.button_refreshCategories.Click += new System.EventHandler(this.button_refreshCategories_Click);
            // 
            // comboBox_existingCategories
            // 
            this.comboBox_existingCategories.FormattingEnabled = true;
            this.comboBox_existingCategories.Location = new System.Drawing.Point(144, 63);
            this.comboBox_existingCategories.Name = "comboBox_existingCategories";
            this.comboBox_existingCategories.Size = new System.Drawing.Size(134, 21);
            this.comboBox_existingCategories.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Existing Categories";
            // 
            // groupBox_modifyCategory
            // 
            this.groupBox_modifyCategory.Controls.Add(this.button_rename);
            this.groupBox_modifyCategory.Controls.Add(this.button_refreshModifyCategory);
            this.groupBox_modifyCategory.Controls.Add(this.textBox_modifyRenameAs);
            this.groupBox_modifyCategory.Controls.Add(this.label_renameCategory);
            this.groupBox_modifyCategory.Controls.Add(this.comboBox_modifyExistingCategories);
            this.groupBox_modifyCategory.Controls.Add(this.label7);
            this.groupBox_modifyCategory.Location = new System.Drawing.Point(6, 184);
            this.groupBox_modifyCategory.Name = "groupBox_modifyCategory";
            this.groupBox_modifyCategory.Size = new System.Drawing.Size(362, 170);
            this.groupBox_modifyCategory.TabIndex = 6;
            this.groupBox_modifyCategory.TabStop = false;
            this.groupBox_modifyCategory.Text = "Edit Category";
            // 
            // button_rename
            // 
            this.button_rename.Location = new System.Drawing.Point(10, 113);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(128, 23);
            this.button_rename.TabIndex = 9;
            this.button_rename.Text = "Rename";
            this.button_rename.UseVisualStyleBackColor = true;
            this.button_rename.Click += new System.EventHandler(this.button_rename_Click);
            // 
            // button_refreshModifyCategory
            // 
            this.button_refreshModifyCategory.Location = new System.Drawing.Point(212, 113);
            this.button_refreshModifyCategory.Name = "button_refreshModifyCategory";
            this.button_refreshModifyCategory.Size = new System.Drawing.Size(57, 23);
            this.button_refreshModifyCategory.TabIndex = 10;
            this.button_refreshModifyCategory.Text = "Refresh";
            this.button_refreshModifyCategory.UseVisualStyleBackColor = true;
            this.button_refreshModifyCategory.Click += new System.EventHandler(this.button_refreshModifyCategory_Click);
            // 
            // textBox_modifyRenameAs
            // 
            this.textBox_modifyRenameAs.Location = new System.Drawing.Point(135, 73);
            this.textBox_modifyRenameAs.MaxLength = 100;
            this.textBox_modifyRenameAs.Name = "textBox_modifyRenameAs";
            this.textBox_modifyRenameAs.Size = new System.Drawing.Size(134, 20);
            this.textBox_modifyRenameAs.TabIndex = 8;
            // 
            // label_renameCategory
            // 
            this.label_renameCategory.AutoSize = true;
            this.label_renameCategory.Location = new System.Drawing.Point(7, 76);
            this.label_renameCategory.Name = "label_renameCategory";
            this.label_renameCategory.Size = new System.Drawing.Size(62, 13);
            this.label_renameCategory.TabIndex = 7;
            this.label_renameCategory.Text = "Rename As";
            // 
            // comboBox_modifyExistingCategories
            // 
            this.comboBox_modifyExistingCategories.FormattingEnabled = true;
            this.comboBox_modifyExistingCategories.Location = new System.Drawing.Point(135, 39);
            this.comboBox_modifyExistingCategories.Name = "comboBox_modifyExistingCategories";
            this.comboBox_modifyExistingCategories.Size = new System.Drawing.Size(134, 21);
            this.comboBox_modifyExistingCategories.TabIndex = 5;
            this.comboBox_modifyExistingCategories.SelectedIndexChanged += new System.EventHandler(this.comboBox_modifyExistingCategories_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Existing Categories";
            // 
            // groupBox_product
            // 
            this.groupBox_product.Controls.Add(this.groupBox_editProduct);
            this.groupBox_product.Controls.Add(this.groupBox_addProduct);
            this.groupBox_product.Location = new System.Drawing.Point(448, 44);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Size = new System.Drawing.Size(381, 341);
            this.groupBox_product.TabIndex = 1;
            this.groupBox_product.TabStop = false;
            this.groupBox_product.Text = "Products";
            this.groupBox_product.Visible = false;
            // 
            // groupBox_editProduct
            // 
            this.groupBox_editProduct.Controls.Add(this.button_refreshEditProduct);
            this.groupBox_editProduct.Controls.Add(this.comboBox_editCategoriesInProducts);
            this.groupBox_editProduct.Controls.Add(this.label6);
            this.groupBox_editProduct.Controls.Add(this.textBox_renameProduct);
            this.groupBox_editProduct.Controls.Add(this.label_renameAs);
            this.groupBox_editProduct.Controls.Add(this.button_editProduct);
            this.groupBox_editProduct.Controls.Add(this.comboBox_editCategories);
            this.groupBox_editProduct.Controls.Add(this.label9);
            this.groupBox_editProduct.Location = new System.Drawing.Point(6, 184);
            this.groupBox_editProduct.Name = "groupBox_editProduct";
            this.groupBox_editProduct.Size = new System.Drawing.Size(361, 170);
            this.groupBox_editProduct.TabIndex = 1;
            this.groupBox_editProduct.TabStop = false;
            this.groupBox_editProduct.Text = "Edit Product";
            // 
            // button_refreshEditProduct
            // 
            this.button_refreshEditProduct.Location = new System.Drawing.Point(215, 134);
            this.button_refreshEditProduct.Name = "button_refreshEditProduct";
            this.button_refreshEditProduct.Size = new System.Drawing.Size(57, 23);
            this.button_refreshEditProduct.TabIndex = 35;
            this.button_refreshEditProduct.Text = "Refresh";
            this.button_refreshEditProduct.UseVisualStyleBackColor = true;
            this.button_refreshEditProduct.Click += new System.EventHandler(this.button_refreshEditProduct_Click);
            // 
            // comboBox_editCategoriesInProducts
            // 
            this.comboBox_editCategoriesInProducts.FormattingEnabled = true;
            this.comboBox_editCategoriesInProducts.Location = new System.Drawing.Point(138, 60);
            this.comboBox_editCategoriesInProducts.Name = "comboBox_editCategoriesInProducts";
            this.comboBox_editCategoriesInProducts.Size = new System.Drawing.Size(134, 21);
            this.comboBox_editCategoriesInProducts.TabIndex = 34;
            this.comboBox_editCategoriesInProducts.SelectedIndexChanged += new System.EventHandler(this.comboBox_editCategoriesInProducts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Products In";
            // 
            // textBox_renameProduct
            // 
            this.textBox_renameProduct.Location = new System.Drawing.Point(138, 99);
            this.textBox_renameProduct.MaxLength = 100;
            this.textBox_renameProduct.Name = "textBox_renameProduct";
            this.textBox_renameProduct.Size = new System.Drawing.Size(134, 20);
            this.textBox_renameProduct.TabIndex = 32;
            // 
            // label_renameAs
            // 
            this.label_renameAs.AutoSize = true;
            this.label_renameAs.Location = new System.Drawing.Point(31, 99);
            this.label_renameAs.Name = "label_renameAs";
            this.label_renameAs.Size = new System.Drawing.Size(75, 13);
            this.label_renameAs.TabIndex = 31;
            this.label_renameAs.Text = "Product Name";
            // 
            // button_editProduct
            // 
            this.button_editProduct.Location = new System.Drawing.Point(34, 135);
            this.button_editProduct.Name = "button_editProduct";
            this.button_editProduct.Size = new System.Drawing.Size(128, 23);
            this.button_editProduct.TabIndex = 30;
            this.button_editProduct.Text = "Edit Product";
            this.button_editProduct.UseVisualStyleBackColor = true;
            this.button_editProduct.Click += new System.EventHandler(this.button_editProduct_Click);
            // 
            // comboBox_editCategories
            // 
            this.comboBox_editCategories.FormattingEnabled = true;
            this.comboBox_editCategories.Location = new System.Drawing.Point(138, 24);
            this.comboBox_editCategories.Name = "comboBox_editCategories";
            this.comboBox_editCategories.Size = new System.Drawing.Size(134, 21);
            this.comboBox_editCategories.TabIndex = 29;
            this.comboBox_editCategories.SelectedIndexChanged += new System.EventHandler(this.comboBox_editCategories_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Category Name";
            // 
            // groupBox_addProduct
            // 
            this.groupBox_addProduct.AutoSize = true;
            this.groupBox_addProduct.Controls.Add(this.linkLabel_editProduct);
            this.groupBox_addProduct.Controls.Add(this.linkLabel_deleteProduct);
            this.groupBox_addProduct.Controls.Add(this.checkBox_addProductDetails);
            this.groupBox_addProduct.Controls.Add(this.button_refreshProducts);
            this.groupBox_addProduct.Controls.Add(this.comboBox_ProductsInCategory);
            this.groupBox_addProduct.Controls.Add(this.label5);
            this.groupBox_addProduct.Controls.Add(this.textBox_newProduct);
            this.groupBox_addProduct.Controls.Add(this.label3);
            this.groupBox_addProduct.Controls.Add(this.button_addProduct);
            this.groupBox_addProduct.Controls.Add(this.comboBox_existingProductCategories);
            this.groupBox_addProduct.Controls.Add(this.label4);
            this.groupBox_addProduct.Location = new System.Drawing.Point(6, 19);
            this.groupBox_addProduct.Name = "groupBox_addProduct";
            this.groupBox_addProduct.Size = new System.Drawing.Size(361, 180);
            this.groupBox_addProduct.TabIndex = 0;
            this.groupBox_addProduct.TabStop = false;
            this.groupBox_addProduct.Text = "Add Products";
            // 
            // linkLabel_editProduct
            // 
            this.linkLabel_editProduct.AutoSize = true;
            this.linkLabel_editProduct.Location = new System.Drawing.Point(317, 58);
            this.linkLabel_editProduct.Name = "linkLabel_editProduct";
            this.linkLabel_editProduct.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_editProduct.TabIndex = 30;
            this.linkLabel_editProduct.TabStop = true;
            this.linkLabel_editProduct.Text = "Edit";
            this.linkLabel_editProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_editProduct_LinkClicked);
            // 
            // linkLabel_deleteProduct
            // 
            this.linkLabel_deleteProduct.AutoSize = true;
            this.linkLabel_deleteProduct.Location = new System.Drawing.Point(273, 58);
            this.linkLabel_deleteProduct.Name = "linkLabel_deleteProduct";
            this.linkLabel_deleteProduct.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_deleteProduct.TabIndex = 29;
            this.linkLabel_deleteProduct.TabStop = true;
            this.linkLabel_deleteProduct.Text = "Delete";
            this.linkLabel_deleteProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_deleteProduct_LinkClicked);
            // 
            // checkBox_addProductDetails
            // 
            this.checkBox_addProductDetails.AutoSize = true;
            this.checkBox_addProductDetails.Location = new System.Drawing.Point(134, 117);
            this.checkBox_addProductDetails.Name = "checkBox_addProductDetails";
            this.checkBox_addProductDetails.Size = new System.Drawing.Size(120, 17);
            this.checkBox_addProductDetails.TabIndex = 28;
            this.checkBox_addProductDetails.Text = "Add Product Details";
            this.checkBox_addProductDetails.UseVisualStyleBackColor = true;
            this.checkBox_addProductDetails.CheckedChanged += new System.EventHandler(this.checkBox_addProductDetails_CheckedChanged);
            // 
            // button_refreshProducts
            // 
            this.button_refreshProducts.Location = new System.Drawing.Point(210, 138);
            this.button_refreshProducts.Name = "button_refreshProducts";
            this.button_refreshProducts.Size = new System.Drawing.Size(57, 23);
            this.button_refreshProducts.TabIndex = 27;
            this.button_refreshProducts.Text = "Refresh";
            this.button_refreshProducts.UseVisualStyleBackColor = true;
            this.button_refreshProducts.Click += new System.EventHandler(this.button_refreshProducts_Click);
            // 
            // comboBox_ProductsInCategory
            // 
            this.comboBox_ProductsInCategory.FormattingEnabled = true;
            this.comboBox_ProductsInCategory.Location = new System.Drawing.Point(133, 50);
            this.comboBox_ProductsInCategory.Name = "comboBox_ProductsInCategory";
            this.comboBox_ProductsInCategory.Size = new System.Drawing.Size(134, 21);
            this.comboBox_ProductsInCategory.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Products In";
            // 
            // textBox_newProduct
            // 
            this.textBox_newProduct.Location = new System.Drawing.Point(133, 89);
            this.textBox_newProduct.MaxLength = 100;
            this.textBox_newProduct.Name = "textBox_newProduct";
            this.textBox_newProduct.Size = new System.Drawing.Size(134, 20);
            this.textBox_newProduct.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name";
            // 
            // button_addProduct
            // 
            this.button_addProduct.Location = new System.Drawing.Point(29, 138);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(128, 23);
            this.button_addProduct.TabIndex = 22;
            this.button_addProduct.Text = "Add Product";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // comboBox_existingProductCategories
            // 
            this.comboBox_existingProductCategories.FormattingEnabled = true;
            this.comboBox_existingProductCategories.Location = new System.Drawing.Point(133, 17);
            this.comboBox_existingProductCategories.Name = "comboBox_existingProductCategories";
            this.comboBox_existingProductCategories.Size = new System.Drawing.Size(134, 21);
            this.comboBox_existingProductCategories.TabIndex = 21;
            this.comboBox_existingProductCategories.SelectedIndexChanged += new System.EventHandler(this.comboBox_existingProductCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category Name";
            // 
            // checkBox_addCategory
            // 
            this.checkBox_addCategory.AutoSize = true;
            this.checkBox_addCategory.Location = new System.Drawing.Point(92, 21);
            this.checkBox_addCategory.Name = "checkBox_addCategory";
            this.checkBox_addCategory.Size = new System.Drawing.Size(89, 17);
            this.checkBox_addCategory.TabIndex = 2;
            this.checkBox_addCategory.Text = "Add category";
            this.checkBox_addCategory.UseVisualStyleBackColor = true;
            this.checkBox_addCategory.CheckedChanged += new System.EventHandler(this.checkBox_addCategory_CheckedChanged);
            // 
            // checkBox_addProduct
            // 
            this.checkBox_addProduct.AutoSize = true;
            this.checkBox_addProduct.Location = new System.Drawing.Point(623, 21);
            this.checkBox_addProduct.Name = "checkBox_addProduct";
            this.checkBox_addProduct.Size = new System.Drawing.Size(85, 17);
            this.checkBox_addProduct.TabIndex = 3;
            this.checkBox_addProduct.Text = "Add Product";
            this.checkBox_addProduct.UseVisualStyleBackColor = true;
            this.checkBox_addProduct.CheckedChanged += new System.EventHandler(this.checkBox_addProduct_CheckedChanged);
            // 
            // ProductsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 397);
            this.Controls.Add(this.checkBox_addProduct);
            this.Controls.Add(this.checkBox_addCategory);
            this.Controls.Add(this.groupBox_product);
            this.Controls.Add(this.groupBox_category);
            this.Name = "ProductsCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsCategories";
            this.Load += new System.EventHandler(this.ProductsCategories_Load);
            this.groupBox_category.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_modifyCategory.ResumeLayout(false);
            this.groupBox_modifyCategory.PerformLayout();
            this.groupBox_product.ResumeLayout(false);
            this.groupBox_product.PerformLayout();
            this.groupBox_editProduct.ResumeLayout(false);
            this.groupBox_editProduct.PerformLayout();
            this.groupBox_addProduct.ResumeLayout(false);
            this.groupBox_addProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_category;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_addNewCategory;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_existingCategories;
        private System.Windows.Forms.Button button_refreshCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_modifyCategory;
        private System.Windows.Forms.ComboBox comboBox_modifyExistingCategories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_modifyRenameAs;
        private System.Windows.Forms.Label label_renameCategory;
        private System.Windows.Forms.Button button_rename;
        private System.Windows.Forms.Button button_refreshModifyCategory;
        private System.Windows.Forms.GroupBox groupBox_addProduct;
        private System.Windows.Forms.Button button_refreshProducts;
        private System.Windows.Forms.ComboBox comboBox_ProductsInCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_newProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.ComboBox comboBox_existingProductCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_editProduct;
        private System.Windows.Forms.Button button_refreshEditProduct;
        private System.Windows.Forms.ComboBox comboBox_editCategoriesInProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_renameProduct;
        private System.Windows.Forms.Label label_renameAs;
        private System.Windows.Forms.Button button_editProduct;
        private System.Windows.Forms.ComboBox comboBox_editCategories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_addProductDetails;
        private System.Windows.Forms.CheckBox checkBox_addCategory;
        private System.Windows.Forms.CheckBox checkBox_addProduct;
        private System.Windows.Forms.LinkLabel linkLabel_deleteProduct;
        private System.Windows.Forms.LinkLabel linkLabel_deleteCategory;
        private System.Windows.Forms.LinkLabel linkLabel_editProduct;
    }
}