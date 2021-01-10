using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantLibrary
{
    public class Cashier
    {
        public string name { get; set; }
        public int id { get; set;}
        public bool man { get; set; }
        List<Shift> Shifts = new List<Shift>();

        public Cashier(string name, int id, bool man)
        {
            this.name = name;
            this.id = id;
            this.man = man;
        }

        public void createShift()
        {
            Shifts.Add(new Shift(name, Shifts.Count)); //for shiftID: could add a list for each individual day
        }

        public string toString()
        {
            return "name: " + this.name + ", id: " + this.id + ", manager?: " + this.man;
        }
        

    //https://www.youtube.com/watch?v=YxewTI4H2mY CONTINUE AT 34:09
}
}
