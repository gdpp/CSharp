using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class World
    {
        private static string gameMode;

        private int chunks;
        private string type;

        public World()
        {
            chunks = 0;
            type = string.Empty;
        }

        public World(int chunks, string type)
        {
            this.chunks = chunks;
            this.type = type;
        }

        public string GameMode
        {
            set { gameMode = value; }
        }

        public void ShowWorld()
        {
            Console.WriteLine($"The world has {chunks} chunks and is {type} type, in {gameMode} game mode");
        }

        public static void GenerateWorld(int chunks)
        {
            Console.WriteLine($"Generating World with {chunks} chunks...");
        }
    }
}
