namespace Variables_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 1.16;
            bool isActive = true;
            char letter = 'A';
            string word = "Hello";
            int number = 19;

            Console.WriteLine($"Tax = {tax} number = {number}");

            Console.WriteLine($"isActive = {isActive} letter = {letter}");

            Console.WriteLine($"The word say {word}");

            isActive = false;
            letter = '&';
            word = "World";
        }   
    }
}