using System.Text;

namespace Structs
{
    class Program
    {
        public struct Pokemon
        {
            public int id;
            public string name;
            public int hp;
            public string element;

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("Pokemon: {0}, Name: {1},\r\n HP: {2}, Element: {3}", id, name, hp, element);

                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            // Create variable pokemon type
            Pokemon pokemon;

            pokemon.id = 1;
            pokemon.name = "Charmander";
            pokemon.hp = 100;
            pokemon.element = "Fire";

            // Show values
            //Console.WriteLine(pokemon.id);
            //Console.WriteLine(pokemon.name);
            //Console.WriteLine(pokemon.hp);
            //Console.WriteLine(pokemon.element);

            Console.WriteLine(pokemon);

            Pokemon[] pokemons = new Pokemon[3];

            pokemons[0].id = 1;
            pokemons[1].id = 2;
            pokemons[2].id = 3;

            pokemons[0].name = "Pikachu";
            pokemons[1].name = "Squirtle";
            pokemons[2].name = "Dragonite";

            pokemons[0].hp = 150;
            pokemons[1].hp = 100;
            pokemons[2].hp = 700;

            pokemons[0].element = "Thunder";
            pokemons[1].element = "Water";
            pokemons[2].element = "Dragon";

            Console.WriteLine(pokemons[0]);
            Console.WriteLine(pokemons[1]);
            Console.WriteLine(pokemons[2]);
        }
    }
}