using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Cake
    {
        // this method will work as delegate
        public static void ShowCake(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Cake will have the message: {0}", msg);
        }
    }
}
