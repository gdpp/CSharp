using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Simple delegate
    class Program
    {
        // Define the delegate with the options of interest
        delegate void DelegateObject(string message);
        delegate int MathOperation(int number1, int number2);

        static void Main(string[] args)
        {
            // Delegates
            // A delegate is a type that represents a reference to a method.
            // A delegate can be used to encapsulate a method and pass it as a parameter to
            // another method or to store it in a variable and call it later.
            
            // Create an object of delegate and refer to a method
            DelegateObject TheDelegate = new DelegateObject(Radio.RadioMethod);

            // Using
            TheDelegate("Radio");

            TheDelegate = new DelegateObject(Cake.ShowCake);

            TheDelegate("Happy Birthday");

            // Predicated Delegates
            List<int> numbersList = new List<int>();

            numbersList.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Predicate<int> predicateDelegate = new Predicate<int>(IsPairs);

            List<int> pairNumbers = numbersList.FindAll(predicateDelegate);

            foreach (int pairNumber in pairNumbers)
            {
                Console.WriteLine(pairNumber);
            }

            //Lambda expressions
            MathOperation op = new MathOperation((num1, num2) => num1 + num2);
            Console.WriteLine(op(4, 7));
        }

        static bool IsPairs(int number)
        {
            return number % 2 == 0;
        }

        //public static int Add(int n1, int n2)
        //{
        //    return n1 + n2;
        //}
    }
}