using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 104;
            
            List<int> nums = new List<int>();
            for (int num = num1; num <= num2; num++)
            {
                if (num % 8 == 0) nums.Add(num);
            }

            
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            int summ = nums.Aggregate(( x,y)=> x + y);
            float average = summ / nums.Count;    
            Console.WriteLine(average);
            
            // Delay
            Console.ReadKey();
        }
    }
}