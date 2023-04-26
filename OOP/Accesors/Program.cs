namespace Accesors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monsterHp = 100f;

            // Create player
            Player player = new Player();

            player.SetName("Sariel");
            player.SetProfession("Archer");
            player.SetHealthPoints(300f);

            player.ShowPlayer();

            float totalDamage = player.CalculateDamage(80);

            Console.WriteLine($"Total Damage:{totalDamage}");

            if(totalDamage >= monsterHp)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
        }
    }
}