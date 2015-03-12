using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class ComposedStringCalculator
    {
        private readonly IComputeStrategy[] strategies;
        public ComposedStringCalculator(IComputeStrategy[] i)
        {
          this.strategies = i;
        }

        public double Calculate(string p0)
        {
            foreach (var strategy in strategies)
            {
                if (strategy.CanCompute(p0))
                {
                    return strategy.Calculate(p0);
                }
            }
            return -1;
        }
    }
}
