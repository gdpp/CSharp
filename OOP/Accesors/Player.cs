using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesors
{
    class Player
    {
        private string name;
        private string profession;
        private float hp;
        
        public void ShowPlayer()
        {
            Console.WriteLine($"Hi traveler, my name is: {name}, I am {profession}");
        }

        // Accesors, Getters & Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetProfession(string profession)
        {
            this.profession = profession;
        }

        public void SetHealthPoints(float hp)
        {
            this.hp = hp;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetProfession()
        {
            return this.profession;
        }

        public float GetHealthPoints()
        {
            return this.hp;
        }

        // Mutators
        public float CalculateDamage(float dmg)
        {
            return (dmg * 4) / 2;
        }
    }
}
