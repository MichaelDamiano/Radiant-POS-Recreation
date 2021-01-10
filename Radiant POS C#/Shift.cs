using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantLibrary
{
    class Shift
    {
        public int storeID { get; set; }
        public int shiftID { get; set; }
        public string cashierName;
        //public static DateTime Now { get; }
        public bool termed = false;
        List<Sale> sales = new List<Sale>();
        
        public Shift(string cashierName, int shiftID)
        {
            this.cashierName = cashierName;
            this.shiftID = shiftID;
        }

        public void createSale()
        {
            sales.Add(new Sale());
        }

        public void endShift()
        {
            termed = true;
        }
        
        public string toString()
        {
            string str;
            if (termed)
            {

            }
            else
            {
                str = "Mid-Shift Cash Info Report\n==========================\n";
                str = str + "Store ID:          " + storeID
                    + "\nBusiness Date:         " + "2/27/97" // just the date
                    + "\nCashier Name:          " + "???"///////////////
                    + "\nShift ID:              " + shiftID
                    + "\nReport Time:           " + "1:23 PM" //date and time
                    + "\n==========================\n";
            }

                return null;
        }
    }
}
