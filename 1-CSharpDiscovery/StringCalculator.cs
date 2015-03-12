using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    sealed class StringCalculator : Calculator
    {
        public StringCalculator() : base ()
        {
           
        }
        public StringCalculator(String name) : base()
        {

        }

        public double Sum(String jambon)
        {
            double somme = 0;
            string[] jambons;
            jambons = jambon.Split('+');
            foreach (string value in jambons)
            {
                if (value.Trim() == "pi")
                {
                    somme += pi;
                }
                else
                {
                    somme += Convert.ToDouble(value);

                }
            }
            return somme;
        }


    }
}
