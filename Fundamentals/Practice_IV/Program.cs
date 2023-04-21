namespace Practice_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Area and Perimeter of Square

            // Variables
            string data = "";
            double sideA = 0f;
            double sideB = 0f;
            double area = 0f;
            double perimeter = 0f;

            // Get Side A
            Console.WriteLine("Side A");
            data = Console.ReadLine();
            sideA = Convert.ToDouble(data);

            // Get Side B
            Console.WriteLine("Side B");
            data = Console.ReadLine();
            sideB = Convert.ToDouble(data);

            // Calculate Area
            area = sideA * sideB;

            // Calculate Perimeter
            perimeter = 2 * (sideA + sideB);

            // Result
            Console.WriteLine($"Area: {area}");
            Console.WriteLine("Perimeter: {0}", perimeter);
        }
    }
}