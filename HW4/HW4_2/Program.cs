using System;
using System.Collections.Generic;
using System.Linq;

namespace HW4_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {3, 6, 7, -5, 8, 9, -3, -1, 0, 5};
            
            var arr2 = new List<int>();
            for (int i = 0; i < arr.Length; i++) if (i % 2 != 0) arr2.Add(arr[i]);
            Console.WriteLine(arr2.Min());
            
            
            //delay
            Console.Read();
        }
    }
}