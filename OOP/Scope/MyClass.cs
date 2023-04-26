using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class MyClass
    {
        // This data shows inside of any part of the class
        // but no outisde of the class, (OBJECT SCOPE)
        private int b = 10;

        public void Show()
        {
            // Create a local variable in Show
            // Local Scope
            int m = 5;
            int b = 3;

            // I can use the local variable
            Console.WriteLine("m={0}", m);

            // i can use the local variable
            Console.WriteLine("b={0}", b);

            // i can use the object variable
            Console.WriteLine("b={0}", this.b);
        }

        public void Multiply()
        {
            b = b * 5;
        }
    }
}
