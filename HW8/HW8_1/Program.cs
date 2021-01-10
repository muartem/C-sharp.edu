namespace HW8_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var galaxy = new Phone();
            (galaxy as IDisplayable).InnerDisplay();
            galaxy.ScanRoom();
            galaxy.turnOnRadio();
            galaxy.CheckID();
            galaxy.sendSMS();
        }
    }
}