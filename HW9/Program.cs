using System;

namespace HW9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var wardrobe = new Wardrobe();
            var time = DateTime.Now;
            time = time.AddHours(14);
            
            if (time.Hour > wardrobe.Open && time.Hour < wardrobe.Close){
                while (true)
                {
                    Console.WriteLine("1 - дать, 2 - взять, 3 - бежать !");
                    var answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                        {
                            var rand = new Random();
                            var index = rand.Next(1, 299);
                            while (wardrobe[index] != null)
                            {
                                index = rand.Next(1, 299);
                            }
                            
                            wardrobe[index] = Console.ReadLine();
                            Console.WriteLine("Твой ключик №" + index);
                            break;
                        }
                        case "2":
                        {
                            var index = Convert.ToInt32(Console.ReadLine());
                            while (wardrobe[index] == null)
                            {
                                Console.WriteLine("Такой вещи нет, разбойник!");
                                index = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine(index);
                            Console.WriteLine(wardrobe[index]);
                            break;
                        }
                        case "3": return;
                        default:
                            Console.WriteLine("Шо ты ввел?");
                            break;
                    }
                }
            } else Console.WriteLine("Приходи в рабочее время!!!");
        }
    }
}

