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
    public partial class ProductDetails : Form
    {
        IMSEntities db = CommonUtilities.getConnection();

        public ProductDetails()
        {
            InitializeComponent();
        }

        static String productName;
        static long categoryId;
        static long productId;
        static bool isEdit;

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                button_addProductDetails.Visible = false;
                button_editProduct.Visible = true;

                if(categoryId != 0 && productId != 0)
                {
                    Product selected = db.Products.Where(x => x.CategoryId == categoryId && x.ProductId == productId).Single();
                    richTextBox_productDescription.Text = selected.Product_Details;
                    textBox_quantity.Text = selected.Quantity.ToString();
                }
                 
            
            }
            textBox_productName.Text = productName;
        }

        public void setProductName(Hashtable productDetails)
        {
            ProductDetails.productName = productDetails["ProductName"] as String;

            Object categoryId = productDetails["CategoryId"];
            long catId = long.Parse(categoryId.ToString());

            ProductDetails.categoryId = catId;

            Object productId = productDetails["ProductId"];
            long prodId = 0;
            
            if(productId != null)
                prodId = long.Parse(productId.ToString());

            ProductDetails.productId = prodId;

            Object isEdit = productDetails["ToEdit"];
           
            if(isEdit != null)
            ProductDetails.isEdit = bool.Parse(isEdit.ToString());

        }

        private void button_addProductDetails_Click(object sender, EventArgs e)
        {
            String errorMessage = "";
            if(textBox_quantity.Text.Trim().Length == 0)
            {
                errorMessage += "Please Enter Product Quantity \n";
                MessageBox.Show(errorMessage, "Error");
                return;
            }
            int result;
            
            if (! Int32.TryParse(textBox_quantity.Text.Trim(), out result))
            {
                errorMessage += "\n Please Enter Valid Product Quantity \n";
                MessageBox.Show(errorMessage, "Error");
                return;
            }


            Product productDetails = new Product();

            long lastProductId = 0;
            if (db.Products.Where(x => x.CategoryId == ProductDetails.categoryId).Count() > 0)
                lastProductId = db.Products.Where(x => x.CategoryId == ProductDetails.categoryId).Max(x => x.ProductId);

            productDetails.ProductId = lastProductId + 1;
            productDetails.ProductName = ProductDetails.productName; 
            productDetails.CategoryId = ProductDetails.categoryId;
            productDetails.Product_Details = richTextBox_productDescription.Text.Trim();
            productDetails.Quantity = Int32.Parse(textBox_quantity.Text.Trim());


            db.Products.Add(productDetails);
            db.SaveChanges();

            MessageBox.Show("Added " + ProductDetails.productName + " Details Successfully","Success");
            this.Hide();
        }

        private void button_editProduct_Click(object sender, EventArgs e)
        {
            if( textBox_quantity.Text.Trim().Length != 0)
            {
                int output;
                if(!Int32.TryParse(textBox_quantity.Text.Trim(),out output))
                {
                     CommonUtilities.showErrorPopUp("Please Enter Valid Quantity");
                }

               
            }
            Product editedProduct = db.Products.Where(x => x.CategoryId == categoryId && x.ProductId == productId).Single();
            editedProduct.Quantity = Int32.Parse(textBox_quantity.Text.Trim());
            editedProduct.Product_Details = richTextBox_productDescription.Text;

            db.SaveChanges();
            this.Hide();
            CommonUtilities.showSuccessPopup("You've Successfully Updated "+ editedProduct.ProductName+"'s Details");
        }
    }
}
