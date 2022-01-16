using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner
{
    class Application
    {
        public void Run()
        {
            double[] input = GetInput();
            var horner = new Horner() { _input = input };
            horner.WriteHorner(horner.SolveHorner(horner.GetDivisors()));
        }


        public double[] GetInput()
        {
            int degree;
            Console.Write("Zadej stupeň polynomu: ");
            int.TryParse(Console.ReadLine(), out degree);
            double[] output = new double[degree + 1];
            for (int i = 0; i <= degree; i++)
            {
                double temp;
                Console.Write($"Zadej a_{i}: ");
                double.TryParse(Console.ReadLine(), out temp);
                output[i] = temp;
            }
            return output;
        }
    }
}
