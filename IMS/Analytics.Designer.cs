namespace IMS
{
    partial class Analytics
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
            this.linkLabel_categories = new System.Windows.Forms.LinkLabel();
            this.linkLabel_products = new System.Windows.Forms.LinkLabel();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.label_maxCategory = new System.Windows.Forms.Label();
            this.label_maxCategoryCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // linkLabel_categories
            // 
            this.linkLabel_categories.AutoSize = true;
            this.linkLabel_categories.Location = new System.Drawing.Point(129, 26);
            this.linkLabel_categories.Name = "linkLabel_categories";
            this.linkLabel_categories.Size = new System.Drawing.Size(77, 13);
            this.linkLabel_categories.TabIndex = 2;
            this.linkLabel_categories.TabStop = true;
            this.linkLabel_categories.Text = "CategoryCount";
            this.linkLabel_categories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_categories_LinkClicked);
            // 
            // linkLabel_products
            // 
            this.linkLabel_products.AutoSize = true;
            this.linkLabel_products.Location = new System.Drawing.Point(132, 62);
            this.linkLabel_products.Name = "linkLabel_products";
            this.linkLabel_products.Size = new System.Drawing.Size(72, 13);
            this.linkLabel_products.TabIndex = 3;
            this.linkLabel_products.TabStop = true;
            this.linkLabel_products.Text = "ProductCount";
            this.linkLabel_products.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_products_LinkClicked);
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.AllowUserToAddRows = false;
            this.dataGridView_data.AllowUserToDeleteRows = false;
            this.dataGridView_data.AllowUserToOrderColumns = true;
            this.dataGridView_data.AllowUserToResizeColumns = false;
            this.dataGridView_data.AllowUserToResizeRows = false;
            this.dataGridView_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_data.Location = new System.Drawing.Point(387, 26);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowHeadersVisible = false;
            this.dataGridView_data.Size = new System.Drawing.Size(187, 282);
            this.dataGridView_data.TabIndex = 4;
            this.dataGridView_data.Visible = false;
            // 
            // label_maxCategory
            // 
            this.label_maxCategory.AutoSize = true;
            this.label_maxCategory.Location = new System.Drawing.Point(59, 130);
            this.label_maxCategory.Name = "label_maxCategory";
            this.label_maxCategory.Size = new System.Drawing.Size(35, 13);
            this.label_maxCategory.TabIndex = 5;
            this.label_maxCategory.Text = "label3";
            // 
            // label_maxCategoryCount
            // 
            this.label_maxCategoryCount.AutoSize = true;
            this.label_maxCategoryCount.Location = new System.Drawing.Point(120, 130);
            this.label_maxCategoryCount.Name = "label_maxCategoryCount";
            this.label_maxCategoryCount.Size = new System.Drawing.Size(35, 13);
            this.label_maxCategoryCount.TabIndex = 6;
            this.label_maxCategoryCount.Text = "label4";
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 332);
            this.Controls.Add(this.label_maxCategoryCount);
            this.Controls.Add(this.label_maxCategory);
            this.Controls.Add(this.dataGridView_data);
            this.Controls.Add(this.linkLabel_products);
            this.Controls.Add(this.linkLabel_categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_categories;
        private System.Windows.Forms.LinkLabel linkLabel_products;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.Label label_maxCategory;
        private System.Windows.Forms.Label label_maxCategoryCount;
    }
}