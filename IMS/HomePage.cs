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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int balance = 0;

            if (textBox_balance.Text.Length > 0)
            {
                if (!Int32.TryParse(textBox_balance.Text, out balance))
                {
                    MessageBox.Show("Please enter a valid balance", "Error");
                    return;
                }
                balance = Int32.Parse(textBox_balance.Text.Trim());
            }
            String customerName = textBox_customerName.Text.Trim();
            String lastName = textBox_lastName.Text.Trim();

            List<CustomerDetail> customers = CommonUtilities.getSearchResults(customerName, lastName, balance);

            if (customers.Count == 0)

            { 
                MessageBox.Show("No Records Found");
                return;
            }
            else
                dataGridView_users.DataSource = customers;

            dataGridView_users.Columns["CustomerId"].Visible = false;
            dataGridView_users.Columns["Deposit"].Visible = false;
            //dataGridView_users.Columns["DailyPurchases"].Visible = false;
            dataGridView_users.Columns["PhoneNumber"].Visible = false;
            dataGridView_users.Columns["EmailId"].Visible = false;
            dataGridView_users.Columns["Balance"].Visible = false;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewUser newUser = new AddNewUser();
            newUser.Show();
        }

        private void linkLabel_addProductsAndCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductsCategories masterPage = new ProductsCategories();
            masterPage.Show();
        }

        private void linkLabel_categoriesAndProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesAndProducts productCategories = new CategoriesAndProducts();
            productCategories.Show();
        }

        private void linkLabel_analytics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
        }

        private void linkLabel_userPurchases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPurchases purchase = new UserPurchases();
            purchase.Show();
        }

       
    }
}
