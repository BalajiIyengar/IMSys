using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class CategoriesAndProducts : Form
    {
        public CategoriesAndProducts()
        {
            InitializeComponent();
        }

        IMSEntities db = CommonUtilities.getConnection();

        private void CategoriesAndProducts_Load(object sender, EventArgs e)
        {
            comboBox_category.DataSource = db.Categories.ToList();
            comboBox_category.ValueMember = "CategoryId";
            comboBox_category.DisplayMember = "CategoryName";
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selected = comboBox_category.SelectedItem as Category;

            List<Product> products = new List<Product>();
            if (db.Products.Where(x => x.CategoryId == selected.CategoryId).Count() > 0)
            {
                products = db.Products.Where(x => x.CategoryId == selected.CategoryId).OrderBy(x=>x.ProductId).ToList();
            }
            dataGridView_products.DataSource = products;

            dataGridView_products.Columns["CategoryId"].Visible = false;
            dataGridView_products.Columns["ProductId"].Visible = false;
            dataGridView_products.Columns["Category"].Visible = false;


            dataGridView_products.CellClick -= dataGridView_products_CellClick;
            dataGridView_products.CellClick += dataGridView_products_CellClick;

            dataGridView_products.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            long catId = long.Parse(selectedUser["CategoryId"].Value.ToString());
            long prodId = long.Parse(selectedUser["ProductId"].Value.ToString());

           Product selectedProductDetails = db.Products.Where(x => x.CategoryId == catId && x.ProductId == prodId).Single();


        }


        private void dataGridView_products_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            dataGridView_products.BeginEdit(true);

            db.SaveChanges();

        }

        private void button_searchProduct_Click(object sender, EventArgs e)
        {
            bool isOnlyProductName = false;
            if (textBox_productName.Text.Trim().Length == 0)
            {
                CommonUtilities.showErrorPopUp("Please Enter a Product Name");
                return;
            }
            isOnlyProductName = true;

            int lessThanOrGreater = 0;
            bool isLessThan = false;
            if (textBox_quantityLessThan.Text.Trim().Length != 0)
            {

                if (textBox_quantityGreaterThan.Text.Trim().Length != 0)
                {
                    CommonUtilities.showErrorPopUp("Please Select either Less than Or Greater Than value in Quantity");
                    return;
                }

                Int32 output;
                if (Int32.TryParse(textBox_quantityLessThan.Text.Trim(), out output))
                {
                    lessThanOrGreater = output;
                    isLessThan = true;
                }
                isOnlyProductName = false;

            }
            if (textBox_quantityGreaterThan.Text.Trim().Length != 0)
            { 
               Int32 output;
               if (Int32.TryParse(textBox_quantityGreaterThan.Text.Trim(), out output))
               {
                   lessThanOrGreater = output;
               }
               isOnlyProductName = false;
            }

            List<Product> products = new List<Product>();

            if (isOnlyProductName)
            {
                products = db.Products.Where(x => x.ProductName.Contains(textBox_productName.Text.Trim())).OrderBy(x => x.CategoryId).ToList();
                dataGridView_products.DataSource = products;
                return;
            
            }
            if(isLessThan)
                products = db.Products.Where(x => x.ProductName.Contains(textBox_productName.Text.Trim()) && x.Quantity <= lessThanOrGreater ).OrderBy(x => x.CategoryId).ToList();

            else
                products = db.Products.Where(x => x.ProductName.Contains(textBox_productName.Text.Trim()) && x.Quantity > lessThanOrGreater).OrderBy(x => x.CategoryId).ToList();

            dataGridView_products.DataSource = products;

        }

        private void button_saveProduct_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
