using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SimpleAlgorithm
{
    class Order
    {
        private List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        public void AddProduct(string name, double price)
        {
            products.Add(new Product(name, price));
        }

        public double GiveMaximumPrice()
        {
            double highestPrice = 0;
            foreach (Product product in products)
            {
                highestPrice = (product.Price <= highestPrice) ? highestPrice : product.Price;
            }
            return highestPrice;
        }

        public double GiveMaximumPrice(List<Product> products)
        {
            double highestPrice = 0;
            foreach (Product product in products)
            {
                highestPrice = (product.Price <= highestPrice) ? highestPrice : product.Price;
            }
            return highestPrice;
        }

        public double GiveAveragePrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }

            double roundedAveragePrice = Math.Round(totalPrice / products.Count, 2);

            return roundedAveragePrice;
        }

        public List<Product> GetAllProducts(double minimumPrice)
        {
            List<Product> wantedProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (minimumPrice <= product.Price)
                    wantedProducts.Add(product);
            }
            return wantedProducts;
        }

        public void SortProductsByPrice()
        {
            List<Product> productsSorted = new List<Product>();

            List<Product> tempList = MakeTempList();

            while (tempList.Count != 0)
            {
                Product product = tempList.Find(p => p.Price == GiveMaximumPrice(tempList));
                productsSorted.Add(product);
                tempList.Remove(product);
            }

            foreach (Product product in productsSorted)
            {
                Console.WriteLine($"Name: {product.Name} - price: {product.Price}");
            }
        }

        private List<Product> MakeTempList()
        {
            List<Product> tempList = new List<Product>();
            foreach (Product product in products)
            {
                tempList.Add(product);
            }
            return tempList;
        }
    }
}
