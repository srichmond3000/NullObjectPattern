using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        private static IDeviceRepository _deviceRepository = new DeviceRepository();

        static void Main (string[] args)
        {
            // Valid will talk to real object.
            ConnectToDevice("Camera");

            // Invalid so will talk to null object.
            ConnectToDevice("any old name");

            Console.Read();
        }

        public static void ConnectToDevice(string deviceName)
        {
            IDevice device = _deviceRepository.GetDeviceByName(deviceName);
            device.Connect();
        }
    }
}
