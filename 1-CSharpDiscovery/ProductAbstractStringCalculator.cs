using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class ProductAbstractStringCalculator : AbstractStringCalculator
    {
        public override double Calculate(string toCalculate)
        {
            var jambons = toCalculate.Split('*');
            return jambons.Aggregate<string, double>(1, (current, x) => current*Double.Parse(x));
        }
    }
}
