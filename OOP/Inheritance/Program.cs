namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player timmy = new Player("Merlin", 10);

            timmy.ShowPlayer();

            Mage wizard = new Mage("Melodias", 12, 5, "Fire");

            wizard.ShowMage();
        }
    }
}