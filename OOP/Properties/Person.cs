using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        private string name;
        private int age;
        private bool isAdult;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public bool IsAdult
        {
            get
            {
                return isAdult;
            }
            set
            {
                isAdult = value;
            }
        }

        public void Show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(IsAdult);
        }

    }
}
