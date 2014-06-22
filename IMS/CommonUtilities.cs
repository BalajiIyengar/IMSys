using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    class CommonUtilities
    {
       static IMSEntities db = null;

        /// <summary>
        /// Common Search Functionality based on various parameters
        /// </summary>
        /// <returns></returns>
        public static List<CustomerDetail> getSearchResults(String firstName, String lastName, int enteredBalance)
        {
            getConnection();
            List<CustomerDetail> searchResults = new List<CustomerDetail>();

            //Search Result (List of usernames)

            if(db.CustomerDetails.Count() > 0)
             searchResults = db.CustomerDetails.Where(x => x.CustomerName.Contains(firstName) && x.LastName.Contains(lastName) && x.Balance >= enteredBalance).OrderBy(x => x.CustomerName).ToList();
           
            return searchResults;

        }

        public static IMSEntities getConnection()
        {
            if (db == null)
            {
                db = new IMSEntities();
            }
         return db;
        }

        public static void showSuccessPopup(String message)
        {
            MessageBox.Show(message, "Success");
        }


        public static void showErrorPopUp(String message)
        {
            MessageBox.Show(message, "Error");
        }

    }


}
