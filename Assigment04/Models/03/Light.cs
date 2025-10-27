using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._03
{
    public class Light : ISmartDevice
    {
        private bool On;

        public void TurnOn()
        {
            On = true;
            Console.WriteLine("Light turned ON");
        }

        public void TurnOff()
        {
            On = false;
            Console.WriteLine("Light turned OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Light is {(On ? "ON" : "OFF")}");
        }
    }
}
