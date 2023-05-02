using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Radio
    {
        // This method will work as delegate
        public static void RadioMethod(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We are in the Radio class");
            Console.WriteLine("This is your message: {0}", msg);
        }
    }
}
