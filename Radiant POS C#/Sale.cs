using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantLibrary
{
    class Sale
    {
        public static int numOfSales, transactionNum;
        //DateTime localDate = DateTime.Now;
        //public string time = localDate.
        public double total, subTotal, tax , fueltotal;
        public Dictionary<Item, int> items = new Dictionary<Item, int>(); //<the item itself, the quantity of the item>

        public Sale()
        {
            ////////////////////////////////////////////////?
        }

        public Sale(Item item, int quantity)
        {
            addItem(item, quantity);
        }

        public void addItem(Item item, int quantity)
        {
            items.Add(item, quantity);
            calculateTotal();
        }

        public void removeItem(Item item, int quantity)
        {
            if (items[item] == quantity)
            {
                items.Remove(item);
                calculateTotal();
            }
            else if (items[item] > quantity)
            {
                items[item] = items[item] - quantity;
                calculateTotal();
            }
            else
                Console.WriteLine("ERROR: the amount you are trying to remove (" + quantity + ") is larger than the amount recorded for the sale (" + items[item] + ")"); //might need to convert to strings
        }

        public void calculateTotal()
        {
            total = 0;
            subTotal = 0;
            tax = 0;
            fueltotal = 0;
            foreach (Item item in items.Keys)
            {
                if(item.fuel)
                {
                    fueltotal = fueltotal + item.price;
                }
                else
                {
                    subTotal = subTotal + item.price;
                }
            }

            tax = subTotal * .07;
            total = fueltotal + subTotal + tax;

        }




        public string toString()
        {
            string str = null;
            foreach(Item item in items.Keys)
            {
                str = str + item.name + " X" + items[item] + "            $" + (items[item] * item.price) + "\n";
            }
            str = str + "Sub. Total:            $" + subTotal;
            str = str + "Tax:                   $" + tax;
            str = str + "Total:                 $" + total;
            return str;
        }

        public string toStringShort()// for "print reciept" page
        {
            return total + "    " + numOfSales + "    " + "1:23 PM"; //time format: 8:51 PM
        }
    }
}
