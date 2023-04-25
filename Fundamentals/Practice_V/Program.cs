namespace Practice_V
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[11];
            int number = 0;
            string buffer = "";

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number between 0 and 10:");
                buffer = Console.ReadLine();
                number = Convert.ToInt32(buffer);

                values[number]++;
            }

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("The number {0} shows {1} times", i, values[i]);
            }
        }
    }
}