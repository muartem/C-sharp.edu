using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HW2._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var light = new Home("light");
            var climatControl = new Home("climatControl");
            var windows = new Home("windows");
            var doors = new Home("doors");
            var alarm = new Alarm("alarm");
            var coffee = new Home("coffee");
            var cleaner = new Home("cleaner");
            var washer = new Home("washer");
            var dishWasher = new Home("dishWasher");
            var angryDog = new Home("angryDog");

            Console.WriteLine("Put the number:");
        Lbl:
            int btn1 = Convert.ToInt32(Console.ReadLine());
            switch (btn1)
            {
                case 1:
                    light.off();
                    climatControl.off();
                    windows.off();
                    doors.off();
                    alarm.on();
                    break;
                case 2:
                    alarm.off();
                    climatControl.on();
                    coffee.on();
                    break;
                case 3:
                case 8:
                    cleaner.on();
                    washer.on();
                    dishWasher.on();
                    break;
                default:
                    alarm.msgOwner("WARNING! Robber is here!");
                    alarm.msgSecurity("WARNING! Robber in 6th avenue, 105");
                    angryDog.on();
                    break;
            }

            

            var devices = new List<object>() { light, climatControl, windows, doors, alarm, coffee, cleaner, washer, dishWasher, angryDog };
            var ds_status =  devices.Select(d => ((Home) d).getName + " is " + (((Home) d).getEnabled ? "on" : "off"));
            foreach (var d in ds_status) Console.WriteLine(d);
            

            Console.WriteLine("Again? (y/n)");
            string again = Console.ReadLine();
            if (again == "y") goto Lbl;


        }

    }

    class Home
    {
        private bool isEnabled = false;
        private string name;

        public Home(string name)
        {
            this.name = name;
        }

        public bool getEnabled => isEnabled;

        public string getName => name;

        public void on()
        {
            this.isEnabled = true;
        }
        public void off()
        {
            this.isEnabled = false;
        }
    }

    class Alarm : Home
    {
        public void msgSecurity(string msg)
        {
            Console.WriteLine("The message to security service has been delivered: " + msg);
        }
        public void msgOwner(string msg)
        {
            Console.WriteLine("The message to security service has been delivered: " + msg);
        }

        public Alarm(string name) : base(name)
        {
            name = name;
        }
    }
}