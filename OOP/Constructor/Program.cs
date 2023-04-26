namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor
            // Method that invoke automatically when the class is instatiated
            // Same name as the class
            // No return value
            // the function of constructor is set the object in an initial state that be safe and stable

            Enemy enemy = new Enemy(3, 5, 7);

            Console.WriteLine(enemy.Lives);
            enemy.Show();
        }
    }
}