using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class AnotherIntegerCalculator : Calculator
    {
        public AnotherIntegerCalculator() : base()
        {
            
        }

        public override double Sum(double[] toSum)
        {
            double sum = toSum.Aggregate<double, double>(0, (current, val) => current + (int)val);
            return sum;
        }
    }
}
