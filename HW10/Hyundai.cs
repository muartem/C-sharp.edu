using System;
using System.Dynamic;

namespace HW10_3
{
    public class Hyundai : IDisposable
    {
        private static byte carCount = 0;
        private const byte carLimit = 10;
        public string Model { get; set; }
        public string CarClass { get; set; }
        public Hyundai(string model, string Class)
        {
            carCount++;
            if (carCount > carLimit)
            {
                this.Dispose();
                return;
            }
            this.Model = model;
            this.CarClass = Class;

        }
        public void Dispose()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("DELETE");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}