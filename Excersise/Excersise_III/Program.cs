namespace Excersise_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ackerman function with recursion

            int m = 0;
            int n = 0;
            int result = 0;

            // Set Data
            Console.WriteLine("Enter the value of M:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of N:");
            n = Convert.ToInt32(Console.ReadLine());

            result = Ackerman(m, n);

            Console.WriteLine("The result is: {0}", result);
        }

        public static int Ackerman(int m, int n)
        {
            // Cases
            if(m == 0)
            {
                return n + 1;
            }
            
            if(m != 0 && n == 0)
            {
                return Ackerman(m - 1, 1);
            }

            if(m != 0 && n != 0)
            {
                return Ackerman(m - 1, Ackerman(m, n - 1));
            }

            return 0;
        } 
    }
}