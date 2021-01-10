using System;
using System.Linq;

namespace HW5_3
{
    internal class Program
    {
        public static void Main(string[] args)
            {
                var array1 = generate();
                var array2 = generate(5, -10, 0);
                log(in array1);
                log(in array2);
                insert(ref array1, array2, 4);
                log(in array1);
            
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
            private static void insert(ref int[] arr1, int[] arr2, int ind)
            {
                arr1 = (arr1.Where((a, i) => i < ind)
                    .Concat(arr2))
                    .Concat(arr1.Where((a,i) => i >= ind))
                    .ToArray();
            }
        }
}
