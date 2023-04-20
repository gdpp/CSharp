namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            // + Add
            // - Substract
            // * Multiply
            // / Division
            // % Module
            // = Assign
            // () Grouping

            double x = 4.7f;
            double y = 7.8f;
            double result = 0.0;

            result = x + y;

            Console.WriteLine(result);

            result = x - y;

            Console.WriteLine(result);

            result = x * y;

            Console.WriteLine(result);

            result = x / y;

            Console.WriteLine(result);
            
            result = x % y;

            Console.WriteLine(result);
        }
    }
}