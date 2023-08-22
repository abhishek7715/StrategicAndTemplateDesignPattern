using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatergicDesignDemo.Model
{
    public abstract class TravelStartegy
    {
        public int kmCost;
        public abstract decimal Drive(int km);
    }
}
