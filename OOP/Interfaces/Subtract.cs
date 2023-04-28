using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Subtract:IOperation
    {
        private float _r;

        public void Calculate(float a, float b)
        {
            _r = a - b;
        }

        public void ShowResult()
        {
            Console.WriteLine("The result of Subtract: {0}", _r);
        }
    }
}
