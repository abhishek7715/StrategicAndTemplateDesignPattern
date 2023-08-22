using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignDemo.Model
{
    internal class ConcreteAlgorithm:AlgorithamTemplate
    {
        protected override void Step1()
        {
            Console.WriteLine("Executing Step 1");
        }

        protected override void Step2()
        {
            Console.WriteLine("Executing Step 2");
        }

        protected override void Step3()
        {
            Console.WriteLine("Executing Step 3");
        }
    }
}
