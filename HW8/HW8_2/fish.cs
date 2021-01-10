using System;

namespace HW8_2
{
    public class Salmon : Fish
    {
        public override void singSong()
        {
            Console.WriteLine("sal-sal");
        }

        public override void breatheWater()
        {
            Console.WriteLine("bul-bul");
        }
    }

    public class Tuna : Fish
    {
        public override void singSong()
        {
            Console.WriteLine("tun-tun");
        }

        public override void breatheWater()
        {
            Console.WriteLine("bul-bul-bul");
        }

        
    }
}