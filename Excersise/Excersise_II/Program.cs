namespace Excersise_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [X] Create a program that calculates the Square Root of any number
            // It calculates with Math.Sqrt();

            // Input
            double number = 0;
            double root = 0;
            string buffer;

            Console.WriteLine("Enter a number:");
            buffer = Console.ReadLine();
            number = Convert.ToDouble(buffer);

            root = Math.Sqrt(number);

            Console.WriteLine("Square Root of {0} is: {1}", number, root);
        }
    }
}