using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    // My Own Class
    class Calculator
    {
        // Attributes
        // Access       type        name
        public          double      a;
        public          double      b;
        private         double      r; // Only can work with this variable inside of the class

        // Methods
        public void Add()
        {
            // Make an action
            r = a + b;

            // Invoke private method
            Show();
        }

        private void Show()
        {
            Console.WriteLine($"a={a}, b={b}, r={r}");
        }
    }
}
