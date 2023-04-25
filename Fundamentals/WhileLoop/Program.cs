namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            string bffr;

            do
            {
                Console.WriteLine("Desea Continuar? 1 - Si, 9 - No");
                bffr = Console.ReadLine();
                opt = Convert.ToInt32(bffr);
            } while (opt != 9);

            int x = 300;
            while (x != 0)
            {
                Console.WriteLine(x);
                x -= 10;
            }
        }
    }
}