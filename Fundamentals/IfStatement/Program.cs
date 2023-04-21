using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Selective Structures
            // if(expression) sentence;
            // else if(expression) sentence;
            // else sentence;
            // Relational Operators (==, >, <, >=, <=)
            // Logic Operators (AND (&&), OR (||), NOT (!))

            int a = 5;
            int b = 8;
            int c = 5;

            if (a == c)
            {
                Console.WriteLine("A and C are EQUALS");
            }

            if(b > c)
            {
                Console.WriteLine("B is GREATER than C");
            }

            if(a > c)
            {
                Console.WriteLine("A is GREATER than C");
            }

            Console.WriteLine("GOOD BYE!");

            // EXECUTE ADD, SUBTRACT, MULTIPLY OR DIVIDE OF TWO NUMBERS.

            string buffer = "";

            double n1;
            double n2;
            int choice;
            double result = 0;

            // Get 1st number
            Console.WriteLine("Enter the first number");
            buffer = Console.ReadLine();
            n1 = Convert.ToDouble(buffer);

            // Get 2nd number
            Console.WriteLine("Enter the second number");
            buffer = Console.ReadLine();
            n2 = Convert.ToDouble(buffer);

            // Choose operation
            Console.WriteLine("1. ADD, 2. SUBTRACT, 3.MULTIPLY, 4.DIVIDE");
            Console.WriteLine("What operation whish?");
            buffer = Console.ReadLine();
            choice = Convert.ToInt32(buffer);

            // Add
            if(choice == 1)
            {
                result = n1 + n2;
            }

            // Subtract
            if (choice == 2)
            {
                result = n1 - n2;
            }

            //Multiply
            if(choice == 3)
            {
                result = n1 * n2;
            }

            // Divide
            if (choice == 4)
            {
                result = n1 / n2;
            }

            // Result
            Console.WriteLine($"The result is: {result}");


            // CONVERT METER TO FEET OR FEET TO METERS, BASED ON USER SELECTION

            string bffr = "";

            int option;
            double meters;
            double feet;

            // Menu
            Console.WriteLine("1. Meters to Feet");
            Console.WriteLine("2. Feet to Meters");
            Console.WriteLine("Select an option:");
            bffr = Console.ReadLine();
            option = Convert.ToInt32(bffr);


            // Meters to Feet
            if(option == 1) 
            { 
                Console.WriteLine("Enter the meters");
                bffr = Console.ReadLine();
                meters = Convert.ToDouble(bffr);

                // Calculate Feet
                feet = meters * 3.28;

                Console.WriteLine("{0} meters are {1} feet", meters, feet);
            }

            // Feet to Meters
            if (option == 2)
            {
                Console.WriteLine("Enter the feet");
                bffr = Console.ReadLine();
                feet = Convert.ToDouble(bffr);

                // Calculate Feet
                meters = feet / 3.28;

                Console.WriteLine("{0} feet are {1} meters", feet, meters);
            }
        }
    }
}