using System;
using System.Collections.Generic;

namespace HW7_1
{
    public class Costumer
    {
        public string Name { get;}
        public float Wallet { get; set; }

        private List<Product> cart = new List<Product>();
        public Costumer(string Name, float Wallet)
        {
            this.Name = Name;
            this.Wallet = Wallet;
        }

        public void Buy(Product product)
        {
            if ((product.Cost <= Wallet) && (product.Quantity > 0))
            {
                Wallet -= product.Cost;
                product.Quantity--;
                cart.Add(product);
            } else Console.WriteLine("Find the job, "+ Name);
        }
        public void ShowCart()
        {
            float total = 0;
            foreach (var c in cart)
            {
                Console.WriteLine($"Name: {c.Name} Cost: {c.Cost} ");
                total += c.Cost;
            }
            Console.WriteLine($"{Name}, you spend {total} Euro");
        }
    }
}