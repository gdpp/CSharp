namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            for(n = 0; n < 5; n++)
            {
                Console.WriteLine(n);
            }

            int x;

            for(x = 0; x < 50; x++)
            {
                Console.WriteLine(x * 2);
            }

            int y;

            for(y = 10; y > 1; y--)
            {
                Console.WriteLine(y);
            }
        }
    }
}