namespace Excersise_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [X] Given a number with ABC form, Create a program that produce numbers CBA and ACCB.
            // Example:
            // Input: 731
            // Output: 137 and 7113

            // Input
            int a = 7;
            int b = 3;
            int c = 1;

            //Output
            int num1 = 0;
            int num2 = 0;


            // Calculate num1
            num1 = (c * 100) + (b * 10) + a;

            //Calculate num2
            num2 = (a * 1000) + (c * 100) + (c * 10) + b;


            //Result
            Console.WriteLine("CBA: {0}", num1);
            Console.WriteLine("ACCB: {0}", num2);
        }
    }
}