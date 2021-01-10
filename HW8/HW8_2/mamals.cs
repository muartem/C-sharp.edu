using System;

namespace HW8_2
{
    public class Dog : Mammals , IWagable
    {
        public override void singSong()
        {
            Console.WriteLine("gav-gav");
        }

        public override void eatMilk()
        {
            Console.WriteLine("nyam-nyam");
        }

        public void wagTale()
        {
            Console.WriteLine("tale is wagging");
        }
    }
    public class Cat : Mammals
    {
        public override void singSong()
        {
            Console.WriteLine("Mew-mew");
        }

        public override void eatMilk()
        {
            Console.WriteLine("syup-syup");
        }
    }
}