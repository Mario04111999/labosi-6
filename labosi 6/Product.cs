using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{//zadatak 2
    class Product
    {
        public string Description { get; private set; }
        public double Price { get; private set; }
        public Product(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.Description + ":\n" + this.Price;
        }
    }
}
