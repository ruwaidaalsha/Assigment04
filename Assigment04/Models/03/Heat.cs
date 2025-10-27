using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._03
{
    public class Heater : ISmartDevice
    {
        private bool On;

        public void TurnOn()
        {
            On = true;
            Console.WriteLine("Heater turned ON");
        }

        public void TurnOff()
        {
            On = false;
            Console.WriteLine("Heater turned OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Heater is {(On ? "ON" : "OFF")}");
        }
    }
    }
