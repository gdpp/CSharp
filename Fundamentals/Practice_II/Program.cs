namespace Practice_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert Celsius to Farenheit

            double c = 38.3f;
            double f = 0f;

            // Convert
            f = (c * 1.8) + 32;

            // Show Result
            Console.WriteLine("{0} Celsius are {1} Farenheit", c, f);
        }
    }
}