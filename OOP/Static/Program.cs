namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            World world2 = new World();
            World world3 = new World();

            world.GameMode = "Survival";

            world.ShowWorld();
            world2.ShowWorld();
            world3.ShowWorld();

            world.GameMode = "Creative";

            world.ShowWorld();
            world2.ShowWorld();
            world3.ShowWorld();

            World.GenerateWorld(5);
        }
    }
}