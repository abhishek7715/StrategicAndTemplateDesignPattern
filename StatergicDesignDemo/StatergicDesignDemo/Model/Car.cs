using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatergicDesignDemo.Model
{
    public class Car:TravelStartegy
    {
        public Car() { kmCost = 20; }
        public override decimal Drive(int km)
        {
            return km * kmCost;
        }
    }
}
