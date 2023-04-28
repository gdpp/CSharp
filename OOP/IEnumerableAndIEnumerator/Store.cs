using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    class Store
    {
        private Car[] availables;

        public Store()
        {
            availables = new Car[4];

            availables[0] = new Car("Soul", 220000.50);
            availables[1] = new Car("Fit", 175600.70);
            availables[2] = new Car("Spark", 160400.40);
            availables[3] = new Car("Marck", 168900.00);
        }

        public IEnumerator GetEnumerator()
        {
            return availables.GetEnumerator();
        }
    }
}
