using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class Calculator
    {
        public  String name;
        public static readonly double pi = 3.14;
        public Calculator()
        {

        }
        public Calculator(String name)
        {
            setName(name);
        }
        public double sumOfTheArray(double[] tab)
        {
            double somme = 0;
            foreach (double value in tab)
            {
                somme += value;
            }
            return somme;
        }
        public double calculfromString(String jambon)
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

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
   }
}
