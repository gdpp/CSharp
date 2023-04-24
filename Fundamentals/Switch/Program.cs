namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            switch (choice)
            {
                // Add
                case 1:
                    result = n1 + n2;
                    break;

                // Subtract
                case 2:
                    result = n1 - n2;
                    break;

                //Multiply
                case 3:
                    result = n1 * n2;
                    break;

                // Divide
                case 4:
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            // Result
            Console.WriteLine($"The result is: {result}");
        }
    }
}