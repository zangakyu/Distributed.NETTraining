using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    internal class ProductStrategy : IComputeStrategy

{
        public double Calculate(string toCalculate)
        {
            var jambons = toCalculate.Split('*');
            double sum = jambons.Aggregate<string, double>(1, (current, x) => current * Double.Parse(x));
            return sum;
        }

        public bool CanCompute(string a)
        {
            if (a.Contains("*"))
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
