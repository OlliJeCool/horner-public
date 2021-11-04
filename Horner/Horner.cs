using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner
{
    class Horner
    {

        public double[] SolveHorner()
        {
            double[] input = new double[] { 1, 4, 6, 4, 1 };
            double[] divisors = new double[] { 1, -1 };
            double[] shorter = new double[input.Length];
            for (int i = 0; i < divisors.Length; i++)
            {
                double temp = 1;
                for (int j = 1; j < input.Length; j++)
                {
                   temp = (temp * divisors[i]) + input[j];
                }
                if(temp == 0)
                {
                    Console.WriteLine(divisors[i]);
                }
            }
            return divisors;
        }
    }
}
