namespace Practice_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate area of a House

            double house_1_width = 4.3f;
            double house_1_height = 4.0f;
            double house_1_area = 0f;

            double house_2_width = 5.0f;
            double house_2_height = 6.7f;
            double house_2_area = 0f;

            double house_3_width = 2.89f;
            double house_3_height = 3.54f;
            double house_3_area = 0f;

            double total_area = 0f;

            // Area House 1
            house_1_area = house_1_width * house_1_height;

            // Area House 2
            house_2_area = house_2_width * house_2_height;

            // Area House 3
            house_3_area = house_3_width * house_3_height;

            // Total Area
            total_area = house_1_area + house_2_area + house_3_area;

            // Result
            Console.WriteLine("Total area: {0}", total_area);
        }
    }
}