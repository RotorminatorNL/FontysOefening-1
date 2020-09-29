using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithm
{
    class Product
    {
        public double Price { get; private set; }
        public string Name { get; private set; }

        public Product()
        {
            Name = "";
            Price = 0;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
