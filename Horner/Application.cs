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
            double[] input = new double[] { 1, 4, 6, 4, 1 };
            var horner = new Horner();
            var output = horner.SolveHorner(input);
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
