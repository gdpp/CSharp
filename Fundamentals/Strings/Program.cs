namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name = "";
            string lastN = "";

            // Input the name
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            // Show message
            Console.WriteLine("Hello {0}, how are you?", name);

            // Input the name again
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            // Input the last name
            Console.WriteLine("Enter your last name:");
            lastN = Console.ReadLine();

            // Show message
            Console.WriteLine("Hello {0} {1} nice to meet you", name, lastN);
        }
    }
}