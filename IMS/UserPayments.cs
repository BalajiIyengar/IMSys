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
    public partial class UserPayments : Form
    {

        IMSEntities db = CommonUtilities.getConnection();

        static long customerId;
        public UserPayments()
        {
            InitializeComponent();
        }



        internal void setCustomerId(long selectedCustomerId)
        {
            customerId = selectedCustomerId;
           // throw new NotImplementedException();
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            String errorMessage = "";
            if (textBox_amount.Text.Trim().Length == 0)
                errorMessage += "\n Please Enter the Amount";
            else
            {  
                int result;
                if(! Int32.TryParse(textBox_amount.Text.Trim(),out result))
                {
                    errorMessage += "\n Please Enter a Valid Amount";
                }
            }

            if(textBox_paymentMethod.Text.Trim().Length == 0)
                errorMessage += "\n Please Enter the Payment Method";

            

            if (errorMessage.Length != 0)
            {
                CommonUtilities.showErrorPopUp(errorMessage);
                return;
            }

            UserPayment userPayment = new UserPayment();
            userPayment.Amount = Int32.Parse (textBox_amount.Text.Trim());
            userPayment.CustomerId = customerId;
            userPayment.PaymentDate = DateTime.Parse(dateTimePicker_paymentDate.Text);
            userPayment.PaymentMethod = textBox_paymentMethod.Text.Trim();
            userPayment.PaymentTime = DateTime.Now.TimeOfDay;

            db.UserPayments.Add(userPayment);

            db.SaveChanges();
            CommonUtilities.showSuccessPopup("Added Payment Details Successfully");
            this.Close();
            }

        private void UserPayments_Load(object sender, EventArgs e)
        {
           textBox_username.Text = db.CustomerDetails.Where(x => x.CustomerId == customerId).Single().CustomerName;
        }
    }
}
