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
    public partial class UserPurchases : Form
    {
        IMSEntities db = CommonUtilities.getConnection();
        long selectedCustomerId = -1;

        public UserPurchases()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            groupBox_userPurchases.Visible = false;
            groupBox_users.Visible = true;

            List<CustomerDetail> customers = CommonUtilities.getSearchResults(textBox_firstName.Text.Trim(), textBox_lastName.Text.Trim(), 0);

            dataGridView_users.DataSource = customers;
            dataGridView_users.Columns["CustomerId"].Visible = false;
            dataGridView_users.Columns["Deposit"].Visible = false;
            //dataGridView_users.Columns["DailyPurchases"].Visible = false;
            dataGridView_users.Columns["PhoneNumber"].Visible = false;
            dataGridView_users.Columns["EmailId"].Visible = false;
            dataGridView_users.Columns["Balance"].Visible = false;

            dataGridView_users.CellClick -= dataGridView_users_CellClick;
            dataGridView_users.CellClick += dataGridView_users_CellClick;
        }

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            groupBox_userPurchases.Visible = true;
 
            //Getting the value of clicked row
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            int selectedCustomerId = Int32.Parse(selectedUser["CustomerId"].Value.ToString());

            CustomerDetail customerDetails = db.CustomerDetails.Where(x => x.CustomerId == selectedCustomerId).Single();

            this.selectedCustomerId = customerDetails.CustomerId;
            textBox_username.Text = customerDetails.CustomerName;

            //comboBox_category.DataSource = db.Categories.ToList();
            //comboBox_category.DisplayMember = "CategoryName";
            //comboBox_category.ValueMember = "CategoryId";

            //comboBox_product.DataSource = db.Products.ToList();
            //comboBox_product.DisplayMember = "ProductName";
            //comboBox_product.ValueMember = "ProductId";

        }

        private void button_generateBill_Click(object sender, EventArgs e)
        {
            if (textBox_quantity.Text.Trim().Length == 0)
            {
                CommonUtilities.showErrorPopUp("Please Enter Quantity");
                return;
            }

            long userPayment = 0;
            
            if(textBox_userPayment.Text.Trim().Length != 0)
            {
                int result = 0;
                if(! Int32.TryParse(textBox_userPayment.Text.Trim(),out result))
                {
                    CommonUtilities.showErrorPopUp("Please Enter a Valid Value");
                    return;
                }
            
            }

            int output;
            if (! Int32.TryParse(textBox_quantity.Text.Trim(), out output))
            {
                CommonUtilities.showErrorPopUp("Please Enter Valid Quantity");
                return;
            }

            if (textBox_userPayment.Text.Trim().Length != 0)
            {
                int result;
                if (!Int32.TryParse(textBox_userPayment.Text.Trim(), out result))
                {
                    CommonUtilities.showErrorPopUp("Please Enter a Valid Payment");
                    return;
                }
            }

            if(textBox_userPayment.Text.Trim().Length != 0)
                userPayment = long.Parse(textBox_userPayment.Text.Trim());

            Category selectedCategory = comboBox_category.SelectedItem as Category;
            Product selectedProduct = comboBox_product.SelectedItem as Product;
            int quantity = Int32.Parse(textBox_quantity.Text.Trim());


            long availableQuantity = db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Quantity;

            if (availableQuantity < (long)quantity)
            {
                CommonUtilities.showErrorPopUp("Available Quantity of " + selectedProduct.ProductName + " = " + availableQuantity);
                return;
            }


            long productCost = 0;
            if (db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Cost != null)
                productCost = (long) db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Cost;

            long billAmount = (productCost * quantity);

            DateTime billDate = DateTime.Parse(dateTimePicker_billDate.Text);

            DailyPurchas thisBill = new DailyPurchas();
            thisBill.CustomerId = this.selectedCustomerId;
            thisBill.PurchaseTime = DateTime.Now.TimeOfDay;
            thisBill.BillDescription = textBox_billDescription.Text.Trim();
            thisBill.BillAmount = billAmount;
            thisBill.PurchaseDate = billDate;
            thisBill.UserPayment = userPayment ;
            
                db.DailyPurchases.Add(thisBill);

            Product product = db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single();
            long prodQuantity = product.Quantity;

            product.Quantity = prodQuantity - quantity;
            
            db.SaveChanges();

            CommonUtilities.showSuccessPopup("SuccessFully Added Bill Details");
        }

        private void linkLabel_calculateAmount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox_quantity.Text.Trim().Length == 0)
            {
                CommonUtilities.showErrorPopUp("Please Enter Quantity");
                return;
            }

            int output;
            if (! Int32.TryParse(textBox_quantity.Text.Trim(), out output))
            {
                CommonUtilities.showErrorPopUp("Please Enter Valid Quantity");
                return;
            }
            Category selectedCategory = comboBox_category.SelectedItem as Category;
            Product selectedProduct = comboBox_product.SelectedItem as Product;
            int quantity = Int32.Parse(textBox_quantity.Text.Trim());

            long availableQuantity = db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Quantity;

            if (availableQuantity < (long)quantity)
            {
                CommonUtilities.showErrorPopUp("Available Quantity of "+selectedProduct.ProductName +" = "+availableQuantity);
                return;
            }

            long productCost = 0;
            if(db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Cost != null)
                productCost = (long) db.Products.Where(x => x.CategoryId == selectedCategory.CategoryId && x.ProductId == selectedProduct.ProductId).Single().Cost;

            label_billAmount.Text = (productCost * quantity).ToString();
        }

        private void linkLabel_bills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bills bills = new Bills();
            bills.setCustomerId(selectedCustomerId);
            bills.Show();
        }

        private void linkLabel_userPayments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPayments userPayments = new UserPayments();
            userPayments.setCustomerId(selectedCustomerId);
            userPayments.Show();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selected = comboBox_category.SelectedItem as Category;
            comboBox_product.DataSource = db.Products.Where(x => x.CategoryId == selected.CategoryId).ToList();
            comboBox_product.ValueMember = "ProductId";
            comboBox_product.DisplayMember = "ProductName";
        }

        private void UserPurchases_Load(object sender, EventArgs e)
        {
            comboBox_category.DataSource = db.Categories.ToList();
            comboBox_category.DisplayMember = "CategoryName";
            comboBox_category.ValueMember = "CategoryId";
        }
    }
}
