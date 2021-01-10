using System.Configuration;

namespace HW7_1
{
    public class Product
    {
        public string Name { get;}
        public float Cost { get;}
        public int Quantity { get; set; }

        public Product(string Name, float Cost, int Quantity)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Quantity = Quantity;
        }
    }
    
}