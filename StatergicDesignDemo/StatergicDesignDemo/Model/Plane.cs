using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatergicDesignDemo.Model
{
    public class Plane : TravelStartegy
    {
        public Plane() { 
        kmCost = 50;
        }
        public override decimal Drive(int km)
        {
            return km*kmCost;
        }
    }
}
