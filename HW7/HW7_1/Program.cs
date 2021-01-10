using System;
using HW7_1.Properties;

namespace HW7_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Fozzy = new Store();
            
            var Renat = new Costumer("Renat", 1000f);
            var Ivan = new Costumer("Ivan", 20f);
            Fozzy.ShowProducts();
            Fozzy.AddProduct("Spaghetti", 4f,15);
            Fozzy.AddProduct("Coca-cola",10);
            Fozzy.DelProduct("Pork");
            Ivan.Buy( Fozzy.Find("Chicken"));
            Ivan.Buy( Fozzy.Find("Coca-cola"));
            Ivan.Buy( Fozzy.Find("Beef"));
            Renat.Buy( Fozzy.Find("Coca-cola"));
            Renat.Buy( Fozzy.Find("Cheese"));
            Renat.Buy( Fozzy.Find("Beef"));
            
            Console.WriteLine();
            
            Ivan.ShowCart();
            Renat.ShowCart();
            
            Console.WriteLine();
            
            Fozzy.ShowProducts();
        }
    }
}