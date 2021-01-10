

namespace HW6_2
{
    public class Book
    {
        private string name;
        private string genre;
        private float price;
        private byte quantity;

        public Book(string name, string genre, float price, byte quantity)
        {
            this.name = name;
            this.genre = genre;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Genre
        {
            get => genre;
            set => genre = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }

        public byte Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}