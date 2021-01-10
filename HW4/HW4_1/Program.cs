using System;

namespace HW4_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {3, 6, 7, -5, 8, 9, -3, -1, 0, 5};

            foreach (var i  in arr)
            {
                if(i >= 0){
                    for (var j = 0; j <= (i - 1); j++) Console.Write("*");
                    Console.WriteLine();
                } else Console.WriteLine("Отрицательное количество");
            }
            
            //delay
            Console.Read();
        }
    }
}