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
            var horner = new Horner();
            horner.SolveHorner();
        }
    }
}
