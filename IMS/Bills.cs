using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class Bills : Form
    {
        static long customerId;
        IMSEntities db = CommonUtilities.getConnection();

        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            comboBox_month.DataSource = months;

            comboBox_year.Items.Clear();
            for (int i = 2007; i <= DateTime.Now.Year + 5; i++)
            {
                comboBox_year.Items.Add(i);
            }
        }

        public void setCustomerId(long selectedCustomerId)
        {
            customerId = selectedCustomerId;
            //throw new NotImplementedException();
        }

        private void checkBox_monthlyBill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_monthlyBill.Checked)
            {
                comboBox_month.Visible = true;
                comboBox_year.Visible = true;
                checkBox_dailyBill.Checked = false;
                dateTimePicker_date.Visible = false;
                   
            }
            else
            {
                comboBox_year.Visible = false;
                comboBox_month.Visible = false;
                groupBox_userBills.Visible = false;
            }
            button_viewBill.Visible = true;

        }

        private void button_viewBill_Click(object sender, EventArgs e)
        {
            
            //Month is Selected
            if (checkBox_monthlyBill.Checked)
            {
                if (comboBox_month.SelectedItem != null && comboBox_year.SelectedItem != null)
                {
                    String selectedMonth = comboBox_month.SelectedItem.ToString();
                    String selectedYear = comboBox_year.SelectedItem.ToString();

                    

                    int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture).Month; 
                    int year = Int32.Parse(selectedYear);

                    int noOfDays = DateTime.DaysInMonth(year, monthNumber);

                    DateTime startDate = new DateTime(year,monthNumber,1);
                    DateTime endDate = new DateTime(year,monthNumber,noOfDays);

                    dataGridView_userBills.Visible = true;
                    dataGridView_userBills.DataSource = db.DailyPurchases.Where(x => x.PurchaseDate > startDate && x.PurchaseDate <= endDate).ToList();


                    dataGridView_userBills.Columns["CustomerId"].Visible = false;
                    dataGridView_userBills.Columns["PurchaseTime"].Visible = false;
                }
                else
                {
                    CommonUtilities.showErrorPopUp("Please Select month and year");
                }

                groupBox_userBills.Visible = true;
            }
            else
            {
                groupBox_userBills.Visible = true;
                DateTime date = DateTime.Parse(dateTimePicker_date.Text);

               dataGridView_userBills.Visible = true;
               dataGridView_userBills.DataSource = db.DailyPurchases.Where(x => x.PurchaseDate == date).ToList();

               dataGridView_userBills.Columns["CustomerId"].Visible = false;
               dataGridView_userBills.Columns["PurchaseTime"].Visible = false;
            }
        }

        private void checkBox_dailyBill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dailyBill.Checked)
            {
                dateTimePicker_date.Visible = true;
                checkBox_monthlyBill.Checked = false;
                comboBox_month.Visible = false;
                comboBox_year.Visible = false;
                button_viewBill.Visible = true;
            }
            else 
            {
                dateTimePicker_date.Visible = false;
                groupBox_userBills.Visible = false;

            }
        }
    }
}
