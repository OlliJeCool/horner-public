using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner
{
    class Horner
    {
        #region Properties
        public double[] _input { get; set; }
        #endregion

        #region Functions
        public double[] SolveHorner(List<double> divisors)
        {
            double[] input = _input;
            double[] output = new double[input.Length - 1];
            double[] shorter = new double[input.Length];
            for (int k = 0; k < input.Length - 1; k++)
            {
                for (int i = 0; i < divisors.Count; i++)
                {
                    double temp = 1;
                    shorter[0] = 1;
                    for (int j = 1; j < input.Length; j++)
                    {
                        temp = (divisors[i] * temp) + input[j];
                        shorter[j] = temp;
                        
                    }
                    if (temp == 0)
                    {
                        WriteStep(input, shorter, divisors[i]);
                        output[k] = divisors[i];
                        Array.Copy(shorter, input, shorter.Length);
                    }
                }
            }
            return output;
        }

        public void WriteHorner(double[] input)
        {
            Console.Write($"X = ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]}, ");
            }
            Console.WriteLine("\n");
            foreach (double number in input)
            {
                if (number > 0) { Console.Write($"(x - {Math.Abs(number)})"); }
                else if (number < 0) { Console.Write($"(x + {Math.Abs(number)})"); }
            }
        }

        public List<double> GetDivisors()
        {
            List<double> divisors = new List<double>();
            double temp = Math.Abs(_input[_input.Length - 1]);
            for (int i = 1; i <= temp; i++)
            {
                if (temp % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(-1 * i);
                }
            }
            return divisors;
        }

        public void WriteStep(double[] a, double[] b, double d)
        {
            foreach(double inputnum in a)
            {
                Console.Write($"   {inputnum}     ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"\n{d}  0");
            for (int i = 1; i < a.Length; i++)
            {
                Console.Write($"     {d * b[i-1]}  ");
            }
            Console.WriteLine("\n---------------------------------------------------");
            for (int j = 0; j < b.Length; j++)
            {
                Console.Write($"   {b[j]}     ");
            }
            Console.WriteLine("\n\n\n\n\n");
        }
        #endregion
    }
}
