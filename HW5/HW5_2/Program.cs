using System;
using System.Linq;

namespace HW5_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = generate(10, -10, 10);
            log(in array);
            sort(ref array);
            log(in array);
            
            //
            Console.ReadKey();
        }
        
        private static int[] generate(int length = 10, int min = 0, int max = 10)
        {
            var rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++) array[i] = rand.Next(min, max);
            return array;
        }
        private static void log(in int[] arr)
        {
            foreach (var a in arr) Console.Write(a + ", ");
            Console.WriteLine();
        }
        private static void sort(ref int[] arr)
        {
            arr = (arr.Where(a => a < 0).Concat(arr.Where(a => a >= 0))).ToArray();
        }
    }
}