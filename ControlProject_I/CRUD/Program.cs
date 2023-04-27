using System;
using static CRUD.Program;

namespace CRUD
{
    class Program
    {
        public struct Pokemon
        {
            public int id;
            public string name;
            public string type;
            public int hp;
            public bool inTeam;
        }

        public static List<Pokemon> pokemonList = new List<Pokemon>();
        public static int pokemonCounter = 1;

        static void Main(string[] args)
        {
            string buffer = "";
            int option = 0;

            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("******* POKEDEX *******");
                Console.WriteLine("***********************");
                Console.WriteLine("***Select an option:***");
                Console.WriteLine("   1. ADD POKEMON      ");
                Console.WriteLine("   2. LIST POKEMONS     ");
                Console.WriteLine("   3. EDIT POKEMON     ");
                Console.WriteLine("   4. DELETE POKEMON   ");
                Console.WriteLine("   5. EXIT        ->   ");
                buffer = Console.ReadLine();
                option = Convert.ToInt32(buffer);

                switch (option)
                {
                    case 1:
                        char exit = 'n';

                        do
                        {
                            AddPokemon();
                            Console.WriteLine("Add another pokemon: y/n");
                            exit = Convert.ToChar(Console.ReadLine());
                        } while (exit != 'n');
                        
                        break;
                    case 2:
                        ListPokemons();
                        break;
                    case 3:
                        ListPokemons();
                        Console.WriteLine("UPDATE");
                        break;
                    case 4:
                        DeletePokemon();
                        break;
                }
            } while (option != 5);

            Console.WriteLine("Thanks For Use Your Pokedex System");
            Console.WriteLine("Goodbye");
        }

        public static void AddPokemon() 
        {
            string bffr;
            

            Pokemon newPokemon = new Pokemon();

            Console.WriteLine("*** Add New Pokemon. ***");
            Console.WriteLine("Enter Name:");
            newPokemon.name = Console.ReadLine();
            Console.WriteLine("Enter Type:");
            newPokemon.type = Console.ReadLine();
            Console.WriteLine("Enter Health Points:");
            newPokemon.hp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Save in Team or in Storage");
            bffr = Console.ReadLine();

            if (bffr == "T" || bffr == "t")
            {
                newPokemon.inTeam = true;
            }
            else
            {
                newPokemon.inTeam = false;
            }

            newPokemon.id = pokemonCounter;

            pokemonList.Add(newPokemon);

            pokemonCounter++;
            Console.WriteLine("Pokemon Saved!");
        }

        public static void ListPokemons()
        {
            Console.WriteLine("List Of Pokemons:");

            foreach (Pokemon pokemon in pokemonList)
            {
                Console.WriteLine(pokemon.id);
                Console.WriteLine(pokemon.name);
                Console.WriteLine(pokemon.type);
                Console.WriteLine(pokemon.hp);
                Console.WriteLine(pokemon.inTeam ? "In Team" : "In Storage");
            }
        }

        public static void DeletePokemon()
        {
            int id;

            ListPokemons();
            Console.WriteLine("----------------");
            Console.WriteLine("Which pokemon want to delete?");
            id = Convert.ToInt32(Console.ReadLine());

            string pokemonId = pokemonList.Where(pokemon => pokemon.id == id).ToString();

            //pokemonList.Where(pokemon => pokemon.id == id));

            //if ()
            //{
            //    Console.WriteLine("Pokemon Deleted!");
            //}
            //else
            //{
            //    Console.WriteLine("Error to Delete pokemon");
            //}
        }
    }
}