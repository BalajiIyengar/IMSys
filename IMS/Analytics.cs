using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace IMS
{
    public partial class Analytics : Form
    {
        static IMSEntities db = CommonUtilities.getConnection();

        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            linkLabel_products.Text = db.Products.Count().ToString();
            linkLabel_categories.Text = db.Categories.Count().ToString();
            Hashtable categories = new Hashtable();


            for (int i = 1; i <= db.Categories.Count(); i++)
            {
                String categoryName = db.Categories.Where(x => x.CategoryId == i).Single().CategoryName;
                categories[categoryName] = db.Categories.Where(x => x.CategoryId == i).Count();
            }


        }

        private void linkLabel_categories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView_data.Visible = true;

            List<Category> categories = db.Categories.ToList();
            dataGridView_data.DataSource = categories;

            dataGridView_data.Columns["CategoryId"].Visible = false;
            dataGridView_data.Columns["isDiscontinued"].Visible = false;
            dataGridView_data.Columns["Products"].Visible = false;

        }

        private void linkLabel_products_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView_data.Visible = true;
            dataGridView_data.DataSource = db.Products.ToList();

            dataGridView_data.Columns["ProductId"].Visible = false;
            dataGridView_data.Columns["CategoryId"].Visible = false;
            dataGridView_data.Columns["isDiscontinued"].Visible = false;
            dataGridView_data.Columns["Product_Details"].Visible = false;
            dataGridView_data.Columns["Category"].Visible = false;
            dataGridView_data.Columns["Quantity"].Visible = false;
        }
    }
}
