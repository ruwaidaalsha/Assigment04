using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._03
{
    public class Fan : ISmartDevice
    {
        private bool On;

        public void TurnOn()
        {
            On = true;
            Console.WriteLine("Fan turned ON");
        }

        public void TurnOff()
        {
            On = false;
            Console.WriteLine("Fan turned OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Fan is {(On ? "ON" : "OFF")}");
        }

    }
}
