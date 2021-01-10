using System;
using System.Collections.Generic;
using System.Linq;

namespace HW7_1.Properties
{
    public class Store
    {
        private List<Product> products = new List<Product>();
        
        public Store()
        {
          products.Add(new Product("Coca-cola", 6f, 48));
          products.Add(new Product("Chicken", 12f, 3));
          products.Add(new Product("Pork", 14f, 2));
          products.Add(new Product("Beef", 16f, 3));
          products.Add(new Product("Water", 4f, 24));
          products.Add(new Product("Cheese", 8f, 1));
          products.Add(new Product("Sauce", 2f, 20));
        }
        
        public void AddProduct(string name, float cost, int quantity)
        {
            products.Add(new Product(name, cost, quantity));
        }
        public void AddProduct(string name, int quantity)
        {
            foreach (var p in products.Where(p => p.Name == name)) p.Quantity += quantity;
        }
        
        public void DelProduct(string name)
        {
            products = products.Where(p => p.Name != name).ToList();
        }

        public void ShowProducts()
        {
            foreach (var p in products) Console.WriteLine($"Name: {p.Name} Cost: {p.Cost} Quantity: {p.Quantity}");
        }

        public Product Find(string name)
        {
            return products.FirstOrDefault(p => p.Name == name);
        }
    }
}