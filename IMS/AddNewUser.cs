using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    /// <summary>
    /// This Form is used to add a new user to the database.
    /// </summary>
    public partial class AddNewUser : Form
    {
        IMSEntities db = CommonUtilities.getConnection();

        /* If a user navigates to User Details > Edit, this same form pops up (With the current balance field hidden). At such a time, that user's 
         * id is required to pre-populate the fields on this form.*/
        int selectedCustomerId;
        
        //public AddNewUser()
        //{
        //    InitializeComponent();
        //}
        
        
               
        /// <summary>
        /// Pre-populates the form fields, with the values pertaining to the Customer having id as 'selectedCustomerId'
        /// </summary>
        /// <param name="selectedCustomerId">The Id of the Customer whose details have to be pre-populated.</param>
        public void fillFormWithValues(int selectedCustomerId)
        {
            this.selectedCustomerId = selectedCustomerId;
                        
            button_SubmitAddNewUser.Visible = false;
            button_edit.Visible = true;

            //Fetch the Customer from the DB and populate the form-fields.
            CustomerDetail selectedCustomer = db.CustomerDetails.Where(x => x.CustomerId == selectedCustomerId).FirstOrDefault();            
            textBox_firstName.Text = selectedCustomer.CustomerName;
            textBox_lastName.Text = selectedCustomer.LastName;
            textBox_Address.Text = selectedCustomer.Address;           
            textBox_PhoneNumber.Text = selectedCustomer.PhoneNumber;
            textBox_EmailId.Text = selectedCustomer.EmailId;
            textBox_Deposit.Text = selectedCustomer.Deposit.ToString();
           
        }

        /// <summary>
        /// Validates the form-fields before insertion into the DB.
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {            
            bool errorOccurred = false;
            String errorMessage = "";

            if (textBox_firstName.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter First Name \n";
            }
            
            long result;
            if(textBox_PhoneNumber.Text.Trim().Length != 0  )
            {
                if(!long.TryParse(textBox_PhoneNumber.Text, out result))
                {
                errorOccurred = true;
                errorMessage += "-> Please Enter a Valid Phone Number \n";
                }
            }

            if (textBox_EmailId.Text.Trim().Length != 0)
            {
                if (!(textBox_EmailId.Text.Contains("@") && textBox_EmailId.Text.Contains(".") && (textBox_EmailId.Text.IndexOf(".") - textBox_EmailId.Text.IndexOf("@")  > 1)))
                {
                    errorOccurred = true;
                    errorMessage += "-> Please Enter a Valid Email Id \n";
                }
            }

            int deposit;
            if (textBox_Deposit.Text.Trim().Length != 0)
            {
                if (!Int32.TryParse(textBox_Deposit.Text, out deposit))
                {
                    errorOccurred = true;
                    errorMessage += "-> Please Enter a Valid Deposit \n";
                }
            }
            
            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");                
            }

            return errorOccurred;
        }

        /// <summary>
        /// Submit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SubmitAddNewUser_Click_1(object sender, EventArgs e)
        {
            if(validate())
            return; //Validation fails.

            //Validation successful.

            //Create a new CustomerDetail object, fetch form-field-values and insert into the DB.
            CustomerDetail customerDetail = new CustomerDetail();            
            int lastInsertedCustomerId = db.CustomerDetails.Count();
            customerDetail.CustomerId = lastInsertedCustomerId + 1; //New Customer's id.

            fetchFormValues(customerDetail);                    

            bool exceptionOccured = false;
            try
            {
               
                    try
                    {
                        db.CustomerDetails.Add(customerDetail);
                        db.SaveChanges();
                       
                        
                    }
                    catch (Exception ex)
                    {
                     
                    }                    
                
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                exceptionOccured = true;
            }

            if (!exceptionOccured)
            {
                MessageBox.Show("User added successfully.", "Success");                
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }

        /// <summary>
        /// Fetches values from the form-fields and populates the customerDetail object.
        /// </summary>
        /// <param name="customerDetail">The CustomerDetail object into which the form-field-values are filled.</param>
        private void fetchFormValues(CustomerDetail customerDetail)
        {
            customerDetail.EmailId = textBox_EmailId.Text;
            customerDetail.CustomerName = textBox_firstName.Text;
            customerDetail.LastName = textBox_lastName.Text;
            customerDetail.Address = textBox_Address.Text;

            int depositAmount = 0;
            Int32.TryParse(textBox_Deposit.Text.Trim(), out depositAmount);
            customerDetail.PhoneNumber = textBox_PhoneNumber.Text;
            customerDetail.Deposit = depositAmount;

       
        }

        /// <summary>
        /// The Edit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_edit_Click(object sender, EventArgs e)
        {
            if(validate())
                return; //Validation fails.

            //Fetch the CustomerDetail object which has to be modified.
            CustomerDetail selectedCustomer = db.CustomerDetails.Where(x => x.CustomerId == selectedCustomerId ).FirstOrDefault();
            
            //Fetch the updated values from the form-fields.
            fetchFormValues(selectedCustomer);
            
            //Commit the changes.
            db.SaveChanges();

            MessageBox.Show("Updated Successfully.", "Success");
        }

        

        /// <summary>
        /// If a user chooses to add a new value to the Areas/MealPlans master table, then on submitting the new value in the popup,
        /// the combo-boxes shoul be refreshed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // AddNewUser
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "AddNewUser";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.Load += new System.EventHandler(this.AddNewUser_Load);
        //    this.ResumeLayout(false);

        //}

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // AddNewUser
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "AddNewUser";
        //    this.Load += new System.EventHandler(this.AddNewUser_Load_1);
        //    this.ResumeLayout(false);

        //}

        
    }
}
