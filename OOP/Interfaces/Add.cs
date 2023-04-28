using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Add:IOperation
    {
        private float _r;
        private ArrayList _results = new ArrayList();

        // Methods to implement
        public void Calculate(float a, float b)
        {
            _r = a + b;
        }

        public void ShowResult()
        {
            Console.WriteLine("The result of Add: {0}", _r);
            _results.Add(_r);
        }

        // Own methods for the class
        public void Show()
        {
            foreach (var item in _results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
