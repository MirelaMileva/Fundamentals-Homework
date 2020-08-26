using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productInfo = new Dictionary<string, Product>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] tokens = input.Split();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                Product product = new Product(name, price, quantity);

                if (!productInfo.ContainsKey(name))
                {
                    productInfo.Add(name, product);
                }
                else
                {
                    productInfo[name].Price = price;
                    productInfo[name].Quantity += quantity;
                }

            }

            foreach (var product in productInfo)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity}");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
