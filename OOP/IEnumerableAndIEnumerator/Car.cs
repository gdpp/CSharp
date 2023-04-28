using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    class Car:ICar
    {
        double cost;
        double tax;
        string model;

        // Constructor
        public Car(string model, double cost)
        {
            // Initialize data
            this.model = model;
            this.cost = cost;
        }

        // Interface methods
        public void CalculateTax(double t)
        {
            tax = 5000f + cost * t;
        }

        public void ShowInfo()
        {
            // show info
            Console.WriteLine("Your Car: {0}", model);
            Console.WriteLine("Cost {0}, with tax of {1}", cost, tax);
            Console.WriteLine("Total {0}", cost + tax);
            Console.WriteLine("---------------");
        }
    }
}
