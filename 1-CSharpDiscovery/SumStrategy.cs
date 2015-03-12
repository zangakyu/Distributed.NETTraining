using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class SumStrategy : IComputeStrategy
    {
        public double Calculate(string toCalculate)
        {
            var jambons = toCalculate.Split('+');
            return jambons.Sum(value => Convert.ToDouble(value));
        }

        public bool CanCompute(string a)
        {
            if (a.Contains("+"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
