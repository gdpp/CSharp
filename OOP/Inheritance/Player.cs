using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player
    {
        protected string _name;
        protected int _hp;

        public Player(string name, int hp)
        {
            this._name = name;
            this._hp = hp;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int HP { get { return _hp; } set { _hp = value; } }

        public void ShowPlayer()
        {
            Console.WriteLine($"Player info: \nName: {_name} \nHP: {_hp}");
        }
    }
}
