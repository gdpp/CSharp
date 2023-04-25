namespace Practice_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a program that calculates the cost of building a house
            // Set number of rooms and dimensions of each room
            // Cost by m2 of room is for $300 with 5% tax.
            // Cost by m2 of kitchen and bathroom is for $375 with 12% tax.
            // Cost by m2 of garden is for $120 with 0% tax.

            // Variables
            int numberOfRooms = 0;
            int type = 0; // 1 -> Bedroom, 2 -> Kitchen, 3 -> Garden
            double totalQuote = 0f;
            string buffer = "";

            double area = 0f;
            double roomCost = 0f;

            // Set number of rooms
            Console.WriteLine("How many rooms do you want?");
            buffer = Console.ReadLine();
            numberOfRooms = Convert.ToInt32(buffer);

            for (int i = 0; i < numberOfRooms; i++)
            {
                area = CalculateArea();

                // Set type of rooms
                Console.WriteLine("Which type of room is: 1 -> bedroom, 2 -> kitchen, 3 -> garden");
                buffer = Console.ReadLine();
                type = Convert.ToInt32(buffer);

                // Calculate cost
                if (type == 1)
                {
                    roomCost = CalculateCost(area, 300.0, 0.05);
                }
                if(type == 2)
                {
                    roomCost = CalculateCost(area, 375.0, 0.12);
                }
                if (type == 3)
                {
                    roomCost = CalculateCost(area, 120.0, 0f);
                }

                // Result
                totalQuote += roomCost; 
            }

            // Show result
            Console.WriteLine("Total Quote: {0}", totalQuote);
        }

        // Calculate area method
        public static  double CalculateArea()
        {
            double area = 0f;
            double width = 0f;
            double height = 0f;

            string buffer = "";

            Console.WriteLine("Set the room width");
            buffer = Console.ReadLine();
            width = Convert.ToDouble(buffer);

            Console.WriteLine("Set the room height");
            buffer = Console.ReadLine();
            height = Convert.ToDouble(buffer);

            area = width * height;

            return area;
        }

        // Calculate cost
        public static double CalculateCost(double area, double pM2, double tax)
        {
            double cost = 0f;
            double tx = 0f;
            double total = 0f;

            cost = area * pM2;
            tx = cost * tax;
            total = cost + tx;

            return total;
        }
    }
}