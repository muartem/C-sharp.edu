using System.Collections.Generic;

namespace HW8_2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Salmon(),
                new Tuna()
            };

            foreach (var a in animals)
            {
                switch (a)
                {
                    case Dog dog:
                        dog.wagTale();
                        break;
                    case Mammals mammals:
                        mammals.eatMilk();
                        break;
                    case Fish fish:
                        fish.breatheWater();
                        break;
                }
                a.singSong();
            }
            
        }
    }
}