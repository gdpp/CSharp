using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    class Mage:Player
    {
        private int _mana;
        private string _type;

        public Mage(string name, int hp, int mana, string type):base(name, hp)
        {
            this._mana = mana;
            this._type = type;
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }   

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void SetData(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public void ShowMage()
        {
            ShowPlayer();
            Console.WriteLine($"Mage info: \nMana: {_mana} \nType: {_type}");
        }
    }
}
