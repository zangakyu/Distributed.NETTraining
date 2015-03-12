using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    using System.Security.Cryptography.X509Certificates;

    public interface IComputeStrategy
    {
        double Calculate(String a);

        bool CanCompute(String a);
    }
}
