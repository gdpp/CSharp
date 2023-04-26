using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Enemy
    {
        private int lives;
        private int attack;
        private int defense;

        public Enemy(int lives, int attack, int defense)
        {
            Console.WriteLine("This is the constructor");
            this.lives = lives;
            this.attack = attack;
            this.defense = defense;
        }

        public int Lives
        {
            get { return this.lives; }
        }
        
        public void Show()
        {
            Console.WriteLine($"Enemy lives: {lives}, atk: {attack}, def: {defense}");
        }
    }
}
