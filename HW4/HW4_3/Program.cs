using System;
using System.Collections.Generic;
using System.Linq;
namespace HW4_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            int[][] array = new int[rand.Next(1, 10)][];
            int oct = 0;
            var sept = new List<int>();
            var quat = new List<int>();
            var mult = new List<int>();
            var min = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new int[rand.Next(1, 10)];
                for (var j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(99);
                    Console.Write(array[i][j] + ", ");

                    if (array[i][j] % 8 == 0) oct++;
                    if (array[i][j] % 7 == 0)
                    {
                        sept.Add(array[i][j]);
                        mult.Add(array[i][j]*9);
                    }
                    if (array[i][j] % 4 == 0)
                    {
                        quat.Add(array[i][j]);
                        mult.Add(array[i][j]*9);
                    }
                }
            }
            Console.WriteLine();
            
            try
            {
                Console.Write(oct + " элементов дляться на 8 без остатка \n");
                for (int i = 0; i < 4; i++) Console.Write(sept[i] + ", ");
                Console.WriteLine(" : на 7");
                for (int i = 1; i <= 3; i++)
                {
                    Index ind = new Index(i, true);
                    Console.Write(quat[ind] + ", ");
                }
                Console.WriteLine(" : на 4");
                
                foreach (var m in mult) Console.Write(m + ", ");
                Console.WriteLine(" : на 4 и 7 * 9");
                
                for (int i = 0; i < array.Length; i++)
                { 
                    min.Add(array[1].Where(i => i % 2 != 0).ToArray().Min());
                }
                Console.WriteLine(min.Min() + " -  минимальное значение среди нечетных значений и в четных строках.");
                
                
            }
            catch (Exception e)
            {
                Console.Write(" \n Ошибка!!! " + e);
            }
            

            //delay
            Console.Read();
        }
    }
}