namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methods
            // Code Reuse
            // Specialization
            // Easy maintenance and depuration

            // Variables
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double n5 = 0;
            double average = 0;

            n1 = GetNumber(1); 
            n2 = GetNumber(2);
            n3 = GetNumber(3);
            n4 = GetNumber(4);
            n5 = GetNumber(5);

            average = (n1 + n2 + n3 + n4 + n5) / 5;
            GetAverage(average);

            AddTwoNumbers();
            AddTwoNumbers(25);
            AddTwoNumbers(50, 100);
        }

        public static double GetNumber(int n)
        {
            double number = 0.0;
            string buffer = "";
            Console.WriteLine("Enter the {0} note:", n);
            buffer = Console.ReadLine();
            number = Convert.ToDouble(buffer);
            return number;
        }


        public static void GetAverage(double average)
        {
            Console.WriteLine($"Average: {average}");
        }

        public static void AddTwoNumbers(float x = 5, float y = 10)
        {
            float result = 0f;
            result = x + y;
            Console.WriteLine("Result {0}", result);
        }
    }
}