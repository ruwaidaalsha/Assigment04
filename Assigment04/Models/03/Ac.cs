using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._03
{
    public class AC : ISmartDevice
    {
        private bool On;

        public void TurnOn()
        {
            On = true;
            Console.WriteLine("AC turned ON");
        }

        public void TurnOff()
        {
            On = false;
            Console.WriteLine("AC turned OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"AC is {(On ? "ON" : "OFF")}");
        }
    }
   
}
