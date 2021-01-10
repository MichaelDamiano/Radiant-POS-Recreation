using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantLibrary
{
    class Item
    {
        Dictionary<string, double> dict = new Dictionary<string, double>()
         {{"coke", 2.99},{"gum", 1.59},{"cigarettes", 9.57},{"87", 3.019},{"89", 3.229},{"91", 3.359},{"93", 3.379},{"Diesel", 3.089}};
        string[] fuelTypes = {"87", "89", "91", "93", "Diesel" }; 
        public bool fuel = false;

        public string name
        {
            get { return name; }
            set { name = value; }
        }
        public double price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(string item)
        {
            this.name = item;
            this.price = dict[item];
            if(fuelTypes.Contains(name))
            {
                fuel = true;
            }
        }

        public string toString()
        { 
            return name + "     " + price; ////////////////////////////////////////////////
        }

    }
}
