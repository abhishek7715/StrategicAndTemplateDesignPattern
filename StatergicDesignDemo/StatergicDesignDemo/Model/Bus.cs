using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatergicDesignDemo.Model
{
    public class Bus:TravelStartegy
    {
        public Bus() { kmCost = 10; }
        public override decimal Drive(int km)
        {
            return km * kmCost;
        }
    }
}
