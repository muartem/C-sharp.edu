using System;

namespace HW8_1
{
    public class Phone: IRadioable, IDisplayable, ILydarable, ISMSable, ITouchIdable
    {
        public void InnerDisplay()
        {
            Console.WriteLine("Show somthing");
        }

        public void turnOnRadio()
        {
            Console.WriteLine("La-la-la");
        }

        public void ScanRoom()
        {
            Console.WriteLine("You have not furniture");
        }

        public void sendSMS()
        {
            Console.WriteLine("Sms has been sent");
        }

        public void CheckID()
        {
            Console.WriteLine("I don`t know you");
        }
    }
}