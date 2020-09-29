using System;

namespace SimpleAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.AddProduct("Apple", 0.99);
            order.AddProduct("Peer", 1.49);
            order.AddProduct("Orange", 0.89);
            order.AddProduct("Watermelon", 2.99);
            order.AddProduct("Tomato", 1.19);
            order.AddProduct("Mango", 1.99);

            Console.WriteLine("--- Maximum price ---");
            Console.WriteLine(order.GiveMaximumPrice());

            Console.WriteLine("--- Average price ---");
            Console.WriteLine(order.GiveAveragePrice());

            Console.WriteLine("--- All products above minimum price ---");
            foreach (Product product in order.GetAllProducts(1))
            {
                Console.WriteLine($"Name: {product.Name} - price: {product.Price}");
            }

            Console.WriteLine("--- All products sorted by price ---");
            order.SortProductsByPrice();

            Console.ReadLine();
        }
    }
}
