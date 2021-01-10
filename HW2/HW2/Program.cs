using System;
using System.Reflection.Emit;

namespace HW2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string WINTER = "snow";
            const string SPRING = "flower";
            const string SUMMER = "sun";
            const string AUTUMN = "leaf";
            Console.WriteLine("Enter the month 1-12");
            
            Lbl:
            
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(month);
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine(WINTER);
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(SPRING);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(SUMMER);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine(AUTUMN);
                    break;
                default:
                    Console.WriteLine("Put 1-12");
                    goto Lbl;

            }
            
            Console.WriteLine("Again? (y/n)");
            string again = Console.ReadLine();
            if(again == "y") goto Lbl;
            
            
        }
    }
}