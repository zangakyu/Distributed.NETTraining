using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class IntegerCalculator : Calculator
    {
        public IntegerCalculator() : base()
        {
            
        }

        public IntegerCalculator(String name) : base()
        {
            
        }

        public new double Sum(double[] x)
        {
            double sum = x.Aggregate<double, double>(0, (current, val) => current + (int) val);


            return sum;
        }
    }
}
