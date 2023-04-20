namespace Practice_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Area and Perimeter of Square.

            double side = 5.0f;
            double area = 0f;
            double perimeter = 0f;

            // Calculate Area
            area = side * side;

            // Calculate Perimeter
            perimeter = side * 4;

            // Results
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}