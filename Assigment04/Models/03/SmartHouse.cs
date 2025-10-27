using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._03
{
    public class SmartHome
    {
        private Dictionary<DeviceType, ISmartDevice> devices;

        public SmartHome()
        {
            
            devices = new Dictionary<DeviceType, ISmartDevice>
        {
            { DeviceType.Light, new Light() },
            { DeviceType.Fan, new Fan() },
            { DeviceType.AC, new AC() },
            { DeviceType.Heater, new Heater() }
        };
        }

       
        public ISmartDevice this[DeviceType type]
        {
            get { return devices[type]; }
        }
    }
}
