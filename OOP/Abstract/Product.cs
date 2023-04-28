using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Product
    {
        protected string name;
        protected string description;
        protected float price;

        public Product(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public virtual void CalculatePrice()
        {
            Console.WriteLine("Calculate product price");
            price *= 1.3f;
        }

        public abstract void ShowSale();
    }
}
