namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            string buffer;

            int result = 0;
            int qty;

            double[] note;

            //Get quantity of notes
            Console.WriteLine("How many notes do you want to store");
            buffer = Console.ReadLine();
            qty = Convert.ToInt32(buffer);

            note = new double[qty];

            //Get notes
            for (int x = 0; x < note.Length; x++)
            {
                Console.WriteLine("Enter the note");
                buffer = Console.ReadLine();
                note[x] = Convert.ToDouble(buffer);
            }

            for(int y = 0; y < note.Length; y++)
            {
                Console.WriteLine(note[y]);
            }

            int x = 0;
            int y = 0;
            Random rnd = new Random();

            int[,] data = new int[3, 3];

            // Fill the array

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    data[i, j] = rnd.Next(30);
                }
            }

            //Print data

            for(int i=0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(data[i, j]);
                }
            }

        }
    }
}