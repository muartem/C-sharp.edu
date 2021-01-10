using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2._4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int numb = 0;
            while (numb != 666)
            {
                numb = Convert.ToInt32(Console.ReadLine());
                nums.Add(numb);
            }
            nums.RemoveAt(nums.Count-1);
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            foreach (int num in nums)
            {
                if (num % 8 == 0) Console.Write(num + " ");
            }
            Console.WriteLine();
            
            int summ = nums.Aggregate((x,y)=> x + y);
            
            Console.Write(summ);
            
            
            // Delay
            Console.ReadKey();
        }
    }
}