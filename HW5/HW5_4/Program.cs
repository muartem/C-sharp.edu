using System;

namespace HW5_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte a = 00000001, b = 00000010;
            Console.WriteLine(gt(a,b));
        }

        private static byte gt(byte a, byte b)
        {
            return a >= b ? a : b;
        }
    }
}