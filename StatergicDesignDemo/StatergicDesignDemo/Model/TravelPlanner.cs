using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatergicDesignDemo.Model
{
    public class TravelPlanner
    {
        private TravelStartegy _travelStartegy;
        public void SetStartegy(TravelStartegy travelStartegy)
        {
            _travelStartegy = travelStartegy;
        }
        public void Drive(int km)
        {
            var cost = _travelStartegy.Drive(km);
            Console.WriteLine("Cost of drive is : " + cost);
        }
    }
}
