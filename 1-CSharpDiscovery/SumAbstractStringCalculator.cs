using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class SumAbstractStringCalculator : AbstractStringCalculator
    {
        public SumAbstractStringCalculator()
        {
            
        }

        public override double Calculate(string toCalculate)
        {
            string[] jambons;
            jambons = toCalculate.Split('+');
            return jambons.Sum(value => Convert.ToDouble(value));
        }
    }
}
